namespace MarsRover.Domain
{
    public class Coordinate
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }
        public Coordinate(int xCoordinate, int yCoordinate)
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
        }
    }
}

