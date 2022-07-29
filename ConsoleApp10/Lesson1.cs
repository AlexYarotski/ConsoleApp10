using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public static class Lesson1
    {

        public static void Task1()
        {
            int maxInd = 0;

            var num = GetIntArrayFromKeyboard();

            var maxNum = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                if (maxNum < num[i])
                {
                    maxNum = num[i];

                    maxInd = i;
                }

            }
            Console.WriteLine($"Индекс: {maxInd} \r\nЧисло: {maxNum}");
        }

        public static void Task2()
        {
            int maxInd = 0;

            var num = GetIntArrayFromKeyboard();

            var maxNum = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                if (maxNum < Math.Abs(num[i]))
                {
                    maxNum = Math.Abs(num[i]);
                    maxInd = i;
                }

            }
            Console.WriteLine($"Индекс: {maxInd} \r\nЧисло: {maxNum}");
        }

        public static void Task3()
        {
            int maxInd = 0;
            int minInd = 0;

            var num = GetIntArrayFromKeyboard();

            var maxNum = num[0];
            var minNum = num[0];
            // i = 1, i = 0
            for (int i = 1; i < num.Length; i++)
            {
                if (maxNum < num[i])
                {
                    maxInd = i;
                    maxNum = num[i];
                }
                else if (minNum > num[i])
                {
                    minInd = i;
                    minNum = num[i];
                }
            }

            num[maxInd] = minNum;
            num[minInd] = maxNum;

            Console.WriteLine("New array");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{ num[i] } ");
            }
        }

        public static void Task4()
        {
            var num = GetIntArrayFromKeyboard();

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i - 1] < num[i])
                {
                    Console.WriteLine(num[i]);
                }
            }
        }

        private static int[] GetIntArrayFromKeyboard()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            return num;
        }
    }
}
