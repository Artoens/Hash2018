using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash2018
{
    class Point
    {
        private int x;
        private int y;

        public Point (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X => x;
        public int Y => y;

        public int Distance(Point q)
        {
            return Math.Abs(x - q.X) + Math.Abs(y - q.Y);
        }
    }

}
