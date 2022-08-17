using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson3
{
    public class Animal
    {
        uint price = 0;
        int number = 0;
        public enum Kind
        {
            Lion,
            Tiger,
            Elephant,
            Monkey,
            Jaguar
        }

        public uint Price
        {
            get;
            private set;
        }
        public Kind KindAnimal
        {
            get;
            set;
        }
        public int Number
        {
            get;
            private set;
        }

        public Animal(uint price, int number, Kind kindAnimal)
        {
            Price = price;
            Number = number;
            KindAnimal = kindAnimal;
        }
        public Animal(uint price)
        {
            Price = price;
        }
        public Animal(int number)
        {
            Number = number;
        }
        public Animal(Kind kindAnimal)
        {
            KindAnimal = kindAnimal;
        }

        public void SetPrice(uint price)
        {
            Price = price;
        }
        public void SetNumber(int number)
        {
            Number = number;
        }
        public void SetViewAnimal(Kind kindAnimal)
        {
            KindAnimal = kindAnimal;
        }
    }
}
