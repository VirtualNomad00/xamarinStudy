using HAIS.DailyFuel.APP.Models;
using SQLite;
using SQLiteNetExtensionsAsync.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace HAIS.DailyFuel.APP.Data
{
    public class DailyFuelLocalDatabase
    {
        private readonly SQLiteAsyncConnection database;

        public DailyFuelLocalDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<City>().Wait();
            database.CreateTableAsync<State>().Wait();
            database.CreateTableAsync<FuelStation>().Wait();
            database.CreateTableAsync<StationFuelDetail>().Wait();
            database.CreateTableAsync<AverageFuelPrice>().Wait();
        }

        public void StoreStateCity ( List<State> StateList, List<City> CityList)
        {
            var connection = database.GetConnection();
            connection.Execute("DELETE FROM State");
            connection.Execute("DELETE FROM City");
            database.InsertAllAsync(StateList);
            database.InsertAllAsync(CityList);

        }

        public void FillTableForTest()
        {
            var queryWriter = database.GetConnection();
            //TableExists("State", queryWriter);
            queryWriter.Query<State>("INSERT INTO State (Id, Name)values (1, 'Antony')");
            queryWriter.Query<State>("INSERT INTO State (Id, Name)values (2, 'Blake')");
            queryWriter.Query<State>("INSERT INTO State (Id, Name)values (3, 'Catherine')");
            queryWriter.Query<State>("INSERT INTO State (Id, Name)values (4, 'Jude')");
            queryWriter.Query<State>("INSERT INTO State (Id, Name)values (5, 'Mark')");
            queryWriter.Query<State>("INSERT INTO State (Id, Name)values (6, 'Anderson')");
            queryWriter.Query<State>("INSERT INTO State (Id, Name)values (7, 'Wilson')");
            queryWriter.Query<State>("INSERT INTO State (Id, Name)values (8, 'Jade')");
            queryWriter.Query<State>("INSERT INTO State (Id, Name)values (9, 'Zachery')");
            queryWriter.Query<City>("INSERT INTO City (Id, Name,StateId, Latitude, Longitude)values (1, 'Zachery1', 1, 100023.456, 100023.456)");
            queryWriter.Query<City>("INSERT INTO City (Id, Name,StateId, Latitude, Longitude)values (2, 'Zachery2', 1, 100023.456, 100023.456)");
            queryWriter.Query<City>("INSERT INTO City (Id, Name,StateId, Latitude, Longitude)values (3, 'Zachery3', 1, 100023.456, 100023.456)");
            queryWriter.Query<City>("INSERT INTO City (Id, Name,StateId, Latitude, Longitude)values (4, 'Zachery4', 1, 100023.456, 100023.456)");
            queryWriter.Query<City>("INSERT INTO City (Id, Name,StateId, Latitude, Longitude)values (5, 'Zachery5', 1, 100023.456, 100023.456)");
            queryWriter.Query<City>("INSERT INTO City (Id, Name,StateId, Latitude, Longitude)values (6, 'Zachery6', 1, 100023.456, 100023.456)");
            queryWriter.Query<City>("INSERT INTO City (Id, Name,StateId, Latitude, Longitude)values (7, 'Zachery7', 1, 100023.456, 100023.456)");
            queryWriter.Query<City>("INSERT INTO City (Id, Name,StateId, Latitude, Longitude)values (8, 'Zachery8', 1, 100023.456, 100023.456)");
        }

    public Task<List<City>> GetCityListAsync(int stateId)
        {
            return database.Table<City>()
                .Where(i => i.StateId == stateId)
                .ToListAsync();
        }

        public Task<int> InsertCityAsync(List<City> cityList)
        {
            return database.InsertAsync(cityList);
        }

        public Task<List<State>> GetStateListAsync()
        {
            return database.Table<State>().ToListAsync();
        }

        public Task<int> InsertStateAsync(List<State> stateList)
        {
            return database.InsertAllAsync(stateList);
        }
       
        public Task<List<AverageFuelPrice>> GetCityAverageFuelPrice(int cityId)
        {
            return database.Table<AverageFuelPrice>()
                .Where(i => i.CityId == cityId).ToListAsync();
        }

        public Task<int> InsertAvgFuelPrice(List<AverageFuelPrice> cityFuelPriceList)
        {
            return database.InsertAllAsync(cityFuelPriceList);

        }

        public Task DeleteCurrentCityFuelData(List<AverageFuelPrice> avgFuelPriceList)
        {
            return database.DeleteAllAsync(avgFuelPriceList);
        }

        public Task<List<FuelStation>> GetLocalFuelStationList(int cityId)
        {
            return database.GetAllWithChildrenAsync<FuelStation>(i => i.CityId == cityId);
        }

        public Task InsertFuelStationList(List<FuelStation> fuelStationList)
        {
            return database.InsertAllWithChildrenAsync(fuelStationList, recursive : true);
            //return database.UpdateAllAsync(fuelStationList);
        }

        public bool DeleteFuelStationList(List<FuelStation> fuelStationList)
        {
            try
            {
                foreach (FuelStation FS in fuelStationList)
                {
                   // StationFuelDetail fuelDetail =;
                    database.DeleteAllAsync(FS.FuelDetail);
                    database.DeleteAsync(FS);
                }
                return true;
            }
            catch( Exception ex)
            {
                Debug.WriteLine("Error while deleting fuel station info :" + ex);
                return false;
            }
            
        }



        //just for testing purpose
        public Task<List<StationFuelDetail>> GetStationFuelDetails()
        {
            return database.Table<StationFuelDetail>().ToListAsync();
        }
        public Task<int> EmptyTables()
        {
            database.DropTableAsync<State>().Wait();
            database.CreateTableAsync<State>().Wait();
            database.DropTableAsync<City>().Wait();
            database.CreateTableAsync<City>().Wait();
            return null;
        }

        //public static Boolean TableExists(String tableName, SQLiteConnection connection)
        //{
        //    SQLite.TableMapping map = new TableMapping(typeof(State)); // Instead of mapping to a specific table just map the whole database type
        //    object[] ps = new object[0]; // An empty parameters object since I never worked out how to use it properly! (At least I'm honest)

        //    Int32 tableCount = connection.Query(map, "SELECT * FROM sqlite_master WHERE type = 'table' AND name = '" + tableName + "'", ps).Count; // Executes the query from which we can count the results
        //    if (tableCount == 0)
        //    {
        //        return false;
        //    }
        //    else if (tableCount == 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        throw new Exception("More than one table by the name of " + tableName + " exists in the database.", null);
        //    }

        //}

    }
}
