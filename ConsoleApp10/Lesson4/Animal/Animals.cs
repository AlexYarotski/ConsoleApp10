namespace ConsoleApp10.Lesson4.Animal
{
    internal abstract class Animal
    {
        public string Food 
        {
            get;
            private set;
        }

        public string Location 
        {
            get;
            private set;
        }

        public Animal(string food, string location)
        {
            Food = food;
            Location = location;
        }

        public Animal()
        {

        }

        public virtual void MakeNoise()
        {

        }

        public virtual void Eat()
        {
            
        }

        public virtual void Sleep()
        {
            
        }
    }
}
