using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash2018
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(Car car in cars)
            {
                car.AddRide(Nearest(car.Rides.Last(), rides));
            }
        }

        public Ride Nearest(Ride ride1, List<Ride> rideList)
        {
            int minS = int.MaxValue;
            int minT = int.MaxValue;
            int distanceS = 0;
            Ride finalRide = new Ride(new Point(0,0),new Point(0,0),0,0);

            foreach (Ride ride2 in rideList)
            {
                distanceS = ride1.Finish.Distance(ride2.Start);
                if (distanceS < minS && ride2.Delay > ride1.Timing && ride2.Delay < minT)
                {
                    finalRide = ride2;
                    minS = distanceS;
                    minT = ride2.Delay;
                }
            }
            return finalRide;
        }
    }
}
