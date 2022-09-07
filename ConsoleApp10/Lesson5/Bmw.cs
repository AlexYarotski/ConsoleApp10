namespace ConsoleApp10.Lesson5
{
    internal class Bmw : Car
    {
        public Engene EngeneCar;

        public string Color 
        {
            get; 
            private set;
        }

        public Bmw(string name, Engene engeneCar, string color) : base(name, engeneCar)
        {
            EngeneCar = engeneCar;
            Color = color;
        }
    }
}
