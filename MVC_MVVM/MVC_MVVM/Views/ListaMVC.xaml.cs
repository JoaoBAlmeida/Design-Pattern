using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MVC_MVVM.Models;
using MVC_MVVM.Controllers;

namespace MVC_MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaMVC : ContentPage
    {
        List<Paciente> pacients = new List<Paciente>();
        public ListaMVC()
        {
            InitializeComponent();
            BindingContext = pacients;
        }

        private void GetList(object sender, EventArgs e)
        {
            using (AcessBD database = new AcessBD())
            {
                Paciente[] users = database.GetDB();
                foreach (Paciente paciente in users)
                {
                    pacients.Add(paciente);
                }

            }
            LvData.ItemsSource = pacients;
        }
    }
}