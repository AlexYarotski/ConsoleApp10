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

            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

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

            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            ;
            for (int i = 0; i < num.Length; i++)
            {
                num[i] =Math.Abs( Convert.ToInt32(Console.ReadLine()));
            }

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

        public static void Task3()
        {
            int maxInd = 0;
            int minInd = 0;

            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            }

            var maxNum = num[0];
            var minNum = num[0];

            for (int i = 1; i < num.Length; i++)
            {
                if (maxNum < num[i])
                {
                    maxInd = i;
                    maxNum = num[i];
                }
                else
                {
                    minInd = i;
                    minNum = num[i];
                }

            }

            var minimal = num[minInd];
            var maximal = num[maxInd];

            num[minInd] = maximal;
            num[maxInd] = minimal;

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            
        }
    }
}
