using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HAIS.DailyFuel.APP.Helper;
using Xamarin.Forms.Maps;
using HAIS.DailyFuel.APP.ViewModels;
using HAIS.DailyFuel.APP.Models;

namespace HAIS.DailyFuel.APP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        DailyFuelViewModel vm;
        CustomMap map;
        public MapPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = vm = ViewModelLocator.DailyFuelViewModel;
            var initialPosition = new Position(vm.CurrentLocation.Lat, vm.CurrentLocation.Long);
            map = new CustomMap(initialPosition)
            {
                IsShowingUser = true,
                MapType = MapType.Street
            };
            foreach (FuelStation fuelStation in vm.FuelStationList)
            {
                Position pinPosition = new Position(fuelStation.Latitude, fuelStation.Longitude);
                var pin = new Pin
                {
                    Type = PinType.Place,
                    Position = pinPosition,
                    Label = "Petrol Pump Cruz",
                    Address = "custom detail info"
                };
                map.Pins.Add(pin);
            }
            var stack = new StackLayout { Spacing = 0 };
            Header header = new Header();
            Footer footer = new Footer();
            Label label = new Label
            {
                Text = "Disclamer : The price might not be 100% accurate"
            };
            Frame frame = new Frame
            {
                Content = map,
                OutlineColor = Color.Silver,
                MinimumHeightRequest = 150,
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
                
            };
            label.HorizontalTextAlignment = TextAlignment.Center;
            label.Margin = new Thickness(0, 0, 0, 20);
            stack.Children.Add(header);
            stack.Children.Add(frame);
            stack.Children.Add(label);
            stack.Children.Add(footer);
            Content = stack;
        }

    }
}