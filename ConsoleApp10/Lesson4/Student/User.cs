namespace ConsoleApp10.Lesson4.Student
{
    public abstract class User
    {
        public string Name 
        {
            get;
            private set;
        }
        public string SurName
        {
            get;
            private set;
        }

        public string FullName
        {
            get => $"{Name} {SurName}";
        }

        public User (string name, string surName)
        {
            Name = name;
            SurName = surName;
        }

        public void GetFullName()
        {
            Console.WriteLine(FullName);
        }
    }
}
