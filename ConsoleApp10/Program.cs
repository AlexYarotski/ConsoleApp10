using ConsoleApp10;
using ConsoleApp10.Lesson3;
using ConsoleApp10.Lesson5;

namespace MyApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //var point1 = new Point(2, 1);
            //var point2 = new Point(2, 3);
            //var point3 = new Point(2, 4);
            //var amount = Point.counter;
            //var print1 = new Point(2, 3);
            //print1.Print();

            //var circle1 = new Circle();
            //circle1.Radius = 4;
            //var circle2 = new Circle(5);
            //var print2 = new Circle(5);
            //print2.Print();

            //var employee = new Employee(2132, 232, new DateTime(2016, 02, 02), Employee.Vacancies.Security);
            //employee.Print();
            //employee.SetId(32);
            //employee.SetSalary(28500);
            //employee.SetDate(new DateTime(2017, 09, 09));
            //employee.SetVacancies(Employee.Vacancies.Assistant);
            //employee.Print();

            //var shoes = new Shoes(Colors.Blue);
            //var clothes = new Clothes(Colors.Green);
            //var human = new Human(shoes, clothes);
            //human.PrintOutfit();

            //var animalArray = Animal.GetAninimalFromKeyboard();
            //Console.WriteLine();
            //var zooMarket = new ZooMarket(animalArray);
            //zooMarket.MostExpensiveAnimal();
            //zooMarket.AddAnimal(new Animal[] { new Animal(60, 9, Kind.Ягуар), new Animal(60, 9, Kind.Слон) });
            ////zooMarket.AnimalSearch(Kind.Обезьяна);
            //zooMarket.AnimalsByQuantity();
            //zooMarket.DeleteAnimalByKind(Kind.Лев);

            //Animal cat = new Cat(22, 11, 7);
            //Animal dog = new Dog(44, 32, true);

            //Console.WriteLine(cat.Price);
            //cat.MakeSound();
            //Console.WriteLine(dog.Price);
            //dog.MakeSound();

            //var array1 = new int[3, 3];
            //var matrix1 = new Matrix(array1);
            //matrix1.GetRandomArray();
            //var array2 = new int[3, 4];
            //var matrix2 = new Matrix(array2);
            //matrix2.GetRandomArray();
            //matrix1.MultiplayArray(matrix2.ArrayMatrix);

            //var sort = new Sort();
            //var arraySort = sort.GetRandomArray(5);
            //sort.BubbleSort(arraySort);

            //var trapezoid = new EquilateralTrapezoid();
            //var trapezoids = new EquilateralTrapezoid[]
            //{
            //        new EquilateralTrapezoid (new Point(1,1), new Point(2,3), new Point(4, 3), new Point(5, 1)),
            //        new EquilateralTrapezoid (new Point(1,2), new Point(0,5), new Point(5, 5), new Point(4, 2)),
            //        new EquilateralTrapezoid (new Point(3,1), new Point(1,6), new Point(7, 6), new Point(5, 1)),
            //        new EquilateralTrapezoid (new Point(2,3), new Point(4,5), new Point(7, 5), new Point(8, 3)),
            //        new EquilateralTrapezoid (new Point(2,3), new Point(1,7), new Point(8, 7), new Point(5, 3)),
            //};
            //var isEquilateralTrapezoid = trapezoid.IsEquilateralTrapezoid(trapezoids[0]);
            //var perimeter = trapezoid.GetPerimeter(new Point[] { trapezoids[0].Point1, trapezoids[0].Point2, trapezoids[0].Point3, trapezoids[0].Point4 });
            //Console.WriteLine(isEquilateralTrapezoid ? "Трапеция является равнобедренной" : "Трапеция не является равнобедренной");
            //Console.WriteLine($"Периметер трапеции равен: {perimeter}");
            //var count = EquilateralTrapezoid.GetTrapezoidsNumberWithSquareMoreThanAverage(trapezoids);

            //Animal kity = new Cat("Meat", "Home", "острые");
            //kity.MakeNoise();
            //kity.Eat();

            //Dog snoopy = new Dog("Bone", "Booth", 5);
            //snoopy.MakeNoise();

            //Veterinarian vet = new Veterinarian();
            //vet.TreatAnimal(kity);

            //var vetArray = new Veterinarian();
            //vetArray.Animals = new Animal[] { new Cat("Meat", "Home", ""), new Dog("Bone", "Booth", 4), new Horse("Hay", "Barn", 6) };

            //for (int i = 0; i < vet.Animals.Length; i++)
            //{
            //    vet.TreatAnimal(vet.Animals[i]);
            //}

            Bmw bmw1 = new Bmw("M5", new Engene(1), "Blue");
            Bmw bmw2 = new Bmw("M5", new Engene(3), "Blue");
            Bmw bmw3 = new Bmw("M5", new Engene(4), "Blue");
            Lada lada1 = new Lada("Vesta", new Engene(2), "Red");
            Lada lada2 = new Lada("Vesta", new Engene(5), "Red");
            Lada lada3 = new Lada("Vesta", new Engene(3), "Red");

            Race race = new Race();
            var movebles = await race.StartRace(new Car[] { bmw1, bmw2, bmw3, lada1, lada2, lada3 }, 0.2f);

            for (int i = 0; i < movebles.Length; i++)
            {
                Console.WriteLine(movebles[i].GetType().Name);
            }
        }
        
    }
}
