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
            movables = RaceSummary(movables);
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

        public static IMovable[] RaceSummary(IMovable[] movables)
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

            int number = Convert.ToInt32(Console.ReadLine());
            while (number <= 0 || number > 3)
            {
                Console.Write("Enter a number from 1 to 3: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            switch (number)
            {
                case 1:
                    IMovable[] addingCarArray = new IMovable[movables.Length +1];

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

                            Console.Write("Enter horsepower: ");
                            string strHorseLada = Console.ReadLine();
                            int horsePowerLada;
                            bool isNumHorseLada = int.TryParse(strHorseLada, out horsePowerLada);
                            {
                                while (isNumHorseLada == false || horsePowerLada <= 0)
                                {
                                    Console.WriteLine("Please enter a positive number!");
                                    strHorseLada = Console.ReadLine();
                                    isNumHorseLada = int.TryParse(strHorseLada, out horsePowerLada);
                                }
                            }

                            Console.Write("Enter acceleration time: ");
                            string strAccelerationLada = Console.ReadLine();
                            int accelerationTimeLada;
                            bool isNumAccelerationLada = int.TryParse(strAccelerationLada, out accelerationTimeLada);
                            {
                                while(isNumAccelerationLada == false || accelerationTimeLada <= 0)
                                {
                                    Console.WriteLine("Please enter a positive number!");
                                    strAccelerationLada = Console.ReadLine();
                                    isNumAccelerationLada = int.TryParse(strAccelerationLada, out accelerationTimeLada);
                                }
                            }

                            Console.WriteLine("Choose a color: ");
                            Console.WriteLine($"{Colors.Green} \r\n {Colors.Red} \r\n {Colors.Blue} \r\n {Colors.Gray} \r\n {Colors.Yellow}");
                            Colors colorLada = Colors.Green;

                            //while (colorLada != "Green" || colorLada != "Red" || colorLada != "Blue" || colorLada != "Green" || colorLada != "Yellow")
                            //{
                            //    Console.WriteLine("Choose an existing color!");
                            //    colorLada = Console.ReadLine();
                            //}

                            Lada newLada = new Lada(nameLada, new Engene(horsePowerLada, accelerationTimeLada), Colors.Gray);

                            for (int i = addingCarArray.Length - 1; i < addingCarArray.Length; i++)
                            {
                                addingCarArray[i] = newLada;
                            }
                            Console.Write($"You added: {newLada.GetType().Name} \r\n Name: {nameLada} \r\n Horse Power: {horsePowerLada} \r\n Acceleration Time{accelerationTimeLada} \r\n Colors: {Colors.Gray}");
                            break;

                        case 2:
                            Console.Write("Enter your name: ");
                            string nameBmw = Console.ReadLine();

                            Console.Write("Enter horsepower: ");

                            string strHorseBmw = Console.ReadLine();
                            int horsePowerBmw;
                            bool isNumHorseBmw = int.TryParse(strHorseBmw, out horsePowerBmw);
                            {
                                while (isNumHorseBmw == false || horsePowerBmw <= 0)
                                {
                                    Console.WriteLine("Please enter a positive number!");
                                    strHorseBmw = Console.ReadLine();
                                    isNumHorseBmw = int.TryParse(strHorseBmw, out horsePowerBmw);
                                }
                            }

                            Console.Write("Enter acceleration time: ");

                            string strAccelerationBmw = Console.ReadLine();
                            int accelerationTimeBmw;
                            bool isNumAccelerationBmw = int.TryParse(strAccelerationBmw, out accelerationTimeBmw);
                            {
                                Console.WriteLine("Please enter a positive number!");
                                strAccelerationBmw = Console.ReadLine();
                                isNumAccelerationBmw = int.TryParse(strAccelerationBmw, out accelerationTimeBmw);
                            }

                            Console.WriteLine("Choose a color: ");
                            Console.WriteLine($"{Colors.Green} \r\n {Colors.Red} \r\n {Colors.Blue} \r\n {Colors.Gray} \r\n {Colors.Yellow}");
                            Colors colorBmw = Colors.Green;

                            //while (colorBmw != "Green" || colorBmw != "Red" || colorBmw != "Blue" || colorBmw != "Green" || colorBmw != "Yellow")
                            //{
                            //    Console.WriteLine("Choose an existing color!");
                            //    colorBmw = Console.ReadLine();
                            //}

                            Bmw newBmw = new Bmw(nameBmw, new Engene(horsePowerBmw, accelerationTimeBmw), Colors.Red);

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
                    break;

                case 2:
                    IMovable[] deleteCarArray = new IMovable[movables.Length - 1];

                    Console.WriteLine("What car do you want to delete?");
                    int numDeleteCar = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < movables.Length; i++)
                    {
                        if (numDeleteCar - 1 != i)
                        {
                            deleteCarArray[i] = movables[i];
                        }
                    }

                    return deleteCarArray;
                    break;

                case 3:
                    return movables;
                    break;
            }

            return movables;
        }
    }
}
