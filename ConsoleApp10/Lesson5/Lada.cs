namespace ConsoleApp10.Lesson5
{
    internal class Lada : Car
    {
        public Enum Color
        {
            get;
            private set; 
        }   

        public Lada(string name, Engene engeneCar, Enum color) : base(name, engeneCar)
        {
            Color = color;
        }
    }
}
