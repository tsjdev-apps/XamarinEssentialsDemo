using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentialsApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppInfoPage : ContentPage
	{
		public AppInfoPage ()
		{
			InitializeComponent ();
		}

	    protected override void OnAppearing()
	    {
	        base.OnAppearing();

	        AppNameLabel.Text = AppInfo.Name;
	        PackageNameLabel.Text = AppInfo.PackageName;
	        VersionLabel.Text = AppInfo.VersionString;
	        BuildLabel.Text = AppInfo.BuildString;
	    }
	}
}