namespace ConsoleApp10.Lesson5
{
    internal class Input
    {
        public static Colors InputColor()
        {
            Colors[] colors = (Colors[])Enum.GetValues(typeof(Colors));

            Console.WriteLine("");

            for (int i = 1; i <= colors.Length; i++)
            {
                Console.WriteLine($"{colors[i - 1]} - {i}");
            }

            Console.Write("Choose a color: ");

            string numColor = Console.ReadLine();
            int num = InputCheck(numColor);

            return colors[num - 1];
        }

        public static int InputCheck(string input)
        {
            int number;
            bool isNumber = int.TryParse(input, out number);
            while (isNumber == false || number <= 0 || input == string.Empty)
            {
                Console.WriteLine("Please enter a positive number!");
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out number);
            }

            return number;
        }

        public static bool InputBoolCheck(string input)
        {
            Console.WriteLine("");
            Console.WriteLine("1 - True \r\n2 - False");
            Console.Write(input);

            string inputKey = Console.ReadLine();
            int number;
            bool haveBool = int.TryParse(inputKey, out number);
            while (haveBool == false || number <= 0 || number > 2 || input == string.Empty)
            {
                Console.WriteLine("Please enter a positive number!");
                inputKey = Console.ReadLine();
                haveBool = int.TryParse(inputKey, out number);
            }
            Console.WriteLine("");

            return number == 1? true : false;
        }
    }
}
