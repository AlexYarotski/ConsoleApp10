namespace ConsoleApp10.Lesson5
{
    internal abstract class Car
    {
        Engene EngeneCar;

        public string Name
        {
            get;
            set;
        }

        public Car(string name, Engene engeneCar)
        {
            Name = name;
            EngeneCar = engeneCar;
        }
    }
}
