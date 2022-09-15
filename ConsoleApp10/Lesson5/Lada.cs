namespace ConsoleApp10.Lesson5
{
    internal class Lada : Car
    {
        public string Color
        {
            get;
            private set; 
        }   

        public Lada(string name, Engene engeneCar, string color) : base(name, engeneCar)
        {
            Color = color;
        }
    }
}
