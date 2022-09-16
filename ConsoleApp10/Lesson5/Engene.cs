namespace ConsoleApp10.Lesson5
{
    internal class Engene
    {
        public uint HorsePower
        {
            get; 
            private set; 
        }

        public uint AccelerationTime
        {
            get;
            private set;
        }

        public Engene(uint horsePower, uint accelerationTime)
        {
            HorsePower = horsePower;
            AccelerationTime = accelerationTime;
        }
    }
}
