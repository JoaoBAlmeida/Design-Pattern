using Observer.Floors;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            LowerFloor lf = new LowerFloor();
            UpperFloor uf = new UpperFloor();
            Camera camera = new Camera();
            lf.Attach(camera);
            uf.Attach(camera);
            bool floors = true;
            bool vehicles = true;
            while (floors)
            {
                Console.WriteLine("Choose the current floor:");
                Console.WriteLine("1 - Upper\n2 - Lower\n3 - Exit");
                int floor = Convert.ToInt32(Console.ReadLine());
                switch (floor)
                {
                    case 1:
                        vehicles = true;
                        while (vehicles)
                        {
                            Console.WriteLine("Choose the option:");
                            Console.WriteLine("1 - Add Car\n2 - Add Bike\n3 - Add PCD\n4 - Remove Car\n5 - Remove Bike\n6 - Remove PCD\n7 - Exit");
                            int opt = Convert.ToInt32(Console.ReadLine());
                            switch (opt)
                            {
                                case 1:
                                    uf.EnterCar();
                                    break;
                                case 2:
                                    uf.EnterBike();
                                    break;
                                case 3:
                                    uf.EnterPCD();
                                    break;
                                case 4:
                                    uf.ExitCar();
                                    break;
                                case 5:
                                    uf.ExitBike();
                                    break;
                                case 6:
                                    uf.ExitPCD();
                                    break;
                                case 7:
                                    vehicles = false;
                                    continue;
                            }
                        }
                        break;

                    case 2:
                        vehicles = true;
                        while (vehicles)
                        {
                            Console.WriteLine("Choose the option:");
                            Console.WriteLine("1 - Add Car\n2 - Add Bike\n3 - Add PCD\n4 - Remove Car\n5 - Remove Bike\n6 - Remove PCD\n7 - Exit");
                            int opt = Convert.ToInt32(Console.ReadLine());
                            switch (opt)
                            {
                                case 1:
                                    lf.EnterCar();
                                    break;
                                case 2:
                                    lf.EnterBike();
                                    break;
                                case 3:
                                    lf.EnterPCD();
                                    break;
                                case 4:
                                    lf.ExitCar();
                                    break;
                                case 5:
                                    lf.ExitBike();
                                    break;
                                case 6:
                                    lf.ExitPCD();
                                    break;
                                default:
                                    vehicles = false;
                                    continue;
                            }
                        }
                        break;

                    default:
                        floors = false;
                        continue;
                }
            }
        }
    }
}
