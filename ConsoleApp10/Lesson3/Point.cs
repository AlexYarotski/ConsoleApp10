using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson3
{
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        internal static int counter = 0;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
            counter++;
        }



    }
}
