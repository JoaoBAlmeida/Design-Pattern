using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_MVVM.Models
{
    public class Paciente
    {
        public int ID { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public double Altura { get; set; }
        public double Peso { get; set; }

        public Paciente(int id, string cpf, string name, string birth, double height, double weight)
        {
            this.ID = id;
            this.CPF = cpf;
            this.Nome = name;
            this.DataNascimento = birth;
            this.Altura = height;
            this.Peso = weight;
        }

        public int getID()
        {
            return this.ID;
        }

        public string getCPF()
        {
            return this.CPF;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public string getData()
        {
            return this.DataNascimento;
        }

        public double getAltura()
        {
            return this.Altura;
        }

        public double getPeso()
        {
            return this.Peso;
        }
    }
}
