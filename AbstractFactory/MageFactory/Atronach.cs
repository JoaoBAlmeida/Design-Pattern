using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.MageFactory
{
    public class Atronach : Soldiers
    {
        public override string Action()
        {
            return "Stone Golem summoned! Ready to pound";
        }
    }
}
