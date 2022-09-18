namespace ConsoleApp10.Lesson5
{
    internal class Engene
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

        public Engene(int horsePower, int accelerationTime)
        {
            HorsePower = horsePower;
            AccelerationTime = accelerationTime;
        }
    }
}
