using System.ComponentModel;
using tabbed.ViewModels;
using Xamarin.Forms;

namespace tabbed.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}