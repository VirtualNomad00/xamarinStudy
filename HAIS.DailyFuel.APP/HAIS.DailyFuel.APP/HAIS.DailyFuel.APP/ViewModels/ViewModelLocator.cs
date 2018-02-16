using System;
using System.Collections.Generic;
using System.Text;

namespace HAIS.DailyFuel.APP.ViewModels
{
    class ViewModelLocator
    {
        private static DailyFuelViewModel _dailyFuelViewModel = new DailyFuelViewModel();
        public static DailyFuelViewModel DailyFuelViewModel
        {
            get
            {
                return _dailyFuelViewModel;
            }
        }
    }
}
