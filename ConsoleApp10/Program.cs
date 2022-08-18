using ConsoleApp10;
using ConsoleApp10.Lesson3;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var point1 = new Point(2, 1);
            var point2 = new Point(2, 3);
            var point3 = new Point(2, 4);
            var amount = Point.counter;
            var print1 = new Point(2, 3);
            print1.Print();

            var circle1 = new Circle();
            circle1.Radius = 4;
            var circle2 = new Circle(5);
            var print2 = new Circle(5);
            print2.Print();

            var employee = new Employee(2132, 232, new DateTime(2016, 02, 02), Employee.Vacancies.Security);
            employee.Print();
            employee.SetId(32);
            employee.SetSalary(28500);
            employee.SetDate(new DateTime(2017, 09, 09));
            employee.SetVacancies(Employee.Vacancies.Assistant);
            employee.Print();
            //var shoes = new Shoes(Colors.Blue);
            //var clothes = new Clothes(Colors.Green);
            //var human = new Human(shoes, clothes);
            //human.PrintOutfit();

            Animal[] animalArray = new Animal[] 
            { 
                new Animal(320,1,Animal.Kind.Lion), 
                new Animal(600, 2, Animal.Kind.Monkey),
                new Animal(55, 3, Animal.Kind.Elephant), 
                new Animal(342, 4, Animal.Kind.Lion),
                new Animal(60, 4, Animal.Kind.Elephant),
                new Animal(12, 4, Animal.Kind.Jaguar),
                new Animal(357, 4, Animal.Kind.Tiger),
                new Animal(1003, 4, Animal.Kind.Monkey),
                new Animal(63, 4, Animal.Kind.Lion)
            };
            var zooMarket = new ZooMarket(animalArray);
            //var deleteZooMarket = zooMarket.DeleteAnimal(Animal.Kind.Lion);
            //zooMarket.AddAnimal(new Animal[] {new Animal(60, 9, Animal.Kind.Tiger)});
            var mostExpensiveAnimal = zooMarket.RichAnimal();
        }
    }
}
