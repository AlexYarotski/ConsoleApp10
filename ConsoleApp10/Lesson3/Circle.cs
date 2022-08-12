using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson3
{
    internal class Circle
    {
        public uint Radius
        {
            get;
            internal set;
        }
        public Circle(uint radius)
        {
            Radius = radius;

        }

        public Circle() { }
        public double Square
        {
            get  => Math.PI * Math.Pow(Radius, 2);
            
        }

        public double Length
        {
            get  => 2 * Math.PI * Radius; 
        }

        public void Print()
        {
            Console.WriteLine("Задача 2");
            Console.WriteLine($"Радиус круга {Radius}");
            Console.WriteLine($"Площадь круга {Square}");
            Console.WriteLine($"Длина круга {Length}");
            Console.WriteLine();
        }
    }
}
