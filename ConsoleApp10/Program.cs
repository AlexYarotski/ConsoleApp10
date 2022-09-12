using ConsoleApp10;
using ConsoleApp10.Lesson3;
using ConsoleApp10.Lesson3.Lesson4;

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

            var matrix1 = new Matrix(new int[2, 3]);
            var matrix2 = new Matrix(new int[2, 3]);
            matrix1.GetRandomArray();
            matrix2.GetRandomArray();
            var matrix3 = new Matrix(new int[2, 3]);
            matrix3.SumArray(matrix1.ArrayMatrix, matrix2.ArrayMatrix);
            matrix3.MultiplayArray(matrix1.ArrayMatrix, matrix2.ArrayMatrix);
            Console.Write("Введите число: ");
            matrix3.MultiplayArrayByNumber(matrix1.ArrayMatrix, Convert.ToInt32(Console.ReadLine()));
        }
    }
}
