namespace ConsoleApp10.Lesson5
{
    internal class Engene : IMovable
    {
        public uint Horse
        {
            get; 
            private set; 
        }

        public Engene( uint horse) 
        {
            Horse = horse;
        }

        public uint GetMoveDistance(uint time)
        {
            return time * Horse;
        }
    }
}
