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

        public Bmw()
        {

        } 

        public override void Setup()
        {
            base.Setup();
            Colors color = new Colors();
            Colors colorBmw = Input.InputColor(color);

            Console.WriteLine("");
            Console.Write($"You added: {GetType().Name} \r\nName: {Name} \r\nHorse Power: {Engene.HorsePower} \r\nAcceleration Time{Engene.AccelerationTime} \r\nColors: {colorBmw} \r\n");
            Console.WriteLine("");
        }
    }
}
