using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

        }
        private async void OnLoginClicked(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(usernameEntry.Text))
            {
                await DisplayAlert("Ошибка", "Пожалуйста, введите имя пользователя.", "OK");
                return; 
            }

            if (string.IsNullOrWhiteSpace(passwordEntry.Text))
            {
                await DisplayAlert("Ошибка", "Пожалуйста, введите пароль.", "OK");
                return; 
            }
            if (usernameEntry.Text != "karina" || passwordEntry.Text != "123")
            {
                await DisplayAlert("Ошибка", "Неверное имя пользователя или пароль.", "OK");
                return;
            }

            
            await Navigation.PushAsync(new Page());
        }
    }
}