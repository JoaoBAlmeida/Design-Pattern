using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVC_MVVM.ViewModel
{
    public class CadastroVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        private string name;
        //Com o bind na criação do atributo, a cada nova tecla, esse public é chamado, e a PropertyChanged garante de manter o informações atualizadas
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }
        }

        private string cpf;
        public string CPF
        {
            get { return cpf; }
            set
            {
                cpf = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CPF"));
            }
        }

        private string birth;
        public string Birth
        {
            get { return birth; }
            set
            {
                birth = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Birth"));
            }
        }

        private string altura;
        public string Altura
        {
            get { return altura; }
            set
            {
                altura = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Altura"));
            }
        }

        private string peso;
        public string Peso
        {
            get { return peso; }
            set
            {
                peso = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Peso"));
            }
        }

        public ICommand Submit { get; set; }
        public Action ERROR;
        public Action SUCCESS;
        public CadastroVM()
        {
            Submit = new Command(OnSubmit);
        }
        public void OnSubmit()
        {
            if (name == null || name == string.Empty
                || cpf == null || cpf == string.Empty
                || birth == null || birth == string.Empty
                || altura == null || altura == string.Empty
                || peso == null || peso == string.Empty) ERROR();
            else SUCCESS();
            //else
            //adciona os valores dentro do model Paciente e poderia guardar em um banco de dados ou outro local
        }
    }
}
