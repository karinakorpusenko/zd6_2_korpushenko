using System;
using System.Collections.Generic;
using tabbed.ViewModels;
using tabbed.Views;
using Xamarin.Forms;

namespace tabbed
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
