namespace ConsoleApp10.Lesson5
{
    internal class Bmw : Car
    {
        public bool Сonditioner 
        {
            get;
            set;
        }

        public Bmw(string name, Engene engeneCar, Colors colors, bool сonditioner) : base(name, engeneCar, colors)
        {
            Сonditioner = сonditioner;
        }

        public Bmw()
        {

        } 

        public override void Setup()
        {
            base.Setup();
            bool conditioner = Input.InputBoolCheck("Conditioner: ");

            Console.WriteLine("");
            Console.Write($"You added: {GetType().Name} \r\nName: {Name} \r\nHorse Power: {Engene.HorsePower}" +
                $" \r\nAcceleration Time{Engene.AccelerationTime} " +
                $"\r\nColors: {Colors} \r\nСonditioner: {conditioner}\r\n");
            Console.WriteLine("");
        }
    }
}
