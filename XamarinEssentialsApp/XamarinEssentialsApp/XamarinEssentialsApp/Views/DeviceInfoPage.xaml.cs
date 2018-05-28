using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentialsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceInfoPage : ContentPage
    {
        public DeviceInfoPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            DeviceLabel.Text = DeviceInfo.Model;
            ManufacturerLabel.Text = DeviceInfo.Manufacturer;
            DeviceNameLabel.Text = DeviceInfo.Name;
            VersionLabel.Text = DeviceInfo.VersionString;
            PlatformLabel.Text = DeviceInfo.Platform;
            IdiomLabel.Text = DeviceInfo.Idiom;
            DeviceTypeLabel.Text = DeviceInfo.DeviceType.ToString();
        }
    }
}