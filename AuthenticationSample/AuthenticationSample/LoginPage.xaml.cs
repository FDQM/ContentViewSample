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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async private void ButtonGoSignUp(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(EntryEmail.Text) || String.IsNullOrEmpty(PasswordEntry.Text))
            {
                await DisplayAlert("Alert", "Password or Email Empty", "OK");
            }
            else
            {
                await Navigation.PushAsync(new SignUpPage(EntryEmail.Text));
            }
        }
    }
}