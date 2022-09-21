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

        public Car()
        {

        }

        public float GetMoveDistance(float time, bool isCheck = false)
        {
            float distance = 0;
            var currentDistance = time < EngeneCar.AccelerationTime ? (float)EngeneCar.HorsePower / (float)EngeneCar.AccelerationTime * time : (float)EngeneCar.HorsePower;

            if (!isCheck)
            {
                distance += currentDistance;
            }

            return distance;
        }

        public static IMovable[] DeleteCar(IMovable[] movables)
        {
            IMovable[] deleteCarArray = new IMovable[movables.Length - 1];

            Console.WriteLine("What car do you want to delete?");
            int numDeleteCar = Convert.ToInt32(Console.ReadLine());
            while (numDeleteCar > movables.Length || numDeleteCar < 0)
            {
                Console.WriteLine("Please enter a positive number!");
                numDeleteCar = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0, j = 0; i < movables.Length; i++)
            {
                if (numDeleteCar - 1 != i)
                {
                    deleteCarArray[j] = movables[i];
                    j++;
                }
                else
                {
                    Console.WriteLine($"You deleted: {movables[i].GetType().Name}");
                }
            }

            return deleteCarArray;
        }

        public virtual IMovable[] AddCar(IMovable[] movables)
        {
            IMovable[] addingCarArray = new IMovable[movables.Length + 1];

            for (int i = 0; i < movables.Length; i++)
            {
                addingCarArray[i] = movables[i];
            }

            Console.Write("Enter your name: ");
            string nameCar = Console.ReadLine();
            while (nameCar == string.Empty)
            {
                Console.Write("Enter your name: ");
                nameCar = Console.ReadLine();
            }

            Console.Write("Enter horsepower: ");
            int horsePower = InputCheck(Console.ReadLine());

            Console.Write("Enter acceleration time: ");
            int accelerationTime = InputCheck(Console.ReadLine());

            //addingCarArray[addingCarArray.Length - 1] = Car(nameCar, horsePower, accelerationTime);

            return addingCarArray;
        }

        private protected static Colors InputColor(Colors color)
        {
            int number = 1;
            var colors = (Colors[])Enum.GetValues(typeof(Colors));
            for (int i = 1; i <= colors.Length; i++)
            {
                Console.WriteLine($"{colors[i - 1]} - {i}");
            }

            string numColor = Console.ReadLine();
            int num = InputCheck(numColor);

            for (int i = 1; i <= colors.Length; i++)
            {
                if (i == num)
                {
                    Console.WriteLine($"You choosed {colors[i - 1]} colors");
                    color = colors[i - 1];
                }
            }

            return color;
        }

        private static int InputCheck(string input)
        {
            int number;
            bool isNumber = int.TryParse(input, out number);
            while (isNumber == false || number <= 0 || input == string.Empty)
            {
                Console.WriteLine("Please enter a positive number!");
                input = Console.ReadLine();
                isNumber = int.TryParse(input, out number);
            }

            return number;
        }
    }
}
