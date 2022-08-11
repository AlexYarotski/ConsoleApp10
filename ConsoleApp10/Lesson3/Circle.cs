using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson3
{
    internal class Circle
    {
        public int Rad { get; set; }
        public Circle(int rad)
        {
            Rad = rad;
        }

        public Circle() { }
       
        private double squ;
        public double Squ
        {
            get { return squ = Math.PI * Math.Pow(Rad, 2); }
        }

        private double len;
        public double Len
        {
            get { return len = 2 * Math.PI * Rad; }
        }
    }
}
