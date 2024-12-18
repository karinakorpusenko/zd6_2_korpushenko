using System;
using tabbed.Services;
using tabbed.Views;
using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;
using Xamarin.Forms.Xaml;

namespace tabbed
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            InitializeComponent();
          
            MainPage = new TabbedPage
            {
                Children =
        {
            new NavigationPage(new LoginPage()) { Title = "Вход" },
            new NavigationPage(new Page()) { Title = "Кредитный калькулятор" }
        }
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
