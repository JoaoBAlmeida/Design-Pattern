using MementoPattern.GameCommands;
using System;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            Commands game = new Commands();
            game.StartGame();
            Console.WriteLine("============Welcome=============");
            do
            {
                game.PrintStatus();
                int choice = 0;
                do
                {
                    choice = GameChoice();
                } while (choice == 0);
                switch (choice)
                {
                    case 1:
                        game.TakeLife();
                        break;
                    case 2:
                        game.GainLife();
                        break;
                    case 3:
                        game.GetBig();
                        break;
                    case 4:
                        game.GetSmall();
                        break;
                    case 5:
                        game.QuickSave();
                        break;
                    case 6:
                        game.QuickLoad();
                        break;
                    case 7:
                        play = false;
                        break;
                    default:
                        Console.WriteLine("Option not implemented");
                        break;
                }
            } while (play);
        }
        public static int GameChoice()
        {
            int opt;
            Console.WriteLine("Choose your action");
            Console.WriteLine("1 - Take Damage");
            Console.WriteLine("2 - Gain Life");
            Console.WriteLine("3 - Get Big");
            Console.WriteLine("4 - Get Small");
            Console.WriteLine("5 - QuickSave");
            Console.WriteLine("6 - QuickLoad");
            Console.WriteLine("7 - Exit");
            try
            {
                opt = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                opt = 0;
            }
            return opt;
        }
    }
}
