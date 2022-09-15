using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson3
{
    public abstract class OutfitBase 
    {
        private Colors _colors = default;

        public OutfitBase(Colors colors)
        {
            _colors = colors;
        }

        public virtual void Print()
        {
            Console.WriteLine(_colors.ToString());
        }
    }
}
