using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.NecroFactory
{
    public class Zombie : Soldiers
    {
        public override string Action()
        {
            return "Zombie revived. Ready to go into battle!";
        }
    }
}
