using System;
using System.Collections.Generic;
using System.Text;

namespace FabricMethod
{
    public abstract class FactoryAB
    {
        public abstract IShip_Attack GenerateGuns(int opt);
    }
}
