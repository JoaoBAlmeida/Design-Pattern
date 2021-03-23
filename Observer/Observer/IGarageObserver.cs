using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observer
{
    public interface IGarageObserver
    {
        public abstract void UpdateCars(int quant_cars);
        public abstract void UpdateBikes(int quant_bikes);
        public abstract void UpdatePCDs(int quant_pcd);
    }
}
