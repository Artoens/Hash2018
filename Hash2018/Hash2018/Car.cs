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
        private List<Ride> rides = new List<Ride>();

        public Car()
        {
        }


        public int Pos => pos;
        public List<Ride> Rides => rides;

        public override string ToString()
        {
            string output = rides.Count.ToString();
            foreach(Ride r in rides)
            {
                output += " " + r.ID.ToString();
            }
            return output;
        }

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
