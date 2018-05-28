using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentialsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BatteryPage : ContentPage
	{
		public BatteryPage ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();

            BatteryLevelLabel.Text = Battery.ChargeLevel.ToString();
            BatteryStateLabel.Text = Battery.State.ToString();
            BatteryPowerSourceLabel.Text = Battery.PowerSource.ToString();
        }
    }
}