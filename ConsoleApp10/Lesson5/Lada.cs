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

        public Lada()
        {

        }

        public override void Setup()
        {
            base.Setup();
            Colors color = new Colors();
            Colors colorLada = Input.InputColor(color);

            Console.WriteLine("");
            Console.Write($"You added: {GetType().Name} \r\nName: {Name} \r\nHorse Power: {Engene.HorsePower} \r\nAcceleration Time{Engene.AccelerationTime} \r\nColors: {colorLada} \r\n");
            Console.WriteLine("");
        }
    }
}
