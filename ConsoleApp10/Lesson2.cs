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
    }
}
