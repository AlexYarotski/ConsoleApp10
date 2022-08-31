namespace ConsoleApp10.Lesson4
{
     internal class EquilateralTrapezoid
    {
        public Point[] Points { get; private set; }

        public EquilateralTrapezoid(Point[] points)
        {
            if (points.Length == 4)
            {
                Points[0] = points[0];
                Points[1] = points[1];
                Points[2] = points[2];
                Points[3] = points[3];
            }
            else
                Console.WriteLine("Объект трапеция должен содержать 4 точки");
            
        }

        public EquilateralTrapezoid()
        {

        }

        public bool IsEquilateralTrapezoid(EquilateralTrapezoid equilateraltrapezoid)
        {
            var first = Point.Distance(equilateraltrapezoid.Points[0], equilateraltrapezoid.Points[2]);
            var second = Point.Distance(equilateraltrapezoid.Points[1], equilateraltrapezoid.Points[3]);

            return first == second;
        }

        public double GetPerimeter(Point[] points)
        {
            var perimeter = 0.0;

            for (int i = 1; i < points.Length; i++)
            {
                perimeter += Point.Distance(points[i - 1], points[i]);
            }
            perimeter += Point.Distance(points[points.Length - 1], points[0]);

            return perimeter;
        }

        public static double SquareTrapezium(EquilateralTrapezoid trapezoid)
        {
            var length2 = Point.Distance(trapezoid.Points[1], trapezoid.Points[2]);
            var length4 = Point.Distance(trapezoid.Points[3], trapezoid.Points[0]);

            var height = trapezoid.Points[1].Y - trapezoid.Points[0].Y;
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
