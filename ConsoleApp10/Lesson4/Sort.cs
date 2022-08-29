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
            for (int i = 0; i < array.Length - 2; i++)
            {
                for (int j = 0; j < array.Length - 2; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int sortResult = array[j + 1];
                        array[j + 1] = array[j];
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
