namespace ConsoleApp10.Lesson5
{
    internal class Race
    {
        public uint Time
        {
            get;
            private set;
        }

        public int Distance
        {
            get;
            private set;
        }

        public Race(uint time = 20, int distance = 25)
        {
            Time = time;
            Distance = distance;
        }

        public async Task<IMovable[]> StartRace(IMovable[] movables, float refreshDelay)
        {
            movables = MenuRaceSummary(movables);
            string[] racingCar = new string[movables.Length];

            for (float i = 0; !IsAllFinished(movables, i); i += refreshDelay)
            {
                for (uint z = 0; z < racingCar.Length; z++)
                {
                    racingCar[z] = new('-', Math.Clamp((int)movables[z].GetMoveDistance(i), 0, Distance));
                }

                for (int w = 0; w < movables.Length; w++)
                {
                    Console.WriteLine($"|{racingCar[w]}{new string(' ', Math.Clamp(Distance - racingCar[w].Length, 0, Distance))}|");
                }
                await Task.Delay((int)(refreshDelay * 1000));
                Console.Clear();
            }

            int[] index = new int[movables.Length];
            int time = 2;

            for (int i = 0; i < movables.Length - 1; i++)
            {
                for (int j = 0; j < movables.Length - 1 - i; j++)
                {
                    if (movables[j].GetMoveDistance(time) < movables[j + 1].GetMoveDistance(time))
                    {
                        var temp = movables[j];
                        movables[j] = movables[j + 1];
                        movables[j + 1] = temp;
                    }
                }
            }

            return movables;
        }

        public bool IsAllFinished(IMovable[] movables, float time)
        {
            for (int i = 0; i < movables.Length; i++)
            {
                if (movables[i].GetMoveDistance(time, true) < Distance)
                {
                    return false;
                }
            }

            return true;
        }

        public static IMovable[] MenuRaceSummary(IMovable[] movables)
        {
            int number = 0;
            do
            {
                number = ShowMainMenu(movables);

                switch (number)
                {
                    case 1:
                        movables = AddCar(number, movables);
                        break;

                    case 2:
                        movables = DeleteCar(movables);
                        break;
                }

                

            } while (number != 3);

            return movables;
        }

        public static IMovable[] AddCar(int number, IMovable[] movables)
        {
            switch (number)
            {
                case 1:
                    IMovable[] addingCarArray = new IMovable[movables.Length + 1];
                    Colors color = new Colors();

                    for (int i = 0; i < movables.Length; i++)
                    {
                        addingCarArray[i] = movables[i];
                    }

                    Console.WriteLine("What car do you want to build:");
                    Console.WriteLine("1 - Lada");
                    Console.WriteLine("2 - Bmw");
                    Console.WriteLine("0 - Cancel");

                    int numberCar = Convert.ToInt32(Console.ReadLine());

                    while (numberCar > 2 || numberCar <= 0)
                    {
                        Console.Write("Enter a number from 1 to 3: ");
                        numberCar = Convert.ToInt32(Console.ReadLine());
                    }

                    switch (numberCar)
                    {
                        case 1:
                            Console.Write("Enter your name: ");
                            string nameLada = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("Enter horsepower: ");
                            int horsePowerLada = InputCheck(Console.ReadLine());
                            Console.WriteLine();

                            Console.Write("Enter acceleration time: ");
                            int accelerationTimeLada = InputCheck(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("Choose a color: ");
                            Colors colorLada = InputColor(color);
                            Console.WriteLine();

                            Lada newLada = new Lada(nameLada, new Engene(horsePowerLada, accelerationTimeLada), colorLada);

                            for (int i = addingCarArray.Length - 1; i < addingCarArray.Length; i++)
                            {
                                addingCarArray[i] = newLada;
                            }
                            Console.Write($"You added: {newLada.GetType().Name} \r\n Name: {nameLada} \r\n Horse Power: {horsePowerLada} \r\n Acceleration Time{accelerationTimeLada} \r\n Colors: {Colors.Gray}");
                            break;

                        case 2:
                            Console.Write("Enter your name: ");
                            string nameBmw = Console.ReadLine();
                            Console.WriteLine();

                            Console.Write("Enter horsepower: ");
                            int horsePowerBmw = InputCheck(Console.ReadLine());
                            Console.WriteLine();

                            Console.Write("Enter acceleration time: ");
                            int accelerationTimeBmw = InputCheck(Console.ReadLine());
                            Console.WriteLine();

                            Console.WriteLine("Choose a color:");
                            Colors colorBmw = InputColor(color);
                            Console.WriteLine();

                            Bmw newBmw = new Bmw(nameBmw, new Engene(horsePowerBmw, accelerationTimeBmw), colorBmw);

                            for (int i = addingCarArray.Length - 1; i < addingCarArray.Length; i++)
                            {
                                addingCarArray[i] = newBmw;
                            }
                            Console.Write($"You added: {nameBmw.GetType().Name} \r\n Name: {nameBmw} \r\n Horse Power: {horsePowerBmw} \r\n Acceleration Time{accelerationTimeBmw} \r\n Colors: {Colors.Red}");
                            break;

                        case 0:
                            break;
                    }
                    return movables = addingCarArray;
            }

            return movables;
        }

        public static IMovable[] DeleteCar(IMovable[] movables)
        {
            IMovable[] deleteCarArray = new IMovable[movables.Length - 1];

            Console.WriteLine("What car do you want to delete?");
            int numDeleteCar = Convert.ToInt32(Console.ReadLine());

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
                }
            }

            return deleteCarArray;
        }

        public static int ShowMainMenu(IMovable[] movables)
        {
            Console.Write("Members: ");
            for (int i = 0; i < movables.Length; i++)
            {
                Console.Write($"{movables[i].GetType().Name} {movables[i].GetType().Name}  ");
            }
            Console.WriteLine();

            Console.WriteLine("Choose an action: ");
            Console.WriteLine("1 - Add car");
            Console.WriteLine("2 - Remove car");
            Console.WriteLine("3 - Start race");
            Console.WriteLine("4 - View members");

            string strNumber = Console.ReadLine();
            int number;
            bool isNumber = int.TryParse(strNumber, out number);
            while (number <= 0 || number > 4 || strNumber == string.Empty)
            {
                Console.Write("Enter a number from 1 to 3: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            return number;
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

        public static Colors InputColor(Colors color)
        {
            int number = 1;
            foreach (Colors colors in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine($"{colors} - {number}");
                number++;
            }

            string numColor = Console.ReadLine();
            int num = InputCheck(numColor);

            foreach (Colors colors in Enum.GetValues(typeof(Colors)))
            {
                if (number == num)
                {
                    Console.WriteLine($"You choosed {colors} colors");
                    color = colors;
                    break;
                }
                number--;
            }

            return color;
        }
    }
}
