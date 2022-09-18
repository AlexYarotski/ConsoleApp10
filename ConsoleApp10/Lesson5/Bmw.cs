namespace ConsoleApp10.Lesson5
{
    internal class Bmw : Car
    {
        public Enum Color 
        {
            get; 
            private set;
        }

        public Bmw(string name, Engene engeneCar, Enum color) : base(name, engeneCar)
        {
            Color = color;
        }
    }
}
