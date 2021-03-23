using AbstractFactory.HumanFactory;
using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
    public abstract class FactoryCreature
    {
        public abstract Soldiers SummonSoldier();
        public abstract Archers SummonArcher();
    }
}
