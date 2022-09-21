namespace ConsoleApp10.Lesson5
{
    internal class Engene
    {
        public int HorsePower
        {
            get; 
            set; 
        }

        public int AccelerationTime
        {
            get;
            set;
        }

        public Engene(int horsePower, int accelerationTime)
        {
            HorsePower = horsePower;
            AccelerationTime = accelerationTime;
        }

        public Engene()
        {

        }
    }
}
