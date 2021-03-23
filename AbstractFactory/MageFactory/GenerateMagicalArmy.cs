using AbstractFactory.Factories;
using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.MageFactory
{
    public class GenerateMagicalArmy : FactoryCreature
    {
        public override Archers SummonArcher()
        {
            return new Sprite();
        }

        public override Soldiers SummonSoldier()
        {
            return new Atronach();
        }
    }
}
