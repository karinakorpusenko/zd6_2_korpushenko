using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Essentials;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
           
        }

        async void ShowErrorMessage(string message)
        {
            await Application.Current.MainPage.DisplayAlert("Ошибка", message, "OK");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (usernameEntry.Text != null && passwordEntry.Text != null)
            {
                if (usernameEntry.Text == "ects" && passwordEntry.Text == "ects2024")
                {
                    await Navigation.PushAsync(new Page3());
                }
                else ShowErrorMessage("Логин - ects, пароль - ects2024.");
            }
            else ShowErrorMessage("Логин и пароль не должны быть пустыми.");
        }

       
    }
}
