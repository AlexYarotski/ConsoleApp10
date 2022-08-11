using ConsoleApp10;
using ConsoleApp10.Lesson3;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var point1 = new Point(2, 1);
            var point2 = new Point(2, 3);
            var point3 = new Point(2, 4);
            var t = Point.counter;

            var circle1 = new Circle();
            circle1.Rad = 4;
            var circle2 = new Circle(4);
        }
    }
}
