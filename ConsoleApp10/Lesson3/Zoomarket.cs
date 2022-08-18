using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp10.Lesson3.Animal;

namespace ConsoleApp10.Lesson3
{
    internal class ZooMarket
    {
        public string Name 
        {
            get;
            private set;
        }  
        public Animal[] Animals 
        { 
            get;
            set; 
        }

        public ZooMarket(string name, Animal[] animals)
        {
            Name = name;
            Animals = animals;
        }

        public ZooMarket(Animal[] animals)
        {
            Animals = animals;
        }

        public void DeleteAnimal(Kind kindAnimal)
        {
            int j = 0;
            int newArrayLength = 0;
            for (int i = 0; i < Animals.Length; i++)
            {
                if (Animals[i].KindAnimal != kindAnimal)
                {
                    newArrayLength++;
                }
            }

            Animal[] newArray = new Animal[newArrayLength];
            for (int i = 0; i < Animals.Length; i++)
            {
                if (Animals[i].KindAnimal != kindAnimal)
                {
                    newArray[j] = Animals[i];
                    j++;
                }
            }

            Animals = newArray;

            Console.WriteLine($"Удалили животное {kindAnimal}");
        }

        public void AddAnimal(Animal[] animals)
        {
            var addArrayAnimal = new Animal[Animals.Length + animals.Length];
            int j = 0;
            for (int i = 0; i < Animals.Length; i++)
            {
                addArrayAnimal[i] = Animals[i];
                j++;
            }

            for (int i = 0, k = j; i < animals.Length; i++, k++)
            {
                addArrayAnimal[k] = animals[i];
            }

            Animals = addArrayAnimal;
        }

        public Animal RichAnimal()
        {
            int j = 0;
            var expensiveAnimal = Animals[0].Price;
            for (int i = 1; i < Animals.Length; i++)
            {
                if (expensiveAnimal < Animals[i].Price)
                {
                    expensiveAnimal = Animals[i].Price;
                    j = i;
                }
            }

            return Animals[j];
        }
        public void SetName(string name) 
        { 
            Name = name;
        }
    }
}
