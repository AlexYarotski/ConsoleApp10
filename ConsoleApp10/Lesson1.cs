namespace ConsoleApp10
{
    public static class Lesson1
    {

        public static void Task1()
        {
            int maxIndex = 0;

            var array = GetIntArrayFromKeyboard();

            var maxNum = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (maxNum < array[i])
                {
                    maxNum = array[i];

                    maxIndex = i;
                }

            }
            Console.WriteLine($"Индекс: {maxIndex} \r\nЧисло: {maxNum}");
        }

        public static void Task2()
        {
            int maxIndex = 0;

            var array = GetIntArrayFromKeyboard();

            var maxNum = Math.Abs(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                if (maxNum < Math.Abs(array[i]))
                {
                    maxNum = Math.Abs(array[i]);
                    maxIndex = i;
                }

            }
            Console.WriteLine($"Индекс: {maxIndex} \r\nЧисло: {maxNum}");
        }

        public static void Task3()
        {
            int maxIndex = 0;
            int minIndex = 0;

            var array = GetIntArrayFromKeyboard();

            var maxNum = array[0];
            var minNum = array[0];
            int emp = 0;
            // i = 1, i = 0
            for (int i = 1; i < array.Length; i++)
            {
                if (maxNum < array[i])
                {
                    maxIndex = i;
                    maxNum = array[i];
                }
                if (minNum > array[i])
                {
                    minIndex = i;
                    minNum = array[i];
                }
            }
            emp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = emp;  

            Console.WriteLine("Новый массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{ array[i] } ");
            }
        }

        public static void Task4()
        {
            var array = GetIntArrayFromKeyboard();

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] < array[i])
                {
                    Console.Write($"{array[i]} ");
                }
            }
        }

        public static void Task5()
        {
            Console.Write("Введите размер массива: ");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[arraySize];

            Console.WriteLine("Рандомно получили числа: ");
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
                Console.Write($"{array[i]} ");
                Console.WriteLine("");
            }

            Console.WriteLine("Введите индекс массива который хотите удалить: ");
            int arrayIndex = Convert.ToInt32(Console.ReadLine());
            while (arrayIndex < 0 || arrayIndex > (arraySize - 1))
            {            
                Console.WriteLine($"Индекс должен быть от 0 до {arraySize -1}");
                Console.Write("Введите индекс массива который хотите удалить: ");
                arrayIndex = Convert.ToInt32(Console.ReadLine());
            }
            int[] resultArray = new int[arraySize - 1];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(i != arrayIndex)
                {
                    resultArray[j] = array[i];
                    Console.Write($"{resultArray[j]} ");
                    j++;
                }
            }

        }

        public static void Task6()
        {
            int j = 0;
            int q = 0;
            var array = GetIntArrayFromKeyboard();

            Console.Write("Введите минимальную границу массива: ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите максимальную границу массива: ");
            int maxValue = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue || array[i] > maxValue)
                {
                    j++;
                }
            }

            Console.Write("Новый массив: ");
            var newArray = new int[j];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minValue || array[i] > maxValue)
                {

                    newArray[q] = array[i];
                    Console.Write($"{newArray[q]} ");
                    q++;
                   
                }
            }
        }

        private static int[] GetIntArrayFromKeyboard()
        {
            Console.WriteLine("Введите размер массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Введите значения массива: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            return array;
        }
    }
}
