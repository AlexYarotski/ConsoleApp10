namespace ConsoleApp10
{
    internal class Lesson2
    {   public static void Task1()
        {
            var multiArray = GetMultidimensionalArrayintFromKeyboard();

            var minArrNum = multiArray[0, 0];
            var rowIndex = 0;
            var columnIndex = 0;


            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    if (minArrNum > multiArray[i, j])
                    {

                        columnIndex = j;
                        minArrNum = multiArray[i, j];
                        rowIndex = i; 
                    }
                }
                Console.WriteLine($"Минимальный индекс {i} строки массива: Столбец: {rowIndex}  Строка: {columnIndex}");

            }

 
           
        }
        
        public static void Task1Dop()
        {
            var multiArray = GetMultidimensionalArrayintFromKeyboard();

            var minArrNum = multiArray[0, 0];
            var y = 0;
            var x = 0;


            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    if (minArrNum > multiArray[i, j])
                    {

                        x = j;
                        minArrNum = multiArray[i, j];
                        y = i;
                    }
                }
                

            }
            Console.WriteLine($"Минимальный индекс массива: Столбец: {y}  Строка: {x}");
        }

        public static void Task2()
        {
            var multiArray = GetMultidimensionalArrayintFromKeyboard();

            
            var sumArray = new int[multiArray.GetLength(0)];
            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                var summ = 0;
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    summ += multiArray[i, j];
                }
                sumArray[i] = summ;
            }
            Console.WriteLine();

            for (int i = 0; i < sumArray.Length; i++)
            {
                Console.WriteLine($"Cумма {i} строки массива: {sumArray[i]}");
            }

            int maxSum = sumArray[0];
            for (int i = 0; i < sumArray.Length; i++)
            {
                if (maxSum  < sumArray[i])
                {
                    maxSum = sumArray[i];
                }
            }
            Console.WriteLine($"Максимальный элемент: {maxSum}");

        }

        public static void Task3()
        {
            var multiArray = GetMultidimensionalArrayintFromKeyboard();

            var positive = 0;
            var negative = 0;
            var z = 0;
            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    if (multiArray[i, j] > 0)   
                    {
                        positive++;
                    }
                    else if (multiArray[i, j] < 0)
                    {
                        negative++;
                    }
                }
            }
            
            Console.WriteLine($"Колличество положительных чисел: {positive}\r\nКоличество отрицательных чисел: {negative}");

            
            
            for (int i = 0; i < multiArray.GetLength(0); i++)
            {
                for (int j = 0; j < multiArray.GetLength(1); j++)
                {
                    if (multiArray[i, j] == 0)
                    {
                        Console.WriteLine($"Индекс столбца нулевого элемента: {i}  Индекс строки: {j}");
                    }
                }
            }

        }
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

        public static void Task6()
        {
            Console.Write("Введите слово: ");
            string input = Console.ReadLine();
            var n = input.Length;

            var isPolindrome = false;

            for (int i = input.Length -1 ; i >= 0; i--)
            {
                if (input[n - i - 1] == input[i])
                {
                    isPolindrome = true;
                    continue;
                }
                isPolindrome = false;
                break;
            }
            Console.WriteLine($"{ (isPolindrome ? $"Слово {input} является палиндромом" : $"Слово {input} не является палиндромом") }");
        }

        public static void Task6A()
        {
            Console.Write("Введите слово: ");
            string input = Console.ReadLine();
            var n = input.Length;

            var isPolindrome = false;

            var centr = input.Length / 2;
            
                for (int i = 0 ; i < centr; i++)
                {
                    
                    if (input[n - i - 1] == input[i])
                    {
                        isPolindrome = true;
                        continue;
                    }
                        isPolindrome = false;
                        break;
                }
            
            Console.WriteLine($"{(isPolindrome ? $"Слово {input} является палиндромом" : $"Слово {input} не является палиндромом")}");

        }

        public static void Task7()
        {
            Console.WriteLine("Привет");

            Console.Write("Введи фразу: ");
            var text = Console.ReadLine();

            Console.WriteLine("Какое слово потерял?");
            var word = Console.ReadLine();

            bool isContain = text.Contains(word);
            Console.WriteLine(isContain ? "Поздровляю! Здесь оно есть" : "К сожеление здесь его нет");
        }
    
        public static int[,] GetMultidimensionalArrayintFromKeyboard()
        {
            int[,] myArray = new int[2, 3];
            Console.WriteLine("Заполни массив:");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Получился массив:");

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }
           
            return myArray;
        }
    }
}
