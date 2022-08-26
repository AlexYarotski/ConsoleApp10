using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson4
{
     internal class EquilateralTrapezoid : Point
    {
        public Point Point1 { get; private set; }
        public Point Point2 { get; private set; }
        public Point Point3 { get; private set; }
        public Point Point4 { get; private set; }

        public EquilateralTrapezoid(Point point1, Point point2, Point point3, Point point4)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
            Point4 = point4;
        }

        public static double GetAverageSquare(EquilateralTrapezoid[] trapezies)
        {
            double sum = 0;

            for (int i = 0; i < trapezies.Length; i++)
            {
                sum += SquareTrapezium(trapezies[i]);
            }

            return sum / trapezies.Length;
        }

        public static int GetTrapezoidsNumberWithSquareMoreThanAverage(EquilateralTrapezoid[] trapezies)
        {
            var averageSquare = GetAverageSquare(trapezies);
            int trapeziesCount = 0;

            for (int i = 0; i < trapezies.Length; i++)
            {
                if (SquareTrapezium(trapezies[i]) > averageSquare)
                {
                    trapeziesCount++;
                }
            }

            return trapeziesCount;
        }

    }
}
