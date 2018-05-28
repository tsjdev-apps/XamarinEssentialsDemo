using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentialsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TextToSpeechPage : ContentPage
    {
        public TextToSpeechPage()
        {
            InitializeComponent();
        }

        private async void SpeakButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextToSpeechEntry.Text))
            {
                await DisplayAlert("TextToSpeech", "Please provide a text which should I read.", "Ok");
                return;
            }

            await TextToSpeech.SpeakAsync(TextToSpeechEntry.Text);
        }
    }
}