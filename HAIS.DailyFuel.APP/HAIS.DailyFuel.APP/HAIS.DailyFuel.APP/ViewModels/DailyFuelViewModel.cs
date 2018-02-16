using HAIS.DailyFuel.APP.Data;
using HAIS.DailyFuel.APP.Models;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace HAIS.DailyFuel.APP.ViewModels
{
    class DailyFuelViewModel : INotifyPropertyChanged
    {
        IMyLocation GetCurrentLocation;

        private List<State> _stateList = new List<State>();
        private List<City> _cityList = new List<City>();
        private List<FuelStation> _fuelStationList = new List<FuelStation>();
        private List<AverageFuelPrice> _cityFuelAvgPriceList = new List<AverageFuelPrice>();
        private Location _currentLocation;
        private State _selectedState;
        private City _selectedCity;
        private bool _isPriceViewAvailable = true;
        private string _currentDate;

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Location CurrentLocation
        {
            get
            {
                return _currentLocation;
            }
            set
            {
                _currentLocation = value;
                NotifyPropertyChanged("CurrentLocation");
                PrePopulateLocation();
            }
        }

        public State SelectedState
        {
            get
            {
                return _selectedState;
            }
            set
            {
                _selectedState = value;
                //IsPriceViewAvailable = false;
                NotifyPropertyChanged("SelectedState");
                CityFuelAvgPriceList.Clear();
            }
        }

        public City SelectedCity
        {
            get
            {
                return _selectedCity;
            }
            set
            {
                _selectedCity = value;
                NotifyPropertyChanged("SelectedCity");
                CityFuelAvgPriceList.Clear();
            }
        }


        public List<State> StateList
        {
            get
            {
                return _stateList;
            }
            set
            {
                _stateList = value;
                NotifyPropertyChanged("StateList");
            }
        }


        public List<City> CityList
        {
            get
            {
                return _cityList;
            }
            set
            {
                _cityList = value;
                NotifyPropertyChanged("CityList");
            }
        }

        public List<FuelStation> FuelStationList
        {
            get
            {
                return _fuelStationList;
            }
            set
            {
                _fuelStationList = value;
                NotifyPropertyChanged("FuelStationList");
            }
        }

        public List<AverageFuelPrice> CityFuelAvgPriceList
        {
            get
            {
                return _cityFuelAvgPriceList;
            }
            set
            {
                _cityFuelAvgPriceList = value;
                NotifyPropertyChanged("CityFuelAvgPriceList");
            }
        }

        public bool IsPriceViewAvailable
        {
            get
            {
                return _isPriceViewAvailable;
            }
            set
            {
                _isPriceViewAvailable = value;
                NotifyPropertyChanged("IsPriceViewAvailable");
            }
        }

        public string CurrentDate
        {
            get
            {
                return _currentDate;
            }
            set
            {
                _currentDate = value;
                NotifyPropertyChanged("CurrentDate");
            }
        }

        public ICommand ChangeCitySource { get; private set; }
        public ICommand GetAvgFuelPrice { get; private set; }

        public DailyFuelViewModel()
        {
            App.Database.EmptyTables();
            App.Database.FillTableForTest();
            IsPriceViewAvailable = false;
            CurrentDate = DateTime.Now.ToString("d MMMM yyyy");
            GetCurrentLocation = DependencyService.Get<IMyLocation>();
            GetCurrentLocation.LocationObtained += (object sender, ILocationEventArgs e) =>
            {
                CurrentLocation = new Location
                {
                    Lat = e.Lat,
                    Long = e.Long
                };
            };
            GetCurrentLocation.ObtainMyLocation();

            State state = new State();
            City city = new City();

            if (Application.Current.Properties.ContainsKey("DatabaseVersionHash"))
            {
                //Call get State API if we get result we isert data in background else not 
            }
            else
            {
                //Call the get 
                // var result = "apiCall";
                //App.Database.StoreStateCity( StateListFromAPI, CityListFromAPI);
                Application.Current.Properties["DatabaseVersionHash"] = true;

            }

            PopulateStateList();

            ChangeCitySource = new Command(PopulateCityList);
            GetAvgFuelPrice = new Command(PopulateFuelInfo);

        }

        private void PrePopulateLocation()
        {
            if (SelectedState == null && SelectedCity == null)
            {
                //get address from location coordinates then find the city with the nearest coordinated and from there fetch the city and set them as selected State and city 
                //var geolocator =  CrossGeolocator.Current;
                //Position position = new Position();
                //position.Latitude = CurrentLocation.Lat;
                //position.Longitude = CurrentLocation.Long;
                //if (geolocator.IsGeolocationEnabled && CrossGeolocator.IsSupported && geolocator.IsGeolocationAvailable)
                //{
                //    var address =  await geolocator.GetAddressesForPositionAsync(position);

                //}

                //Comparer currentLocation with city coordinates and get the closest match 
                SelectedState = new State();
                SelectedCity = new City();
                // PopulateFuelInfo();

            }
        }

        private async void PopulateStateList()
        {
            StateList = await App.Database.GetStateListAsync();
        }

        private async void PopulateCityList()
        {
            CityList = await App.Database.GetCityListAsync(SelectedState.Id);
        }

        private async void PopulateFuelInfo()
        {
            if (SelectedCity == null)
                return;

           FuelStationList = await App.Database.GetLocalFuelStationList(SelectedCity.Id);
            if (FuelStationList.Count == 0 || (FuelStationList[0].FuelDetail[0].UpdatedOn).Subtract(DateTime.Now).TotalHours > 24)
            {


                //replace mock data with actual data 
                var isDeleted = App.Database.DeleteFuelStationList(FuelStationList);
                //call API and populate database table
            FuelStationList = MockFuelStationList();
                var result = App.Database.InsertFuelStationList(FuelStationList);
                //handle faliure scenario
            }

            CityFuelAvgPriceList = await App.Database.GetCityAverageFuelPrice(SelectedCity.Id);
            if (CityFuelAvgPriceList.Count == 0)
            {
                //get result from APi and populate database
                // populate average petrol and diesel price and change for the day
                CityFuelAvgPriceList = MockCityFuelData(SelectedCity.Id);
                var result = await App.Database.InsertAvgFuelPrice(CityFuelAvgPriceList);
            }
            //IsPriceViewAvailable = true;
            //else //if ((CityFuelAvgPriceList[0].UpdatedOn).Subtract(DateTime.Now).TotalHours > 24)
            //{

            //    // populate average petrol and diesel price and change for the day
            //    await App.Database.DeleteCurrentCityFuelData(CityFuelAvgPriceList);
            //    //get result from APi and populate database
            //    CityFuelAvgPriceList = MockCityFuelData();
            //    var result = await App.Database.InsertAvgFuelPrice(CityFuelAvgPriceList);
            //}

        }

        private List<AverageFuelPrice> MockCityFuelData(int id)
        {
            List<AverageFuelPrice> mockCityFuelPriceList = new List<AverageFuelPrice>();
            AverageFuelPrice mockAverageCityFuelObj1 = new AverageFuelPrice
            {
                CityId = id,
                Price = 22,
                Type = "Petrol",
                UpdatedOn = DateTime.Now,
                Change = 20
            };

            AverageFuelPrice mockAverageCityFuelObj2 = new AverageFuelPrice
            {
                CityId = id,
                Price = 22,
                Type = "Diesel",
                UpdatedOn = DateTime.Now,
                Change = 20
            };
            mockCityFuelPriceList.Add(mockAverageCityFuelObj1);
            mockCityFuelPriceList.Add(mockAverageCityFuelObj2);
            return mockCityFuelPriceList;
        }

        private List<FuelStation> MockFuelStationList()
        {
            List<FuelStation> mockFuelStationList = new List<FuelStation>();
            StationFuelDetail mockStationFuel = new StationFuelDetail
            {
                Price = 22,
                Type = "Diesel",
                UpdatedOn = DateTime.Now,
                StationId = 1
            };
            StationFuelDetail mockStationFuel1 = new StationFuelDetail
            {
                Price = 22,
                Type = "Petrol",
                UpdatedOn = DateTime.Now,
                StationId = 1
            };
            StationFuelDetail mockStationFuel2 = new StationFuelDetail
            {
                Price = 22,
                Type = "Diesel",
                UpdatedOn = DateTime.Now,
                StationId = 2
            };
            StationFuelDetail mockStationFuel3 = new StationFuelDetail
            {
                Price = 22,
                Type = "Petrol",
                UpdatedOn = DateTime.Now,
                StationId = 2
            };
            StationFuelDetail mockStationFuel4 = new StationFuelDetail
            {
                Price = 22,
                Type = "Diesel",
                UpdatedOn = DateTime.Now,
                StationId = 3
            };
            StationFuelDetail mockStationFuel5 = new StationFuelDetail
            {
                Price = 22,
                Type = "Petrol",
                UpdatedOn = DateTime.Now,
                StationId = 3
            };
            StationFuelDetail mockStationFuel6 = new StationFuelDetail
            {
                Price = 22,
                Type = "Diesel",
                UpdatedOn = DateTime.Now,
                StationId = 4
            };
            StationFuelDetail mockStationFuel7 = new StationFuelDetail
            {
                Price = 22,
                Type = "Petrol",
                UpdatedOn = DateTime.Now,
                StationId = 4
            };

            FuelStation mockFuelStation1 = new FuelStation
            {
                Id = 1,
                Name = "Indian Oil",
                Latitude = 31.096049,
                Longitude = 77.15449899999999,
                CityId = 1,
                FuelDetail = new List<StationFuelDetail>()
            };
            mockFuelStation1.FuelDetail.Add(mockStationFuel);
            mockFuelStation1.FuelDetail.Add(mockStationFuel1);
            FuelStation mockFuelStation2 = new FuelStation
            {
                Id = 2,
                Name = "Indian Oil",
                Latitude = 31.0984521,
                Longitude = 77.16145800000004,
                CityId = 1,
                FuelDetail = new List<StationFuelDetail>()
            };
            mockFuelStation2.FuelDetail.Add(mockStationFuel2);
            mockFuelStation2.FuelDetail.Add(mockStationFuel3);
            FuelStation mockFuelStation3 = new FuelStation
            {
                Id = 3,
                Name = "Indian Oil",
                Latitude = 31.103762,
                Longitude = 77.16840300000001,
                CityId = 1,
                FuelDetail = new List<StationFuelDetail>()
            };
            mockFuelStation3.FuelDetail.Add(mockStationFuel5);
            mockFuelStation3.FuelDetail.Add(mockStationFuel4);
            FuelStation mockFuelStation4 = new FuelStation
            {
                Id = 4,
                Name = "Indian Oil",
                Latitude = 31.105114,
                Longitude = 77.16227490000006,
                CityId = 1,
                FuelDetail = new List<StationFuelDetail>()
            };
            mockFuelStation4.FuelDetail.Add(mockStationFuel6);
            mockFuelStation4.FuelDetail.Add(mockStationFuel7);

            mockFuelStationList.Add(mockFuelStation1);
            mockFuelStationList.Add(mockFuelStation2);
            mockFuelStationList.Add(mockFuelStation3);
            mockFuelStationList.Add(mockFuelStation4);

            return mockFuelStationList;
        }

        private List<FuelStation> MockFuelStationList2()
        {
            List<FuelStation> mockFuelStationList = new List<FuelStation>();
            StationFuelDetail mockStationFuel = new StationFuelDetail
            {
                Price = 44,
                Type = "Diesel",
                UpdatedOn = DateTime.Now,
                StationId = 1
            };
            StationFuelDetail mockStationFuel1 = new StationFuelDetail
            {
                Price = 44,
                Type = "Petrol",
                UpdatedOn = DateTime.Now,
                StationId = 1
            };
            StationFuelDetail mockStationFuel2 = new StationFuelDetail
            {
                Price = 44,
                Type = "Diesel",
                UpdatedOn = DateTime.Now,
                StationId = 2
            };
            StationFuelDetail mockStationFuel3 = new StationFuelDetail
            {
                Price = 22,
                Type = "Petrol",
                UpdatedOn = DateTime.Now,
                StationId = 2
            };
            StationFuelDetail mockStationFuel4 = new StationFuelDetail
            {
                Price = 22,
                Type = "Diesel",
                UpdatedOn = DateTime.Now,
                StationId = 3
            };
            StationFuelDetail mockStationFuel5 = new StationFuelDetail
            {
                Price = 22,
                Type = "Petrol",
                UpdatedOn = DateTime.Now,
                StationId = 3
            };
            StationFuelDetail mockStationFuel6 = new StationFuelDetail
            {
                Price = 22,
                Type = "Diesel",
                UpdatedOn = DateTime.Now,
                StationId = 4
            };
            StationFuelDetail mockStationFuel7 = new StationFuelDetail
            {
                Price = 22,
                Type = "Petrol",
                UpdatedOn = DateTime.Now,
                StationId = 4
            };

            FuelStation mockFuelStation1 = new FuelStation
            {
                Id = 1,
                Name = "Bharat Oil",
                Latitude = -234.095,
                Longitude = 234.6799,
                CityId = 1,
                FuelDetail = new List<StationFuelDetail>()
            };
            mockFuelStation1.FuelDetail.Add(mockStationFuel);
            mockFuelStation1.FuelDetail.Add(mockStationFuel1);
            FuelStation mockFuelStation2 = new FuelStation
            {
                Id = 2,
                Name = "Bharat Oil",
                Latitude = -234.095,
                Longitude = 234.6799,
                CityId = 1,
                FuelDetail = new List<StationFuelDetail>()
            };
            mockFuelStation2.FuelDetail.Add(mockStationFuel2);
            mockFuelStation2.FuelDetail.Add(mockStationFuel3);
            FuelStation mockFuelStation3 = new FuelStation
            {
                Id = 3,
                Name = "Bharat Oil",
                Latitude = -234.095,
                Longitude = 234.6799,
                CityId = 1,
                FuelDetail = new List<StationFuelDetail>()
            };
            mockFuelStation3.FuelDetail.Add(mockStationFuel5);
            mockFuelStation3.FuelDetail.Add(mockStationFuel4);
            FuelStation mockFuelStation4 = new FuelStation
            {
                Id = 4,
                Name = "Bharat Oil",
                Latitude = -234.095,
                Longitude = 234.6799,
                CityId = 1,
                FuelDetail = new List<StationFuelDetail>()
            };
            mockFuelStation4.FuelDetail.Add(mockStationFuel6);
            mockFuelStation4.FuelDetail.Add(mockStationFuel7);

            mockFuelStationList.Add(mockFuelStation1);
            mockFuelStationList.Add(mockFuelStation2);
            mockFuelStationList.Add(mockFuelStation3);
            mockFuelStationList.Add(mockFuelStation4);

            return mockFuelStationList;
        }


    }
}
