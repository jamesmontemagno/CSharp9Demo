using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Point
    {
        public int X { get; init; }
        public int Y { get; init; }

        public Point()
        {

        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        void M()
        {
            var point = new Point
            {
                X = 42,
                Y = 21
            };

        }
    }
}
