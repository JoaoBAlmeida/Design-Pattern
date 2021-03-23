using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVC_MVVM.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoCadastroMVC(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroMVC());
        }

        private void GoListaMVC(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMVC());
        }

        private void GoCadastroMVVM(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroVM());
        }

        private void GoListaMVVM(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaMVVM());
        }
    }
}
