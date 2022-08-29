namespace ConsoleApp10.Lesson4
{
     internal class EquilateralTrapezoid
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

        public EquilateralTrapezoid()
        {

        }

        public static double Distance(Point point1, Point point2)
        {
            var lengthInSquare = (point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y);

            return Math.Sqrt(lengthInSquare);
        }

        public bool IsEquilateralTrapezoid(EquilateralTrapezoid trapezoid)
        {
            var first = Distance(trapezoid.Point1, trapezoid.Point3);
            var second = Distance(trapezoid.Point2, trapezoid.Point4);

            return first == second;
        }

        public double GetPerimeter(Point[] points)
        {
            var perimeter = 0.0;

            for (int i = 1; i < points.Length; i++)
            {
                perimeter += Distance(points[i - 1], points[i]);
            }
            perimeter += Distance(points[points.Length - 1], points[0]);

            return perimeter;
        }

        public static double SquareTrapezium(EquilateralTrapezoid trapezoid)
        {
            var length2 = Distance(trapezoid.Point2, trapezoid.Point3);
            var length4 = Distance(trapezoid.Point4, trapezoid.Point1);

            var height = trapezoid.Point2.Y - trapezoid.Point1.Y;
            var square = 0.5 * (length2 + length4) * height;

            return square;
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
