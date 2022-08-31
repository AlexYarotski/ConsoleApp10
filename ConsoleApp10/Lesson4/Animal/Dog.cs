using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson4.Animal
{
    internal class Dog : Animal
    {
        private uint _play = 4;

        public Dog(string food, string location, uint play) : base(food, location)
        {
            _play = play;
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"Я играю {_play} раза в день");
            Console.WriteLine("Я бываю громким");
        }

        public override void Eat()
        {
            Console.WriteLine($"Ем {Food}");
        }

        public override void Sleep()
        {
            Console.WriteLine($"Сплю {Location}");
        }
    }
}
