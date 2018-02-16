using HAIS.DailyFuel.APP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HAIS.DailyFuel.APP
{
    public partial class App : Application
    {
        public static DailyFuelLocalDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HAIS.DailyFuel.APP.HomePage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static DailyFuelLocalDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new DailyFuelLocalDatabase(
                        DependencyService.Get<IFileHelper>().GetLocalFilePath("LocationSQLite.db3"));
                }
                return database;
            }
        }
    }
}
