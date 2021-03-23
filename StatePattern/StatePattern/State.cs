using StatePattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.StatePattern
{
    public abstract class State
    {
        protected int drinks;
        public abstract void Handle(ColaMachine machine);

        public int Drinks
        {
            get { return drinks; }
            set { drinks = value; }
        }

        public abstract void GetDrink();
        public abstract void Refill(int qtd);

    }
}
