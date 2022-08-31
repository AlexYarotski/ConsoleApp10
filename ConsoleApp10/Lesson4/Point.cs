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


        public static double Distance(Point point1, Point point2)
        {
            var lengthInSquare = (point2.X - point1.X) * (point2.X - point1.X) + (point2.Y - point1.Y) * (point2.Y - point1.Y);

            return Math.Sqrt(lengthInSquare);
        }
    }
}
