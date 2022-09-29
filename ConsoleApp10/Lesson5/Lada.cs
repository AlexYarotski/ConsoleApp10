namespace ConsoleApp10.Lesson5
{
    internal class Lada : Car
    {
        public bool Abs
        {
            get;
            private set;
        }

        public Lada(string name, Engene engeneCar, Colors colors, bool abs) : base(name, engeneCar, colors)
        {
            Abs = abs;
        }

        public Lada()
        {

        }

        public override void Setup()
        {
            base.Setup();
            bool abs = Input.InputBoolCheck("Abs: ");

            Console.WriteLine("");
            Console.Write($"You added: {GetType().Name} \r\nName: {Name} \r\nHorse Power: {Engene.HorsePower}" +
                $" \r\nAcceleration Time{Engene.AccelerationTime}" +
                $" \r\nColors: {Colors} \r\nAbs: {abs}\r\n");
            Console.WriteLine("");
        }
    }
}
