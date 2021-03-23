using MementoPattern.Memento;
using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Models
{
    public class Character
    {
        private int _hp { get; set; }

        //State could be the State Pattern
        private char _state { get; set; }

        //Shooting could be the Strategy Pattern
        private bool _shooting { get; set; }

        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        } 
        public char State
        {
            get { return _state; }
            set { _state = value; }
        }
        public bool Shoot
        {
            get { return _shooting; }
            set { _shooting = value; }
        }

        public Memento.Memento SaveChar()
        {
            Console.WriteLine("Saving Character...");
            return new Memento.Memento(_hp, _state, _shooting);
        }

        public void LoadChar(Memento.Memento memento)
        {
            Console.WriteLine("Loading Character...");
            _hp = memento.HP;
            _state = memento.State;
            _shooting = memento.Shoot;
        }
    }
}
