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
   
        public IMovable[] Movables = null;

        public Race (uint time = 20, uint distance = 25)
        {
            Time = time;
            Distance = distance;
        }

        public async Task StartRace(Car[] car)
        {
            for (uint i = 0, j = 0; (i <= Time && j <= Distance); i++, j++ )
            {
                var car1 = new string('-', (int)car[0].GetMoveDistance(i));
                var car2 = new string('-', (int)car[1].GetMoveDistance(i));

                if (i != Time)
                {
                    if ((int)car[0].GetMoveDistance(i) >= Distance || (int)car[1].GetMoveDistance(i) >= Distance)
                    {
                        Console.WriteLine("FINISH!");
                        Console.WriteLine((int)car[0].GetMoveDistance(i) >= Distance ? $"Winner {car[0].Name}" : $"Winner {car[1].Name}");
                        break;
                    }

                    else
                    {
                        Console.WriteLine($"|{car1}{new string(' ', (int)Distance - car1.Length)}|");
                        Console.WriteLine($"|{car2}{new string(' ', (int)Distance - car2.Length)}|");
                        Thread.Sleep(1000);
                        Console.Clear();
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
