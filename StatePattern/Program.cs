using StatePattern.Models;
using StatePattern.StatePattern;
using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicialização do contexto
            ColaMachine machina = new ColaMachine(new FilledState());

            //Chamadas da função do contexto
            int opt = 0;
            do
            {
                Console.WriteLine("=================================");
                Console.WriteLine("What do you Desire?\n1 - Cola\n2 - Exit");
                opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        machina.GetDrink();
                        break;
                    case 2:
                        Console.WriteLine("Good Bye");
                        break;
                    default:
                        opt = 0;
                        Console.WriteLine("Please try again!");
                        break;
                }
            } while (opt != 2);
        }
    }
}
