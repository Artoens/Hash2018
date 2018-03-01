using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash2018
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] input = ReadFile("C:/Users/guill/Desktop/Hash2018/a_example.in");
            int[] inputCity = input[0];
            input = input.Skip(1).ToArray();
            List<Ride> rides = new List<Ride> { };
            List<Car> cars = new List<Car> { };

            City city = new City(inputCity[0], inputCity[1]);
            int i = 0;
            foreach (int[] ride in input)
            {
                Ride r = new Ride(new Point(ride[0], ride[1]), new Point(ride[2], ride[3]), ride[4], ride[5], i);
                rides.Add(r);
                i++;
            }

            for (int j = 0; j < inputCity[2]; j++)
            {
                cars.Add(new Car());
            }

            rides.Sort(delegate (Ride x, Ride y) { return x.Delay - y.Delay; });

            foreach (Car car in cars)
            {
                car.AddRide(Nearest(car.Rides.Last(), rides));
            }
        }

        public static Ride Nearest(Ride ride1, List<Ride> rideList)
        {
            int minS = int.MaxValue;
            int minT = int.MaxValue;
            int distanceS = 0;
            Ride finalRide = new Ride(new Point(0,0),new Point(0,0),0,0,0);

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
        private static int[][] ReadFile(string path)
        {

            //list of lines, blank lines are removed 
            string[] lines = File.ReadAllLines(path).Where(arg =>
                                !string.IsNullOrWhiteSpace(arg)).ToArray();

            // Split every lines and Trim  
            return lines.Select(x => x.Split(' ').Select(y => Convert.ToInt32(y.Trim())).ToArray()).ToArray();
        }   
    }
}
