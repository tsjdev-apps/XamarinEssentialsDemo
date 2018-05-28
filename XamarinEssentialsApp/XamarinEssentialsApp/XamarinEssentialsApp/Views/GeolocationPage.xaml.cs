using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentialsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GeolocationPage : ContentPage
    {
        public GeolocationPage()
        {
            InitializeComponent();
        }

        private async void GetLastKnownLocationButtonOnClicked(object sender, EventArgs e)
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();
                await DisplayAlert("Geolocation", location != null ? $"Latitude: {location.Latitude}{Environment.NewLine}Longitude: {location.Longitude}" : "Your last known location is currently unknown.", "Ok");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Geolocation", $"Something went wrong: {ex}", "Ok");
            }
        }

        private async void GetLocationButtonOnClicked(object sender, EventArgs e)
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.Medium);
                var location = await Geolocation.GetLocationAsync(request);
                await DisplayAlert("Geolocation", location != null ? $"Latitude: {location.Latitude}{Environment.NewLine}Longitude: {location.Longitude}" : "Your last known location is currently unknown.", "Ok");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Geolocation", $"Something went wrong: {ex}", "Ok");
            }
        }
    }
}