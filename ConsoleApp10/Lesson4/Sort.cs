using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson4
{
    internal class Sort
    {
        public int[] GetRandomArray(int arrayLength)
        {
            Console.Write("Заполнили массив рандомныи числами: ");
            Random random = new Random();
            var array = new int[arrayLength];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();

            return array;
        }

        public void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i +1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int sortResult = array[i];
                        array[i] = array[j];
                        array[j] = sortResult;
                    }
                }
             }

            Console.Write("Получили отсортированный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
