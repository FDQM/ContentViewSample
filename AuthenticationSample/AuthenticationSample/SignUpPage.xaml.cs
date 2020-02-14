using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AuthenticationSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage(String Email)
        {
            InitializeComponent();
            NewEmail.Text = Email;
        }

        async void GoToMenu(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NewEmail.Text) || String.IsNullOrEmpty(NewPassword.Text) || String.IsNullOrEmpty(RepeatNewPassword.Text))
            {
                await DisplayAlert("Alert", "Password or Email Empty", "OK");
            }
            else
            {
                await Navigation.PushAsync(new MenuPage());
            }
        }
    }
}