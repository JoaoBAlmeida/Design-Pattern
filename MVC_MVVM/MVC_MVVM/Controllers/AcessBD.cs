using System;
using System.Collections.Generic;
using System.Text;
using MVC_MVVM.Models;

namespace MVC_MVVM.Controllers
{
    public class AcessBD : IDisposable
    {
        public void AcessDB()
        {
            //Onde seria feita a conexão com o banco de dados
        }
        public bool InsertDB(Paciente pacient)
        {
            //Função para inserção no banco
            if (pacient.getNome() != null) return true;
            return false;
        }

        public Paciente[] GetDB()
        {
            //Função que deveria retornar do banco os valores para preencher o Model Paciente
            Paciente[] pacients = new Paciente[5];
            pacients[0] = new Paciente(1, "854.019.534-02", "Mario Santos Pereira", "12/05/1998", 1.74, 87);
            pacients[1] = new Paciente(2, "953.113.624-12", "Carla Silva Almeida", "25/07/1993", 1.52, 57);
            pacients[2] = new Paciente(3, "344.169.555-57", "Souza Pereira Buarque", "13/09/1993", 1.83, 98);
            pacients[3] = new Paciente(4, "359.321.734-09", "Chico Terezina Silva", "02/11/1995", 1.90, 88);
            pacients[4] = new Paciente(5, "823.049.623-85", "Larissa Alves", "23/01/1989", 1.64, 75);
            return pacients;
        }

        public void Dispose()
        {
            //Função para destruir o banco
        }
    }
}
