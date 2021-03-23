using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.NecroFactory
{
    public class Skeleton : Archers
    {
        public override string Action()
        {
            return "Skeleton assembled. Ready to shoot it's arrows!";
        }
    }
}
