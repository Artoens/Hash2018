using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash2018
{
    class Ride
    {
        private Point start;
        private Point finish;
        private int delay;
        private int timing;

        public Ride(Point start, Point finish, int delay, int timing)
        {
            this.start = start;
            this.finish = finish;
            this.delay = delay;
            this.timing = timing;
        }

        public Point Start => start;
        public Point Finish => finish;
        public int Delay => delay;
        public int Timing => timing;

        public int Poid()
        {
            return Math.Abs(start.X - finish.X) + Math.Abs(start.X - finish.Y);
        }

    }
}
