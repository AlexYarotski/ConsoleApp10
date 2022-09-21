namespace ConsoleApp10.Lesson5
{
    internal abstract class Menu
    {
        public static IMovable[] MenuRaceSummary(IMovable[] movables)
        {
            int number = 0;
            do
            {
                number = ShowMainMenu(movables);

                switch (number)
                {
                    case 1:
                        movables = Menu.MenuAddCar(number, movables);
                        break;

                    case 2:
                        movables = Car.DeleteCar(movables);
                        break;
                }
            }
            while (number != 3);

            return movables;
        }

        public static int ShowMainMenu(IMovable[] movables)
        {
            Console.Write("Members: ");
            for (int i = 0; i < movables.Length; i++)
            {
                Console.Write($"{i + 1}: {movables[i].GetType().Name} {((Car)movables[i]).Name}   ");
            }
            Console.WriteLine();

            Console.WriteLine("Choose an action: ");
            Console.WriteLine("1 - Add car");
            Console.WriteLine("2 - Remove car");
            Console.WriteLine("3 - Start race");
            Console.WriteLine("4 - View cars");

            string strNumber = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(strNumber, out number);
            while (number <= 0 || number > 4 || strNumber == string.Empty)
            {
                if (movables.Length > 0)
                {
                    Console.Write("Enter a number from 1 to 4: ");
                    strNumber = Console.ReadLine();
                    number = Convert.ToInt32(strNumber);
                }

                else
                {
                    Console.WriteLine("Car list is empty");
                    strNumber = Console.ReadLine();
                    number = Convert.ToInt32(strNumber);
                }
                
            }

            return number;
        }

        public static IMovable[] MenuAddCar(int numberCar, IMovable[] movables)
        {
            Console.WriteLine("What car do you want to build:");
            Console.WriteLine("1 - Lada");
            Console.WriteLine("2 - Bmw");
            Console.WriteLine("0 - Cancel");

            numberCar = Convert.ToInt32(Console.ReadLine());

            while (numberCar > 2 || numberCar < 0)
            {
                Console.Write("Enter a number from 1 to 2: ");
                numberCar = Convert.ToInt32(Console.ReadLine());
            }

            switch (numberCar)
            {
                case 1:
                    Lada lada = new Lada();
                    lada.AddCar(movables);
                    break;

                case 2:
                    Bmw bmw = new Bmw();
                    bmw.AddCar(movables);
                    break;

                case 0:
                    numberCar = ShowMainMenu(movables);
                    break;
            }

            return movables;
        }
    }
}
