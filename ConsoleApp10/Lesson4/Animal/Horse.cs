namespace ConsoleApp10.Lesson4.Animal
{
    internal class Horse : Animal
    {
        private uint _horsepower = 3;

        public Horse(string food, string location, uint horsepower) : base(food, location)
        {
            _horsepower = horsepower;
        }

        public override void MakeNoise()
        {
            base.MakeNoise();
            Console.WriteLine($"У меня {_horsepower} лошадиныи силы");
            Console.WriteLine("Я не громкая");
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine($"Ем {Food}");
        }

        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine($"Сплю {Location}");
        }
    }
}
