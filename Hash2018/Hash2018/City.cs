using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash2018
{
    class City
    {
        private int r;
        private int c;

        public City (int r, int c)
        {
            this.r = r;
            this.c = c;
        }

        public int R => r;
        public int C => c;
    }
}
