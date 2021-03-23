using StatePattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.StatePattern
{
    public class EmptyState : State
    {
        public override void GetDrink()
        {
            Console.WriteLine("No more drinks inside");
            return;
        }

        public override void Handle(ColaMachine machine)
        {
            machine.State = new FilledState();
        }

        public override void Refill(int qtd)
        {
            Console.WriteLine("Filling up....");
            Drinks = qtd;
            Console.WriteLine("There's " + Drinks + " inside");
        }
    }
}
