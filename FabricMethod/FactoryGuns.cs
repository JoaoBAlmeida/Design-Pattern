using System;
using System.Collections.Generic;
using System.Text;

namespace FabricMethod
{
    public class FactoryGuns : FactoryAB
    {
        public override IShip_Attack GenerateGuns(int opt)
        {
            switch (opt)
            {
                case 1:
                    return new Bullets();
                case 2:
                    return new Cannons();
                case 3:
                    return new Lasers();
                default:
                    return new Bullets();
            }
        }
    }
}
