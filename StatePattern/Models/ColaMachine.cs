using StatePattern.StatePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern.Models
{
    public class ColaMachine
    {
        private State _state;

        public ColaMachine(State St)
        {
            this._state = St;
            State.Drinks = 2;
        }

        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine("New State attributed: " + _state.GetType().Name);
            }
        }

        public void GetDrink()
        {
            if (_state.GetType().Name == "FilledState" && _state.Drinks == 0)
            {
                Console.WriteLine("No more drinks...");
                RequestCare();

                //Could be called from outside, so as to not be automatic
                FillUP();

                return;
            }
            _state.GetDrink();
            Console.WriteLine("Still " + _state.Drinks + " drinks left inside");
        }

        public void RequestCare()
        {
            _state.Handle(this);
        }

        public void FillUP()
        {
            Console.WriteLine("Let's Fill her up!\nHow many drinks this time??");
            _state.Refill(Convert.ToInt32(Console.ReadLine()));
            RequestCare();
        }
    }
}
