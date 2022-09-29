namespace ConsoleApp10.Lesson5
{
    internal abstract class Car : IMovable
    {
        public Engene Engene = null;
        public Colors Colors 
        {
            get;
            private set;
        }
        public string Name
        {
            get;
            private set;
        }

        public Car(string name, Engene engene, Colors colors)
        {
            Name = name;
            Engene = engene;
            Colors = colors;
        }

        public Car()
        {

        }

        public float GetMoveDistance(float time, bool isCheck = false)
        {
            float currentDistance = time < Engene.AccelerationTime ? Engene.HorsePower / Engene.AccelerationTime * time :
                Engene.HorsePower * time;

            return currentDistance;
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

            Colors colors = Input.InputColor();

            Name = name;
            Engene.HorsePower = horsePower;
            Engene.AccelerationTime = accelerationTime;
            Colors = colors;
        }
    }
}
