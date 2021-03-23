using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Models;

namespace AbstractFactory.HumanFactory
{
    public class GenerateHumanArmy : FactoryCreature
    {
        public override Archers SummonArcher()
        {
            return new HumanArcher();
        }

        public override Soldiers SummonSoldier()
        {
            return new HumanSoldier();
        }
    }
}
