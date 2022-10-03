namespace ConsoleApp10.Lesson5
{
    internal class Engine
    {
        public int HorsePower
        {
            get; 
            private set; 
        }

        public int AccelerationTime
        {
            get;
            private set;
        }

        public Engine(int horsePower, int accelerationTime)
        {
            HorsePower = horsePower;
            AccelerationTime = accelerationTime;
        }
    }
}
