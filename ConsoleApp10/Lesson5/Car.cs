namespace ConsoleApp10.Lesson5
{
    internal abstract class Car : IMovable
    {
        protected Engine CarEngine = null;
        
        public Colors Color 
        {
            get;
            private set;
        }
        
        public string Name
        {
            get;
            private set;
        }

        protected Car(string name, Engine carEngine, Colors color)
        {
            Name = name;
            CarEngine = carEngine;
            Color = color;
        }

        protected Car()
        {
        }

        public abstract void GetIndividualInfo();

        public float GetMoveDistance(float time)
        {
            float currentDistance = time < CarEngine.AccelerationTime ? (float)CarEngine.HorsePower / CarEngine.AccelerationTime * time :
                CarEngine.HorsePower * time;

            return currentDistance;
        }

        public virtual void Setup()
        {
            var name = String.Empty;
            
            while (name == string.Empty)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.Write("Enter horsepower: ");
            int horsePower = Input.InputCheck(Console.ReadLine());

            Console.Write("Enter acceleration time: ");
            int accelerationTime = Input.InputCheck(Console.ReadLine());

            Colors inputColor = Input.InputColor();
            
            CarEngine = new Engine(horsePower, accelerationTime);
            Name = name;
            Color = inputColor;
        }
    }
}
