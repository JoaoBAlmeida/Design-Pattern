using MementoPattern.Memento;
using MementoPattern.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MementoPattern.GameCommands
{
    //Itself could be but a strategy inside the observer of the game!
    //Game winning changed to easy commands
    //Game Losing changed to harder commands
    //======
    //Commands would then change to IStrategy, and there would be easy mode and hard
    //(Those are just examples, could be more complex still)
    public class Commands
    {
        private Character character { get; set; }
        private MementoCaretaker caretaker { get; set; }

        //Change this function to best fit the start of your game
        public void StartGame()
        {
            character = new Character();
            caretaker = new MementoCaretaker();

            //Hard Coded starting values
            character.HP = 3;
            character.State = 'P';
            character.Shoot = false;
        }

        //Save function to test saving the memento
        public void QuickSave()
        {
            caretaker.Memento = character.SaveChar();
        }

        //Load function to test loading the memento
        public void QuickLoad()
        {
            if(caretaker.Memento == null)
            {
                Console.WriteLine("No save file found!");
                return;
            }
            else character.LoadChar(caretaker.Memento);
        }

        //===========================
        //Functions to simulate the game!

        public void PrintStatus()
        {
            Console.WriteLine("===========Player Status===============");
            Console.WriteLine("HP: " + character.HP);
            Console.WriteLine("State: " + character.State);
            Console.WriteLine("Shooter: " + character.Shoot);
        }
        public void TakeLife()
        {
            if(character.HP <= 0)
            {
                Console.WriteLine("Already dead!!");
                return;
            }
            else character.HP--;
        }

        public void GainLife()
        {
            if (character.HP >= 3)
            {
                Console.WriteLine("Life at max!");
                return;
            }
            else character.HP++;
        }

        public void GetBig()
        {
            if(character.State == 'B')
            {
                Console.WriteLine("Character already big");
                return;
            }
            else
            {
                character.State = 'B';
                character.Shoot = true;
            }
        }

        public void GetSmall()
        {
            if (character.State == 'S')
            {
                Console.WriteLine("Character already small");
                return;
            }
            else
            {
                character.State = 'S';
                character.Shoot = false;
            }
        }
    }
}
