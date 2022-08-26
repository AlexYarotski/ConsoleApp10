namespace ConsoleApp10.Lesson3.Lesson3Animal
{
    public class Dog : Animal
    {
        private bool _isGoodBoy = false;

        public override Kind KindAnimal => Kind.Собака;

        public Dog(uint price, int count, bool isGoodBoy) : base(price, count)
        {
           _isGoodBoy = isGoodBoy;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Gaf");
            Console.WriteLine($"Хороший мальчик? {_isGoodBoy}");
        }
    }

    public class Cat : Animal
    {

        private uint _lifeCount = 0;

        public override Kind KindAnimal => Kind.кот;

        public Cat (uint price, int count, uint lifeCount): base(price, count)
        {
            _lifeCount = lifeCount;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Miu");
            Console.WriteLine($"Количество жизней: {_lifeCount}");
        }
    }
    public abstract class Animal
    {
        public uint Price
        {
            get;
            private set;
        }

        public abstract Kind KindAnimal
        {
            get;
        }

        public int Quantity
        {
            get;
            internal set;
        }

        public Animal(uint price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        public abstract void MakeSound();

        public void SetPrice(uint price)
        {
            Price = price;
        }

        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }

            

        public static void PrintAnimals(Animal[] animals, string message)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine($"{message} {animals[i].KindAnimal}");

            }
        }

        //public static Animal[] GetAninimalFromKeyboard()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("Задание 4");
        //    Console.Write("Введите количество животных: ");
        //    int num = Convert.ToInt32(Console.ReadLine());

        //    Animal[] animals = new Animal[num];

        //    for (int j = 0; j < num; j++)
        //    {
        //        var i = 1;
        //        foreach (var item in Enum.GetValues(typeof(Kind)))
        //        {
        //            Console.WriteLine($"{i} - {item}");
        //            i++;
        //        }
        //        Console.WriteLine();
        //        Console.Write("Выбирите животное: ");
        //        var numberAnimal = Console.ReadLine();
        //        var isNumber = int.TryParse(numberAnimal, out int number);

        //        while (!isNumber || number <= 0 || number > Enum.GetValues(typeof(Kind)).Length)
        //        {
        //            Console.WriteLine("Ввод принимает только числа от 1 до 5!");
        //            Console.Write("Выбирите животное: ");
        //            isNumber = int.TryParse(Console.ReadLine(), out number);
        //        }

        //        Console.Write("Введите цену: ");
        //        var priceAnimal = Console.ReadLine();
        //        var isPrice = uint.TryParse(priceAnimal, out uint price);
        //        while (!isPrice || price == 0)
        //        {
        //            Console.WriteLine("Ввод принимает только положительное число!");
        //            Console.Write("Введите цену: ");
        //            priceAnimal = Console.ReadLine();
        //            isPrice = uint.TryParse(priceAnimal, out price);
        //        }

        //        Console.Write("Введите количество: ");
        //        var quantityAnimal = Console.ReadLine();
        //        var isQuantity = int.TryParse(quantityAnimal, out int quantity);

        //        while (!isQuantity || quantity <= 0)
        //        {
        //            Console.WriteLine("Ввод принимает только положительное число!");
        //            Console.Write("Введите количество: ");
        //            quantityAnimal = Console.ReadLine();
        //            isQuantity = int.TryParse(Console.ReadLine(), out quantity);
        //        }

        //        animals[j] = new Animal(price, quantity, (Kind)number - 1);
        //        Console.WriteLine();
        //        Console.WriteLine("-------------------------------------------------------");
        //        Console.WriteLine($"{animals[j].KindAnimal}, Количество: {animals[j].Quantity}, Цена: {animals[j].Price} -- ГОТОВО!");
        //        Console.WriteLine("-------------------------------------------------------");
        //        Console.WriteLine();
        //    }

        //    Console.WriteLine("Вы добавили животных:");
        //    PrintAnimals(animals, "");

        //    return animals;
        //}
    }
}
