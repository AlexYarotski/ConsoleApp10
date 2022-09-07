namespace ConsoleApp10.Lesson4.Animal
{
    internal class Veterinarian
    {
        public Animal[] Animals { get; set; }

        public void TreatAnimal(Animal animals)
        {
            Console.WriteLine($"{animals.GetType().Name}:  {animals.Food} {animals.Location}");
        }
    }
}
