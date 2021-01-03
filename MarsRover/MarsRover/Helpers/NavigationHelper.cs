using MarsRover.Domain;
using System;

namespace MarsRover.Helpers
{
    public class NavigationHelper
    {
        public static Position GetPossibleRotateDirection(Position position, char moveInstruction)
        {

            if (moveInstruction == (char)Instruction.L)
            {
                switch (position.Direction)
                {
                    case Direction.N:
                        position.Direction = Direction.W;
                        break;
                    case Direction.S:
                        position.Direction = Direction.E;
                        break;
                    case Direction.E:
                        position.Direction = Direction.N;
                        break;
                    case Direction.W:
                        position.Direction = Direction.S;
                        break;
                    default:
                        break;
                }
            }
            else if (moveInstruction == (char)Instruction.R)
            {
                switch (position.Direction)
                {
                    case Direction.N:
                        position.Direction = Direction.E;
                        break;
                    case Direction.S:
                        position.Direction = Direction.W;
                        break;
                    case Direction.E:
                        position.Direction = Direction.S;
                        break;
                    case Direction.W:
                        position.Direction = Direction.N;
                        break;
                    default:
                        break;
                }
            }
            else if (moveInstruction == (char)Instruction.M)
            {
                switch (position.Direction)
                {
                    case Direction.N:
                        position.Y += 1;
                        break;
                    case Direction.S:
                        position.Y -= 1;
                        break;
                    case Direction.E:
                        position.X += 1;
                        break;
                    case Direction.W:
                        position.X -= 1;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                throw new Exception("Invalid Character. Please enter L, R or M.");                
            }
            return position;
        }
    }
}
