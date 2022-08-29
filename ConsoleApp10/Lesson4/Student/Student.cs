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
            Years = years;
        }

        public uint GetCourse()
        {
            var course =  Math.Clamp((uint)DateTime.Now.Year - Years, 0, 7);

            return course;
        }
    }
}
