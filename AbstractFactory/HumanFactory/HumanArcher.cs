using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.HumanFactory
{
    public class HumanArcher : Archers
    {
        public override string Action()
        {
            return "Archer ready! Arrows Nocked!";
        }
    }
}
