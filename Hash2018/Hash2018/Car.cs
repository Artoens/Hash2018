using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash2018
{
    class Car
    {
        private int posX;
        private int posY;
        private List<Ride> rides;

        public Car(int posX, int posY, List<Ride> rides)
        {
            this.posX = posX;
            this.posY = posY;
            this.rides = rides;
        }

        public int PosX => posX;
        public int PosY => posY;
        public List<Ride> Rides => rides;

        public override string ToString()
        {
            string output = rides.Count.ToString();
            foreach(Ride r in rides)
            {
                output += " " + r.ID.ToString();
            }
            return base.ToString();
        }
    }
}
