namespace ConsoleApp10.Lesson5
{
    internal class Race
    {
        public uint Time
        {
            get;
            private set;
        }

        public uint Distance
        {
            get;
            private set;
        }

        public Race(uint time = 20, uint distance = 25)
        {
            Time = time;
            Distance = distance;
        }

        public async Task StartRace(Car[] car)
        {
            for (uint i = 0, j = 0; (i <= Time || j <= Distance); i++, j++)
            {
                string[] racingCar = new string[car.Length];

                for (uint z = 0; z < racingCar.Length; z++)
                {
                    racingCar[z] = new('-', (int)car[z].GetMoveDistance(i));
                }

                if (i != Time)
                {
                    for (int w = 0; w < car.Length; w++)
                    {
                        if ((int)car[w].GetMoveDistance(i) >= Distance)
                        {
                            Console.WriteLine("FINISH!");
                            Console.WriteLine($"Winner: {car[w].Name}");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"|{racingCar[w]}{new string(' ', (int)Distance - racingCar[w].Length)}|");
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Time is over");
                }
            }
        }
    }
}
