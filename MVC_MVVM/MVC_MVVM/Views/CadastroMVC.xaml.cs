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
    public partial class CadastroMVC : ContentPage
    {
        public CadastroMVC()
        {
            InitializeComponent();
        }

        private void SaveIT(object sender, EventArgs e)
        {
            if (this.UserCPF.Text == String.Empty ||
                this.EntryNome.Text == String.Empty ||
                this.Date.Text == String.Empty ||
                this.height.Text == String.Empty ||
                this.weight.Text == String.Empty)
            {
                DisplayAlert("ERROR", "Todos os dados devem ser preenchidos", "X");
                return;
            }

            Paciente pacient = new Paciente(
                6,
                this.UserCPF.Text,
                this.EntryNome.Text,
                this.Date.Text,
                double.Parse(this.height.Text),
                double.Parse(this.weight.Text)
            );
            using(AcessBD database = new AcessBD())
            {
                if (database.InsertDB(pacient)) DisplayAlert("OK", "Dados salvos com Sucesso", "V");
                else DisplayAlert("ERROR", "Dados não foram Salvos", "X");
            }
        }
    }
}