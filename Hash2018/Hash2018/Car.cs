using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash2018
{
    class Car
    {
        private int pos;
        private List<Ride> rides;

        public Car(int pos, List<Ride> rides)
        {
            this.pos = pos;
            this.rides = rides;
        }

        public int Pos => pos;
        public List<Ride> Rides => rides;
    }

    
}
