using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Lesson2
    {
        public static void Task5()
        {
            Console.Write("Сколько имен ты знаешь: ");
            var resultLine = Console.ReadLine();

            var result = int.TryParse(resultLine, out int n);

            while (!result && n < 0)
            {
                Console.WriteLine("Ввод принимает только положительное число!");
                Console.Write("Сколько имен ты знаешь: ");
                result = int.TryParse(Console.ReadLine(), out n);
            }

            string[] array = new string[n];

            Console.WriteLine("Напиши эти имена: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }

            string shortName = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (shortName.Length > array[i].Length)
                {
                    shortName = array[i];
                }
            }
            Console.WriteLine($"Самое короткое имя: { shortName}");
        }
        private static string GetStringFromKeyboard()
        {
            return string.Empty;
        }
    }
}
