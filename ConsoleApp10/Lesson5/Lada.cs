namespace ConsoleApp10.Lesson5
{
    internal class Lada : Car
    {
        public Enum Color
        {
            get;
            private set; 
        }   

        public Lada(string name, Engene engeneCar, Enum color) : base(name, engeneCar)
        {
            Color = color;
        }

        public Lada()
        {

        }

        public override IMovable[] AddCar(IMovable[] movables)
        {
            IMovable[] newCarArray = base.AddCar(movables);
            Lada newCar = ((Lada)newCarArray[newCarArray.Length - 1]);
            Colors color = new Colors();
            Colors colorLada = InputColor(color);

            Console.WriteLine("Choose a color:");

            Lada newLada = new Lada(newCar.Name, new Engene(newCar.EngeneCar.HorsePower, newCar.EngeneCar.AccelerationTime), colorLada);

            newCarArray[newCarArray.Length - 1] = newLada;
            Console.Write($"You added: {newLada.GetType().Name} \r\n Name: {newCar.Name} \r\n Horse Power: {newCar.EngeneCar.HorsePower} \r\n Acceleration Time{newCar.EngeneCar.AccelerationTime} \r\n Colors: {Colors.Red}");
            Console.WriteLine();

            return newCarArray;
        }
    }
}
