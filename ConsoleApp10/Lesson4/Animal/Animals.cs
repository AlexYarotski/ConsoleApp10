using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson4.Animal
{
    internal abstract class Animal
    {
        public string Food 
        {
            get;
            private set;
        }

        public string Location 
        {
            get;
            private set;
        }

        public Animal(string food, string location)
        {
            Food = food;
            Location = location;
        }

        public Animal()
        {

        }

        public virtual void MakeNoise()
        {
            Console.WriteLine("Такое-то животное шумит");
        }

        public virtual void Eat()
        {
            Console.WriteLine("Такое-то животное ест");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("Такое-то животное спит");
        }
    }
}
