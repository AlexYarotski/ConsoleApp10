namespace ConsoleApp10.Lesson3
{
    internal class ArrayHelper
    {
        public bool IsValid(int[] ints)
        {
            if (ints == null || ints.Length == 0)
            {
                Console.WriteLine("Массив не пригоден");

                return false;
            }

            return true;
        }

        public void Print(int[] ints)
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

        public int Max(int[] ints)
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

        public int Min(int[] ints)
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
    }
}