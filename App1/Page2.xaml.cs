using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            Title = "Курсы валют";
            InitializeComponent();
            RefreshData();
        }

        public void RefreshData()
        {
            DateTime currentDate = DateTime.Now;
            CurrentDateLabel.Text = currentDate.ToString("dd MMMM yyyy");
        }

    }
}