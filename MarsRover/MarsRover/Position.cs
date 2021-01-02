using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
        public DirectionEnum direction { get; set; }

        public Position(int X, int Y, DirectionEnum direction)
        {
            this.X = X;
            this.Y = Y;
            this.direction = direction;
        }

        public Position()
        {
            X = Y = 0;
            direction = DirectionEnum.N;
        }
    }
}
