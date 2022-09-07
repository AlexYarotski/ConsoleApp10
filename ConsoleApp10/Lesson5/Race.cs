namespace ConsoleApp10.Lesson5
{
    internal class Race 
    {
        private int _distance = 1000;

        IMovable[] Movables;
        public Race (IMovable[] movables)
        {
            Movables = movables;
        }

        public async void StartRace(Bmw bmw, Lada lada)
        {
            for (int i = 0; i < _distance; i++)
            {
                bmw.EngeneCar.GetMoveDistance(60);
            }

        }
    }
}
