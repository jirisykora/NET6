using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Point
    {
        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public string GetXY()
        {
            return X + ";" + Y;
        }

        public int GetArea()
        {
            return X * Y;
        }
        public override string ToString()
        {
            return GetXY();
        }
    }
}
