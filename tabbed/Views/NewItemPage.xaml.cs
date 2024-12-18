using System;
using System.Collections.Generic;
using System.ComponentModel;
using tabbed.Models;
using tabbed.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tabbed.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}