namespace ConsoleApp10.Lesson5
{
    internal abstract class Car : IMovable
    {
        public Engene Engene = null;
        private float _distance = 0;

        public string Name
        {
            get;
            private set;
        }

        public Car(string name, Engene engene)
        {
            Name = name;
            Engene = engene;
        }

        public Car()
        {

        }

        public float GetMoveDistance(float time, bool isCheck = false)
        {
            float currentDistance = time < Engene.AccelerationTime ? (float)Engene.HorsePower / (float)Engene.AccelerationTime * time : (float)Engene.HorsePower;

            if (!isCheck)
            {
                _distance += currentDistance;
            }

            return _distance;
        }

        public virtual void Setup()
        {
            Engene = new Engene();

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            while (name == string.Empty)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.Write("Enter horsepower: ");
            int horsePower = Input.InputCheck(Console.ReadLine());

            Console.Write("Enter acceleration time: ");
            int accelerationTime = Input.InputCheck(Console.ReadLine());

            Name = name;
            Engene.HorsePower = horsePower;
            Engene.AccelerationTime = accelerationTime;
        }

        
    }
}
