namespace ConsoleApp10.Lesson5
{
    internal class Bmw : Car
    {
        public Enum Color 
        {
            get; 
            private set;
        }

        public Bmw(string name, Engene engeneCar, Enum color) : base(name, engeneCar)
        {
            Color = color;
        }

        public Bmw()
        {

        } 

        public override IMovable[] AddCar(IMovable[] movables)
        {
            IMovable[] newCarArray = base.AddCar(movables);
            Bmw newCar = ((Bmw)newCarArray[newCarArray.Length - 1]);
            Colors color = new Colors();
            Colors colorBmw = InputColor(color);

            Console.WriteLine("Choose a color:");

            Bmw newBmw = new Bmw(newCar.Name, new Engene(newCar.EngeneCar.HorsePower, newCar.EngeneCar.AccelerationTime), colorBmw);

            newCarArray[newCarArray.Length - 1] = newBmw;
            Console.Write($"You added: {newBmw.GetType().Name} \r\n Name: {newCar.Name} \r\n Horse Power: {newCar.EngeneCar.HorsePower} \r\n Acceleration Time{newCar.EngeneCar.AccelerationTime} \r\n Colors: {Colors.Red}");
            Console.WriteLine();

            return newCarArray;
        }
    }
}
