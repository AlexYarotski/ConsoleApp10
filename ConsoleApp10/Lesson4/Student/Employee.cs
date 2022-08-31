namespace ConsoleApp10.Lesson4.Student
{
    internal class Employee : User
    {
        public double Salary 
        {
            get;
        }

        public Position PositionHuman
        {
            get;
        }

        public Employee(string name, string surName, Position position) : base(name, surName)
        {
            Salary = EmployeeConfig.GetSalaryByPosition(position);
            PositionHuman = position;
        }

        public uint GetSalaryByMonths(uint salary, uint months)
        {
            return  salary * months;
        }

    }
}
