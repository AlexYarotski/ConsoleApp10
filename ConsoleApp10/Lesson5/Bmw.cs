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
            Console.WriteLine("Choose a color:");
            Colors colorBmw = Input.InputColor(color);

            Bmw newBmw = new Bmw(Name, new Engene(Engene.HorsePower, Engene.AccelerationTime), colorBmw);

            Console.Write($"You added: {newBmw.GetType().Name} \r\n Name: {Name} \r\n Horse Power: {Engene.HorsePower} \r\n Acceleration Time{Engene.AccelerationTime} \r\n Colors: {colorBmw}");
            Console.WriteLine();
        }
    }
}
