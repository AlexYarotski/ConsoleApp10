using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson5
{
    internal class Input
    {
        public static Colors InputColor(Colors color)
        {
            int number = 1;
            var colors = (Colors[])Enum.GetValues(typeof(Colors));

            Console.WriteLine("");

            for (int i = 1; i <= colors.Length; i++)
            {
                Console.WriteLine($"{colors[i - 1]} - {i}");
            }

            Console.Write("Choose a color: ");

            string numColor = Console.ReadLine();
            int num = InputCheck(numColor);

            for (int i = 1; i <= colors.Length; i++)
            {
                if (i == num)
                {
                    Console.WriteLine($"You choosed {colors[i - 1]} colors");
                    color = colors[i - 1];
                }
            }
            

            return color;
        }

        public static int InputCheck(string input)
        {
            int number;
            bool isNumber = int.TryParse(input, out number);
            while (isNumber == false || number <= 0 || input == string.Empty)
            {
                Console.WriteLine("Please enter a positive number!");
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out number);
            }

            return number;
        }
    }
}
