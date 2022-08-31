using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson4.Animal
{
    internal class Veterinarian : Animal
    {
        public Animal[] Animals { get; private set; }

        public Veterinarian(Animal[] animals)
        {
            Animals = animals;
        }

        public void TreatAnimal(Animal animals)
        {
            Console.WriteLine($"{animals.GetType().Name}:  {animals.Food} {animals.Location}");
        }
    }
}
