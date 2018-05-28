using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentialsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OpenBrowserPage : ContentPage
    {
        public OpenBrowserPage()
        {
            InitializeComponent();
        }

        private async void OpenWebsiteButtonOnClicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync(new Uri("https://www.tsjdev-apps.de"), BrowserLaunchType.SystemPreferred);
        }
    }
}