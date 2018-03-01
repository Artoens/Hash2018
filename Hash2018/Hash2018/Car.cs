using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash2018
{
    class Car
    {
        private int pos = 0;
        private List<Ride> rides;

        public Car(int posY, List<Ride> rides)
        {
            this.rides = rides;
        }


        public int Pos => pos;
        public List<Ride> Rides => rides;

        public void AddRide(Ride r)
        {
            if (rides.Count() != 0)
            {
                pos += r.Delay;
            }
            else
            {
                pos += Math.Abs(r.Delay - r.Start.X - r.Start.Y);
            }
            pos += r.Poid();
            rides.Add(r);
        }

    }
}
