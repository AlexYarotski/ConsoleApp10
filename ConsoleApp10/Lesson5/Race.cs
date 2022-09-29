using ConsoleApp10.Lesson3;

namespace ConsoleApp10.Lesson5
{
    internal class Race
    {

        public static int cout = 0;

        public int Distance
        {
            get;
            private set;
        }

        public Race(int distance = 25)
        {
            Distance = distance;
        }

        public async Task<int[]> StartRace(IMovable[] movables, float refreshDelay)
        {
            string[] racingCar = new string[movables.Length];

            int[] finished = new int[movables.Length];

            for (int i = 0; i < finished.Length; i++)
            {
                finished[i] = -1;
            }

            int finishedIndex = 0;
            
            for (float i = 0; !IsAllFinished(movables, i - refreshDelay); i += refreshDelay)
            {
                for (int j = 0; j < movables.Length; j++)
                {
                    var moveDistance = (int)movables[j].GetMoveDistance(i);

                    if (moveDistance >= Distance)
                    {
                        if (!finished.IsContain(j))
                        {
                            finished[finishedIndex] = j;

                            finishedIndex++;
                        }
                    }
                    
                    racingCar[j] = new('-', Math.Clamp(moveDistance, 0, Distance));

                    Console.WriteLine(
                        $"|{racingCar[j]}{new string(' ', Math.Clamp(Distance - racingCar[j].Length, 0, Distance))}|");
                }

                await Task.Delay((int)(refreshDelay * 1000));
                
                Console.Clear();
            }

            return finished;
        }

        private bool IsAllFinished(IMovable[] movables, float time)
        {
            for (int i = 0; i < movables.Length; i++)
            {
                if (movables[i].GetMoveDistance(time) <= Distance)
                {
                    return false;
                }
            }

            Console.WriteLine("all Finished");
            
            return true;
        }
    }
}