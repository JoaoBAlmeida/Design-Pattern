using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern.Memento
{
    public class MementoCaretaker
    {
        //In order to store the history, should be a list of mementos
        private Memento _memento;
        public Memento Memento
        {
            get { return _memento; }
            set { _memento = value; }
        }
    }
}
