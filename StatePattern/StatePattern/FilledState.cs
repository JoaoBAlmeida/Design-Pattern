using StatePattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.StatePattern
{
    public class FilledState : State
    {
        public override void GetDrink()
        {
            Drinks -= 1;
            Console.WriteLine("New cold cola delivered");
        }

        public override void Handle(ColaMachine machine)
        {
            machine.State = new EmptyState();
        }

        public override void Refill(int qtd)
        {
            Console.WriteLine("No need to refill, still got more inside");
            return;
        }
    }
}
