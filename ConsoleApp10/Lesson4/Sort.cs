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
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length - 1; j++)
                {
                    if (array[i] < array[j])
                    {
                        int sortResult = array[j];
                        array[j] = array[i];
                        array[i] = sortResult;
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
