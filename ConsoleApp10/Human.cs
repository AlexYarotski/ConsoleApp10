using ConsoleApp10.Lesson3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Human
    {
        private Shoes _shoes = null;
        private Clothes _clothes = null;

        public Human()
        {

        }
        public Human (Shoes shoes, Clothes clothes)
        {
            _shoes = shoes;
            _clothes = clothes;
        }

        public void PrintOutfit()
        {
            _shoes.Print();
            _clothes.Print();
        }
    }
}
