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
            internal set; 
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
                else
                {
                    PrintAnimals(new Animal[] { Animals[i] }, "Удалили животное: ");
                }
            }

            Animals = newArray;
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

            for (int i = 0,k = animals.Length - 1; i < animals.Length; i++, k++)
            {
                addArrayAnimal[k] = animals[i];
            }

            Animals = addArrayAnimal;

            PrintAnimals(animals, "Добавили животное: ");
        }

        public Animal MostExpensiveAnimal()
        {
            int j = 0; 
            for (int i = 1; i < Animals.Length; i++)
            {
                if (Animals[j].Price < Animals[i].Price)
                {
                    j++;
                }
            }

            PrintAnimals(new Animal[] { Animals[j] }, "Самое дорогое животное: ");
            return Animals[j];
        }

        public Animal AnimalsByQuantity()
        {
            int j = 0;
            for (int i = 1; i < Animals.Length; i++)
            {
                if (Animals[j].Quantity  < Animals[i].Quantity)
                {
                    j++;
                }
            }

            PrintAnimals(new Animal[] { Animals[j]}, "Самое большое колличество животных: ");
            return Animals[j];
        }

        public Animal[] AnimalSearch(Kind kind)
        {
            int newArrayLength = 0;
            for (int i = 0; i < Animals.Length; i++)
            {
                if (Animals[i].KindAnimal == kind)
                {
                    newArrayLength++;
                }
            }

            Animal[] newArray = new Animal[newArrayLength];
            for (int i = 1; i < Animals.Length; i++)
            {
                if (Animals[0].KindAnimal == kind)
                {
                    newArray[j] = Animals[i];
                    PrintAnimals(new Animal[] { newArray[j] }, "Найдено животное: ");
                } 
            }

            return newArray;
        }

        public void SetName(string name) 
        { 
            Name = name;

            Console.WriteLine($"Новое назвние {Name}");
            Console.WriteLine();
        }
    }
}
