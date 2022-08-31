namespace ConsoleApp10.Lesson4.Student
{
    internal class Student : User
    {
        public uint Years 
        { 
            get;
            private set; 
        }

        public Student(string name, string surName, uint years) : base(name, surName)
        {
            if (years < (uint)DateTime.Now.Year)
            {
                Years = years;
            }
            else
            Console.WriteLine("Неверный год");
        }

        public uint GetCourse()
        {
            const int invalidInput = 7;
            return Math.Clamp((uint)DateTime.Now.Year - Years, 0, invalidInput);
        }
    }
}
