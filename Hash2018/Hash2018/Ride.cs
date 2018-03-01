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
        private int id;

        public Ride (Point start, Point finish, int delay, int timing, int id)
        {
            this.start = start;
            this.finish = finish;
            this.delay = delay;
            this.timing = timing;
            this.id = id;
        }

        public Point Start => start;
        public Point Finish => finish;
        public int Delay => delay;
        public int Timing => timing;
        public int ID => id;
    }
}
