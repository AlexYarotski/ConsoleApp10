namespace ConsoleApp10.Lesson5
{
    internal class Race
    {

        public int Distance
        {
            get;
            private set;
        }

        public Race(int distance = 25)
        {
            Distance = distance;
        }

        public async Task<IMovable[]> StartRace(IMovable[] movables, float refreshDelay)
        {
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

            int time = 2;
            for (int i = 0; i < movables.Length - 1; i++)
            {
                for (int j = 0; j < movables.Length - 1 - i; j++)
                {
                    if (movables[j].GetMoveDistance(time) < movables[j + 1].GetMoveDistance(time))
                    {
                        IMovable temp = movables[j];
                        movables[j] = movables[j + 1];
                        movables[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < movables.Length; i++)
            {
                Console.WriteLine($"{i + 1} place: {movables[i].GetType().Name} \r\nName: {((Car)movables[i]).Name}" +
                    $" \r\nHorsePower: {((Car)movables[i]).Engene.HorsePower} \r\nAccelerationTime: {((Car)movables[i]).Engene.AccelerationTime}" +
                    $" \r\nColor: {((Car)movables[i]).Colors} \r\n");
                Console.WriteLine("");
            }

            return movables;
        }

        private bool IsAllFinished(IMovable[] movables, float time)
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
    }
}