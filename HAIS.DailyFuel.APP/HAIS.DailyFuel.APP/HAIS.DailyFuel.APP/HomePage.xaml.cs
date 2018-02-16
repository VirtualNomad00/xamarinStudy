using HAIS.DailyFuel.APP.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HAIS.DailyFuel.APP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        
        public HomePage()
        {
            InitializeComponent();
            this.BindingContext =  ViewModelLocator.DailyFuelViewModel;
            NavigationPage.SetHasNavigationBar(this, false);
            
        }

        async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            var mapPage = new MapPage();
            await Navigation.PushAsync(mapPage, true);
        }

    }
}