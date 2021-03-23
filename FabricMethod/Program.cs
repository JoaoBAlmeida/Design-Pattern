using System;
using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;

namespace FabricMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryAB fab = new FactoryGuns();
            bool continues = true;
            while (continues)
            {
                Console.WriteLine("Choose your attack method:");
                Console.WriteLine("1 - Guns");
                Console.WriteLine("2 - Cannons");
                Console.WriteLine("3 - Lasers");
                Console.WriteLine("Any Other Key Pressed - Exit");
                var Opt = Convert.ToInt32(Console.ReadLine());
                IShip_Attack ship;
                switch (Opt){
                    case 1:
                        ship = fab.GenerateGuns(1);
                        break;
                    case 2:
                        ship = fab.GenerateGuns(2);
                        break;
                    case 3:
                        ship = fab.GenerateGuns(3);
                        break;
                    default:
                        continues = false;
                        continue;
                }
                Console.WriteLine("============================");
                Console.WriteLine(ship.Guns());
                Console.WriteLine("============================");
            }
        }
    }
}
