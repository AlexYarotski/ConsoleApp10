using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson3
{
    internal class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        internal static int counter = 0;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
            counter++;
        }
        public void Print()
        {
            Console.WriteLine("Задача 1");
            Console.WriteLine($"Ось X {X}");
            Console.WriteLine($"Ось Y {Y}");
            Console.WriteLine($"Колличество экземляров {counter}");
            Console.WriteLine();
        }
    }
}
