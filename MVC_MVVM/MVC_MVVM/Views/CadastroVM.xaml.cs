using MVC_MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVC_MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroVM : ContentPage
    {
        public CadastroVM()
        {
            ViewModel.CadastroVM cadastro = new ViewModel.CadastroVM();
            this.BindingContext = cadastro;
            cadastro.ERROR += () => DisplayAlert("ERROR", "Garanta que todos os dados foram inseridos", "OK");
            cadastro.SUCCESS += () => DisplayAlert("SUCCESS", "Dados Salvos com Sucesso", "OK");
            InitializeComponent();
            EntryNome.Completed += (object sender, EventArgs args) =>
            {
                UserCPF.Focus();
            };
            UserCPF.Completed += (object sender, EventArgs args) =>
            {
                Date.Focus();
            };
            Date.Completed += (object sender, EventArgs args) =>
            {
                height.Focus();
            };
            height.Completed += (object sender, EventArgs args) =>
            {
                height.Focus();
            };
            weight.Completed += (object sender, EventArgs args) =>
            {
                cadastro.Submit.Execute(null);
            };
        }
    }
}