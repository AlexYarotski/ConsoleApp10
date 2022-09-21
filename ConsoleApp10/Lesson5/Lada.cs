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
            Console.WriteLine("Choose a color:");
            Colors colorLada = Input.InputColor(color);

            Lada newLada = new Lada(Name, new Engene(Engene.HorsePower, Engene.AccelerationTime), colorLada);

            Console.Write($"You added: {newLada.GetType().Name} \r\n Name: {Name} \r\n Horse Power: {Engene.HorsePower} \r\n Acceleration Time{Engene.AccelerationTime} \r\n Colors: {colorLada}");
            Console.WriteLine();
        }
    }
}
