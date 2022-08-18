using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson3
{
    public class Animal
    {
        public enum Kind
        {
            Лев,
            Тигр,
            Слон,
            Обезьяна,
            Ягуар
        }

        public uint Price
        {
            get;
            set;
        }
        public Kind KindAnimal
        {
            get;
            set;
        }
        public int Quantity
        {
            get;
            set;
        }

        public Animal(uint price, int quantity, Kind kindAnimal)
        {
            Price = price;
            Quantity = quantity;
            KindAnimal = kindAnimal;
        }
        public Animal(uint price)
        {
            Price = price;
        }
        public Animal(int quantity)
        {
            Quantity = quantity;
        }
        public Animal(Kind kindAnimal)
        {
            KindAnimal = kindAnimal;
        }

        public void SetPrice(uint price)
        {
            Price = price;
        }
        public void SetQuantity(int quantity)
        {
            Quantity = quantity;
        }
        public void SetViewAnimal(Kind kindAnimal)
        {
            KindAnimal = kindAnimal;
        }

        public static void PrintAnimals(Animal[] animals, string message)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"{message} {animal.KindAnimal}");
            }
        }

        public static Animal[] GetAninimalForKeyboard()
        {
            Console.WriteLine("Задание 4");
            Console.Write("Введите количество животных: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Animal[] animals = new Animal[num];

            for (int j = 0; j < num; j++)
            {
                var i = 1;
                foreach (var item in Enum.GetValues(typeof(Kind)))
                {
                    Console.WriteLine($"{i} - {item}");
                    i++;
                }
                Console.WriteLine();
                Console.Write("Выбирите животное: ");
                var numberAnimal = Console.ReadLine();
                var isNumber = int.TryParse(numberAnimal, out int number);

                while (!isNumber || number <= 0 || number > Enum.GetValues(typeof(Kind)).Length)
                {
                    Console.WriteLine("Ввод принимает только положительное число!");
                    Console.Write("Выбирите животное: ");
                    isNumber = int.TryParse(Console.ReadLine(), out number);
                }

                Console.Write("Введите цену: ");
                var priceAnimal = Console.ReadLine();
                var isPrice = uint.TryParse(priceAnimal, out uint price);
                while (!isPrice || price == 0)
                {
                    Console.WriteLine("Ввод принимает только положительное число!");
                    Console.Write("Введите цену: ");
                    priceAnimal = Console.ReadLine();
                    isPrice = uint.TryParse(priceAnimal, out price);
                }

                Console.Write("Введите количество: ");
                var quantityAnimal = Console.ReadLine();
                var isQuantity = int.TryParse(quantityAnimal, out int quantity);

                while (!isQuantity || quantity <= 0)
                {
                    Console.WriteLine("Ввод принимает только положительное число!");
                    Console.Write("Введите количество: ");
                    quantityAnimal = Console.ReadLine();
                    isQuantity = int.TryParse(Console.ReadLine(), out quantity);
                }


                animals[j] = new Animal(price, quantity, (Kind)number - 1);
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine($"{animals[j].KindAnimal}, Количество: {animals[j].Quantity}, Цена: {animals[j].Price} -- ГОТОВО!");
                Console.WriteLine("-------------------------------------------------------");
                Console.WriteLine();
            }

            Console.WriteLine("Вы добавили животных:");
            PrintAnimals(animals, "");

            return animals;
        }
    }
}
