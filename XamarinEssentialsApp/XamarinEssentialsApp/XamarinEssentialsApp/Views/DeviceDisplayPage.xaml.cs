using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentialsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeviceDisplayPage : ContentPage
    {
        public DeviceDisplayPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            var metrics = DeviceDisplay.ScreenMetrics;

            OrientationLabel.Text = metrics.Orientation.ToString();
            RotationLabel.Text = metrics.Rotation.ToString();
            ScreenWidthLabel.Text = metrics.Width.ToString();
            ScreenHeightLabel.Text = metrics.Height.ToString();
            DensityLabel.Text = metrics.Density.ToString();
        }
    }
}