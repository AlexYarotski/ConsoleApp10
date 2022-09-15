namespace ConsoleApp10.Lesson4.Student
{
    internal static class EmployeeConfig 
    {
        private const double _tarif = 1000;

        public static double GetSalaryByPosition(this Position position)
        {
            return position switch
            {
                Position.Driver => _tarif * 0.8,
                Position.Programmer => _tarif * 2,
                Position.Director => _tarif * 1.6,
                Position.Cashier => _tarif * 1,
                Position.Pilot => _tarif * 1.8,
                _ => 0,
            };
        }
    }
}
