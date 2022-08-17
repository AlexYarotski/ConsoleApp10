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

        public void DeleteAnimal(Animal[] animals, Kind kindAnimal)
        {
            int[] deleteAnimal = new int[Animals.Length - 2];
            for (int i = 0; i < Animals.Length; i++)
            {
                
            }
        }
        public void SetName(string name) 
        { 
            Name = name;
        }
    }
}
