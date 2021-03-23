using Observer.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Floors
{
    public class Camera : IGarageObserver
    {
        public void UpdateBikes(int quant_bikes)
        {
            Console.WriteLine("Current bikes spaces left in Garage: " + quant_bikes);
        }

        public void UpdateCars(int quant_cars)
        {
            Console.WriteLine("Current cars spaces left in Garage: " + quant_cars);
        }

        public void UpdatePCDs(int quant_pcd)
        {
            Console.WriteLine("Current PCDs spaces left in Garage: " + quant_pcd);
        }
    }
}
