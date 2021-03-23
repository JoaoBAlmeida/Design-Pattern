using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;
using System.Windows.Markup;

namespace Observer.Observer
{
    public abstract class GarageAB
    {
        protected List<IGarageObserver> cameras = new List<IGarageObserver>();
        protected int cars { get; set; }
        protected int bikes { get; set; }
        protected int pcds { get; set; }

        public void Attach(IGarageObserver observer)
        {
            cameras.Add(observer);
        }
        public void Detach(IGarageObserver observer)
        {
            cameras.Remove(observer);
        }

        public void NotifyCarChange()
        {
            foreach (IGarageObserver o in cameras)
            {
                o.UpdateCars(this.cars);
            }
        }
        public void NotifyBikesChange()
        {
            foreach (IGarageObserver o in cameras)
            {
                o.UpdateBikes(this.bikes);
            }
        }
        public void NotifyPCDChange()
        {
            foreach (IGarageObserver o in cameras)
            {
                o.UpdatePCDs(this.pcds);
            }
        }
    }
}
