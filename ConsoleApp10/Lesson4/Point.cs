namespace ConsoleApp10.Lesson4
{
    internal class Point
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point()
        {

        }

        public static double GetLengthByCoordinates(Point point1, Point point2)
        {
            var lengthInSquare = (point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y);

            return Math.Sqrt(lengthInSquare);
        }

        public bool IsEquilateralTrapezoid(Point[] points)
        {
            var first = GetLengthByCoordinates(points[0], points[2]);
            var second = GetLengthByCoordinates(points[1], points[3]);

            return first == second;
        }

        public double GetPerimeter(Point[] points)
        {
            var perimeter = 0.0;

            for (int i = 0; i < points.Length; i++)
            {
                if (i != points.Length - 1)
                {
                    perimeter += GetLengthByCoordinates(points[i], points[i + 1]);
                }
                else
                {
                    perimeter += GetLengthByCoordinates(points[i], points[0]);
                }
            }

            return perimeter;
        }

        public static double SquareTrapezium(Point[] points)
        {
            var length2 = GetLengthByCoordinates(points[1], points[2]);
            var length4 = GetLengthByCoordinates(points[3], points[0]);

            var height = points[1].Y - points[0].Y;
            var square = 0.5 * (length2 + length4) * height;

            return square;
        }

        public static double SquareTrapezium(EquilateralTrapezoid trapezoid)
        {
            return SquareTrapezium(new Point[] { trapezoid.Point1, trapezoid.Point2, trapezoid.Point3, trapezoid.Point4 });
        }
    }
}
