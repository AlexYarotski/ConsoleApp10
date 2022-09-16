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

        static float temp = 0;
        public float GetMoveDistance(float time, bool isCheck = false)
        {
            var currentDistance = time < EngeneCar.AccelerationTime ? (float)EngeneCar.HorsePower / (float)EngeneCar.AccelerationTime * time : (float)EngeneCar.HorsePower;

            if (!isCheck)
            {
                temp += currentDistance;
            }

            return temp;
        }
    }
}
