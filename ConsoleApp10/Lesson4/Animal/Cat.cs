namespace ConsoleApp10.Lesson4.Animal
{
    internal class Cat : Animal
    {
        private string _claws = "острые";

        public Cat(string food, string location, string claws) : base(food, location)
        {
            _claws = claws;
        }

        public override void MakeNoise()
        {
            base.MakeNoise();
            Console.WriteLine($"У меня {_claws} когти");
            Console.WriteLine("Я тихий иногда");
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine($"Ем {Food}");
        }

        public override void Sleep()
        {
            base.Eat();
            Console.WriteLine($"Сплю {Location}");
        }
    }
}
