using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson3
{
    internal class Employee
    {
        uint _id = 0;
        float _salary = 0;
        public enum Vacancies
        {
            Assistant,
            Secretary,
            Manager,
            Security
        }
        public uint Id
        {
            get;
            private set;
        }
        public DateTime Date
        {
            get;
            private set;
        }
        public Vacancies EmployeeVacancies 
        {
            get;
            set;
        }
        public float Salary
        {
            set
            {
                if (value < 1 || value > 30000)
                    Console.WriteLine("Оклад должен быть в диапозоне от 1 до 30000");
                else
                    _salary = value;
            }
            get
            {
                return _salary;
            }
        }

        public Employee(uint id, float salary, DateTime date, Vacancies employeeVacancies)
        {
            Id = id;
            Salary = salary;
            Date = date;
            EmployeeVacancies = employeeVacancies;
        }
        public Employee(uint id)
        {
            Id = id;
        }
        public Employee(DateTime date)
        {
            Date = date;
        }
        public Employee(Vacancies employeeVacancies)
        {
            EmployeeVacancies = employeeVacancies;
        }
        public Employee(float salary)
        {
            Salary = salary;
        }

        public void SetId(uint id)
        {
            Id = id;
        }
        public void SetDate(DateTime date)
        {
            Date = date;
        }
        public void SetVacancies(Vacancies employeeVacancies)
        {
            EmployeeVacancies = employeeVacancies;
        }
        public void SetSalary(float salary)
        {
            Salary = salary;
        }
        public void Print()
        {
            Console.WriteLine("Задание 3");
            Console.WriteLine($"Номер ID {Id}");
            Console.WriteLine($"Оклад {Salary}");
            Console.WriteLine($"Дата приема на работу {Date}");
            Console.WriteLine($"Вакансия {EmployeeVacancies}");
            Console.WriteLine();
        }
    }
}
