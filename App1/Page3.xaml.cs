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
    public partial class Page3 : TabbedPage
    {
        public Page3()
        {
            Children.Add(new Page1());
            Children.Add(new Page2());
        }
    }
}