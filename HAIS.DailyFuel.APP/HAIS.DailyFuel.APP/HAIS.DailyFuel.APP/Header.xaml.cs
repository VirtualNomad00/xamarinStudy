using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HAIS.DailyFuel.APP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Header : ContentView
    {
		public Header ()
		{
			InitializeComponent ();
		}

        async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}