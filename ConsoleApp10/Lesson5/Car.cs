namespace ConsoleApp10.Lesson5
{
    internal abstract class Car : IMovable
    {
        public Engene EngeneCar = null;

        public string Name
        {
            get;
            private set;
        }

        public Car(string name, Engene engeneCar)
        {
            Name = name;
            EngeneCar = engeneCar;
        }


        public uint GetMoveDistance(uint time)
        {
            return time * EngeneCar.HorsePower;
        }
    }
}
