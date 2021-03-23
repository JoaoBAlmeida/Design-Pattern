using AbstractFactory.Factories;
using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.NecroFactory
{
    public class GenerateUndeadArmy : FactoryCreature
    {
        public override Archers SummonArcher()
        {
            return new Skeleton();
        }

        public override Soldiers SummonSoldier()
        {
            return new Zombie();
        }
    }
}
