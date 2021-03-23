using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Memento
{
    public class Memento
    {
        private int _hp { get; set; }

        //State could be the State Pattern
        private char _state { get; set; }

        //Shooting could be the Strategy Pattern
        private bool _shooting { get; set; }

        public Memento(int hp, char state, bool shooting)
        {
            this._hp = hp;
            this._state = state;
            this._shooting = shooting;
        }

        public int HP
        {
            get { return _hp; }
        }
        public char State
        {
            get { return _state; }
        }
        public bool Shoot
        {
            get { return _shooting; }
        }
    }
}
