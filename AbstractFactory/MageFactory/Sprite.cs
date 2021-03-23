using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.MageFactory
{
    public class Sprite : Archers
    {
        public override string Action()
        {
            return "Sprite summoned! Ready to shoot magic spheres!";
        }
    }
}
