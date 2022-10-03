namespace ConsoleApp10.Lesson5
{
    internal class Bmw : Car
    {
        public bool Сonditioner 
        {
            get;
            private set;
        }

        public Bmw(string name, Engine carEngine, Colors color, bool сonditioner) : base(name, carEngine, color)
        {
            Сonditioner = сonditioner;
        }

        public Bmw()
        {
        }

        public override void GetIndividualInfo()
        {
            Console.WriteLine($"Сonditioner {Сonditioner}");
        }

        public override void Setup()
        {
            base.Setup();
            
            bool conditioner = Input.InputBoolCheck("Conditioner: ");

            Console.WriteLine("");
            Console.Write($"You added: {GetType().Name} \r\nName: {Name} \r\nHorse Power: {CarEngine.HorsePower}" +
                $" \r\nAcceleration Time{CarEngine.AccelerationTime} " +
                $"\r\nColors: {Color} \r\nСonditioner: {conditioner}\r\n");
            Console.WriteLine("");
        }
    }
}
