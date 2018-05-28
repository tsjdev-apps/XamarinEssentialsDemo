using System;
using Xamarin.Forms;
using XamarinEssentialsApp.Views;

namespace XamarinEssentialsApp
{
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void AppInfoButtonOnClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppInfoPage());
        }

        private async void BatteryButtonOnClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BatteryPage());
        }
    }
}
