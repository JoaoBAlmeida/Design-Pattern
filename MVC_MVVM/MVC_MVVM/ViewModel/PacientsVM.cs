using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text;
using MVC_MVVM.Models;

namespace MVC_MVVM.ViewModel
{
    public class PacientsVM
    {
        public ObservableCollection<Paciente> Pacientes { get; set; }
        public PacientsVM()
        {
            Pacientes = new ObservableCollection<Paciente>();
            //Poderia pegar os dados por um foreach de acesso ao banco?
            //Talvez um controller de acesso ao banco seja melhor nessa situação?
            Pacientes.Add(new Paciente(3, "344.169.555-57", "Souza Pereira Buarque", "13/09/1993", 1.83, 98));
            Pacientes.Add(new Paciente(1, "854.019.534-02", "Mario Santos Pereira", "12/05/1998", 1.74, 87));
            Pacientes.Add(new Paciente(2, "953.113.624-12", "Carla Silva Almeida", "25/07/1993", 1.52, 57));
        }
    }
}
