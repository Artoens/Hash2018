using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash2018
{
    class Ride
    {
        private int start;
        private int finish;
        private int delay;
        private int timing;

        public Ride (int start, int finish, int delay, int timing)
        {
            this.start = start;
            this.finish = finish;
            this.delay = delay;
            this.timing = timing;
        }

        public int Start => start;
        public int Finish => finish;
        public int Delay => delay;
        public int Timing => timing;
    }
}
