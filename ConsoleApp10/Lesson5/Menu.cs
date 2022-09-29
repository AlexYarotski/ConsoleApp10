namespace ConsoleApp10.Lesson5
{
    internal class Menu
    {
        public static IMovable[] MenuRaceSummary(IMovable[] movables)
        {
            Menu menu = new Menu();
            int number = 0;
            do
            {
                number = menu.ShowMainMenu(movables);

                switch (number)
                {
                    case 1:
                        movables = menu.MenuAddCar(number, movables);
                        break;

                    case 2:
                        movables = menu.DeleteCar(movables);
                        break;
                }
            }
            while (number != 3);

            return movables;
        }

        public int ShowMainMenu(IMovable[] movables)
        {
            Console.WriteLine("Members: ");

            if (movables.Length == 0)
            {
                Console.WriteLine("No cars");
            }

            else
            {
                for (int i = 0; i < movables.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: {movables[i].GetType().Name} {((Car)movables[i]).Name}");
                }
            }
            
            Console.WriteLine("");
            Console.WriteLine("1 - Add car");
            Console.WriteLine("2 - Remove car");
            Console.WriteLine("3 - Start race");
            Console.Write($"Choose an action: ");

            string strNumber = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(strNumber, out number);
            if (movables.Length == 0)
            {
                while (number <= 0 || number > 1 || strNumber == string.Empty)
                {
                    Console.Write("You can only add a car: ");
                    strNumber = Console.ReadLine();
                    number = Convert.ToInt32(strNumber);
                }
            }

            else
            {
                while (number <= 0 || number > 3 || strNumber == string.Empty)
                {
                    Console.Write("Enter a number from 1 to 3: ");
                    strNumber = Console.ReadLine();
                    number = Convert.ToInt32(strNumber);
                }
            }
            Console.WriteLine("");

            return number;
        }

        public IMovable[] MenuAddCar(int numberCar, IMovable[] movables)
        {
            Console.WriteLine("1 - Lada");
            Console.WriteLine("2 - Bmw");
            Console.WriteLine("0 - Cancel");
            Console.Write($"What car do you want to build: ");

            numberCar = Convert.ToInt32(Console.ReadLine());

            while (numberCar > 2 || numberCar < 0)
            {
                Console.Write("Enter a number from 1 to 2: ");
                numberCar = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");

            switch (numberCar)
            {
                case 1:
                    Lada lada = new Lada();
                    lada.Setup();
                    movables = AddCar(movables, lada);

                    break;

                case 2:
                    Bmw bmw = new Bmw();
                    bmw.Setup();
                    movables = AddCar(movables, bmw);
                    break;

                case 0:
                    numberCar = ShowMainMenu(movables);
                    break;
            }

            return movables;
        }

        public IMovable[] DeleteCar(IMovable[] movables)
        {
            IMovable[] deleteCarArray = new IMovable[movables.Length - 1];

            Console.WriteLine("What car do you want to delete?");
            Console.WriteLine("0 - Cancel");
            Console.Write("Enter a number: ");

            int numDeleteCar = Convert.ToInt32(Console.ReadLine());
            while (numDeleteCar > movables.Length || numDeleteCar < 0)
            {
                Console.WriteLine("Please enter a positive number!");
                numDeleteCar = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");

            if (numDeleteCar == 0)
            {
                return movables;
            }

            else
            {
                for (int i = 0, j = 0; i < movables.Length; i++)
                {
                    if (numDeleteCar - 1 != i)
                    {
                        deleteCarArray[j] = movables[i];
                        j++;
                    }

                    else
                    {
                        Console.WriteLine($"You deleted: {movables[i].GetType().Name}");
                        Console.WriteLine("");
                    }
                }
            }
           
            return deleteCarArray;
        }

        public IMovable[] AddCar(IMovable[] movables, IMovable movable)
        {
            IMovable[] newMovables = new IMovable[movables.Length + 1];
            for (int i = 0; i < movables.Length; i++)
            {
                newMovables[i] = movables[i];
            }
            newMovables[newMovables.Length - 1] = movable;
            
            return newMovables;
        }
    }
}
