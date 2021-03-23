using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.HumanFactory
{
    public class HumanSoldier : Soldiers
    {
        public override string Action()
        {
            return "Soldier ready! Going into Battle";
        }
    }
}
