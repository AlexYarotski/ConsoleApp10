using ConsoleApp10.Lesson5;

namespace ConsoleApp10.Lesson3
{
    internal static class ArrayHelper
    {
        public static bool IsValid(int[] ints)
        {
            if (ints == null || ints.Length == 0)
            {
                Console.WriteLine("Массив не пригоден");

                return false;
            }

            return true;
        }

        public static void Print(int[] ints)
        {
            if (!IsValid(ints))
            {
                return;
            }

            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write(ints[i].ToString() + " ");
            }

            Console.WriteLine();
        }

        public static int Max(int[] ints)
        {
            if (!IsValid(ints))
            {
                return -1;
            }

            int max = ints[0];

            for (int i = 1; i < ints.Length; i++)
            {
                if (max < ints[i])
                {
                    max = ints[i];
                }
            }

            return max;
        }

        public static int Min(int[] ints)
        {
            if (!IsValid(ints))
            {
                return -1;
            }

            int min = ints[0];

            for (int i = 1; i < ints.Length; i++)
            {
                if (min > ints[i])
                {
                    min = ints[i];
                }
            }

            return min;
        }

        public static bool IsContain(this int[] array, int target)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return true;
                }
            }

            return false;
        }
    }
}