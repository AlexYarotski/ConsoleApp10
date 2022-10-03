using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson3
{
    public class Clothes : OutfitBase
    {
        public Clothes(ColorsWork colors) : base(colors)
        {
        }

        public override void Print()
        {
            Console.WriteLine("Цвет одежды:");
            base.Print();
        }
    }
}
