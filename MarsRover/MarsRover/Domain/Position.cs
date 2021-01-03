namespace MarsRover.Domain
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Direction Direction { get; set; }

        public Position(int X, int Y, Direction direction)
        {
            this.X = X;
            this.Y = Y;
            this.Direction = direction;
        }

        public Position()
        {
            X = Y = 0;
            Direction = Direction.N;
        }
    }
}
