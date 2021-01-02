using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Helpers
{
    public class NavigationHelper
    {
        public static Position GetPossibleRotateDirection(Position position, char moveInstruction)
        {
            var returnPosition = position;  // bunu kapatıp parametre position üstünden ilerlemeyi dene. Referans type. return.position.direction yerine position.direction yaz

            if (moveInstruction == (char)InstructionEnum.L)
            {
                switch (position.direction)
                {
                    case DirectionEnum.N:
                        returnPosition.direction = DirectionEnum.W;
                        break;
                    case DirectionEnum.S:
                        returnPosition.direction = DirectionEnum.E;
                        break;
                    case DirectionEnum.E:
                        returnPosition.direction = DirectionEnum.N;
                        break;
                    case DirectionEnum.W:
                        returnPosition.direction = DirectionEnum.S;
                        break;
                    default:
                        break;
                }
            }
            else if (moveInstruction == (char)InstructionEnum.R)
            {
                switch (position.direction)
                {
                    case DirectionEnum.N:
                        returnPosition.direction = DirectionEnum.E;
                        break;
                    case DirectionEnum.S:
                        returnPosition.direction = DirectionEnum.W;
                        break;
                    case DirectionEnum.E:
                        returnPosition.direction = DirectionEnum.S;
                        break;
                    case DirectionEnum.W:
                        returnPosition.direction = DirectionEnum.N;
                        break;
                    default:
                        break;
                }
            }
            else if (moveInstruction == (char)InstructionEnum.M)
            {
                switch (position.direction)
                {
                    case DirectionEnum.N:
                        returnPosition.Y += 1;
                        break;
                    case DirectionEnum.S:
                        returnPosition.Y -= 1;
                        break;
                    case DirectionEnum.E:
                        returnPosition.X += 1;
                        break;
                    case DirectionEnum.W:
                        returnPosition.X -= 1;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                // buraya geçersiz karakter uyarısı ver
            }
            return returnPosition;
        }
    }
}
