using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_MVVM.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVC_MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaMVVM : ContentPage
    {
        public ListaMVVM()
        {
            InitializeComponent();
            BindingContext = new PacientsVM();
        }
    }
}