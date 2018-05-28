using System;
using System.Collections.Generic;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEssentialsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmailPage : ContentPage
    {
        public EmailPage()
        {
            InitializeComponent();
        }

        private async void SendButtonOnClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ToEntry.Text))
            {
                await DisplayAlert("Email", "Please provide a recipient.", "Ok");
                return;
            }

            if (string.IsNullOrEmpty(SubjectEntry.Text))
            {
                await DisplayAlert("Email", "Please provide a subject.", "Ok");
                return;
            }

            if (string.IsNullOrEmpty(MessageEntry.Text))
            {
                await DisplayAlert("Email", "Please provide a message.", "Ok");
                return;
            }

            try
            {
                var message = new EmailMessage
                {
                    To = new List<string> { ToEntry.Text },
                    Subject = SubjectEntry.Text,
                    Body = MessageEntry.Text
                };
                await Email.ComposeAsync(message);
            }
            catch (Exception ex)
            {
                await DisplayAlert("Email", $"Something went wrong while sending the Email: {ex}", "Ok");
            }
        }
    }
}