using Observer.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Floors
{
    public class UpperFloor : GarageAB
    {
        public UpperFloor()
        {
            bikes = 3;
            cars = 25;
            pcds = 1;
        }
        public void EnterCar()
        {
            if (cars == 0)
            {
                Console.WriteLine("No more cars allowed");
                return;
            }
            cars -= 1;
            NotifyCarChange();
        }
        public void EnterBike()
        {
            if (bikes == 0)
            {
                Console.WriteLine("No more bikes allowed");
                return;
            }
            bikes -= 1;
            NotifyBikesChange();
        }
        public void EnterPCD()
        {
            if (pcds == 0)
            {
                Console.WriteLine("No more PCDs allowed");
                return;
            }
            pcds -= 1;
            NotifyPCDChange();
        }
        public void ExitCar()
        {
            if (cars == 25)
            {
                Console.WriteLine("No more cars inside");
                return;
            }
            cars += 1;
            NotifyCarChange();
        }
        public void ExitBike()
        {
            if (bikes == 3)
            {
                Console.WriteLine("No more bikes inside");
                return;
            }
            bikes += 1;
            NotifyBikesChange();
        }
        public void ExitPCD()
        {
            if (pcds == 1)
            {
                Console.WriteLine("No more PCDs inside");
                return;
            }
            pcds += 1;
            NotifyPCDChange();
        }
    }
}
