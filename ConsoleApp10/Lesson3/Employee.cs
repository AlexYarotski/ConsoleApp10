using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10.Lesson3
{
    internal class Employee
    {
        uint id = 0;
        float salary = 0;

        public uint Id 
        { 
            get; 
            private set; 
        }
        public Employee(uint id)
        {
            Id = id;
        }
        public void SetId(uint id)
        {
            Id = id;
        }

        public DateTime Date 
        {
            get;
            private set; 
        }
        public Employee(DateTime date)
        {
            Date = date;
        }
        public void SetDate(DateTime date)
        {
            Date=date;
        }

        public Vacancies EmployeeVacancies 
        {
            get;
            set;
        }
        public Employee(Vacancies employeeVacancies)
        {
            EmployeeVacancies = employeeVacancies;
        }
        public void SetVacancies(Vacancies employeeVacancies)
        {
            EmployeeVacancies = employeeVacancies;
        }

        public float Salary
        {
            set
            {
                if (value < 1 || value > 30000)
                    Console.WriteLine("Оклад должен быть в диапозоне от 1 до 30000");
                else
                    salary = value;
            }
            get
            {
                return salary;
            }
        }
        public Employee(float salary)
        {
            Salary = salary;
        }
        public void SetSalary(float salary)
        {
            Salary = salary;
        }
        public Employee(uint id, float salary,DateTime date, Vacancies employeeVacancies)
        {
            Id = id;
            Salary = salary;
            Date = date;
            EmployeeVacancies = employeeVacancies;
        }

        public enum Vacancies
        {
            Assistant,
            Secretary,
            Manager,
            Security
        }

        public void Print()
        {
            Console.WriteLine("Занятие 3");
            Console.WriteLine($"Номер ID {Id}");
            Console.WriteLine($"Оклад {Salary}");
            Console.WriteLine($"Дата приема на работу {Date}");
            Console.WriteLine($"Вакансия {EmployeeVacancies}");
            Console.WriteLine();
        }
    }
}
