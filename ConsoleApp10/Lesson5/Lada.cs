namespace ConsoleApp10.Lesson5
{
    internal class Lada : Car
    {
        public bool Abs
        {
            get;
            private set;
        }

        public Lada(string name, Engine carEngineCar, Colors color, bool abs) : base(name, carEngineCar, color)
        {
            Abs = abs;
        }

        public Lada()
        {

        }
        
        public override void GetIndividualInfo()
        {
            Console.WriteLine($"Abs {Abs}");
        }

        public override void Setup()
        {
            base.Setup();
            
            bool abs = Input.InputBoolCheck("Abs: ");
            
            Console.Write($"\nYou added: {GetType().Name} \r\nName: {Name} \r\nHorse Power: {CarEngine.HorsePower}" +
                $" \r\nAcceleration Time{CarEngine.AccelerationTime}" +
                $" \r\nColors: {Color} \r\nAbs: {abs}\r\n");
        }
    }
}
