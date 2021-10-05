using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public string GetXY()
        {
            return X + ";" + Y;
        }
    }
}
