using AbstractFactory.Factories;
using AbstractFactory.HumanFactory;
using AbstractFactory.MageFactory;
using AbstractFactory.Models;
using AbstractFactory.NecroFactory;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a magic land!");
            Console.WriteLine("=======================");
            bool newGame = true;
            bool newSummon = false;
            FactoryCreature creature;
            while (newGame)
            {
                Console.WriteLine("Choose your Class:\n1 - Human\n2 - Mage\n3 - Necromancer\n4 - Exit");
                int opt = Convert.ToInt32(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        creature = new GenerateHumanArmy();
                        newSummon = true;
                        break;
                    case 2:
                        creature = new GenerateMagicalArmy();
                        newSummon = true;
                        break;
                    case 3:
                        creature = new GenerateUndeadArmy();
                        newSummon = true;
                        break;
                    default:
                        newGame = false;
                        continue;
                }
                while (newSummon)
                {
                    Console.WriteLine("Choose your summon:\n1 - Melee Soldier\n2 - Ranged Soldier\n3 - Exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    Soldiers soldiers;
                    Archers archers;
                    switch (choice)
                    {
                        case 1:
                            soldiers = creature.SummonSoldier();
                            Console.WriteLine("=====================\n" + soldiers.Action() + "\n=====================");
                            break;
                        case 2:
                            archers = creature.SummonArcher();
                            Console.WriteLine("=====================\n" + archers.Action() + "\n=====================");
                            break;
                        default:
                            newSummon = false;
                            continue;
                    }
                }
            }
        }
    }
}
