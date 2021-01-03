using MarsRover.Domain;
using MarsRover.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MarsRover
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Pleatue Size:");
            var pleateauSizeList = Console.ReadLine().Trim().Split(' ').ToList();

            if (pleateauSizeList.Count != 2)
            {
                Console.WriteLine("Pleateau size not valid");

                return;
            }

            var pleateauSize = new List<int>();

            foreach (var coordinate in pleateauSizeList) 
            {
                if (!int.TryParse(coordinate, out int parseCoordinate))
                {
                    Console.WriteLine("Your character is not integer");

                    return;
                }

                pleateauSize.Add(parseCoordinate);
            }

            Console.Write("Start position:");
            var startPositions = Console.ReadLine().Trim().Split(' ');
            Console.Write("Moves:");
            var moves = Console.ReadLine().ToUpper();

            var position = new Position();

            if (startPositions.Count() == 3)
            {
                position.X = Convert.ToInt32(startPositions[0].ToString());
                position.Y = Convert.ToInt32(startPositions[1].ToString());
                Direction direction;

                if (Enum.TryParse(startPositions[2], out direction))
                {
                    position.Direction = direction;
                }
                else
                {
                    Console.WriteLine("$Invalid Direction. Please enter N,E,W and S");

                    return;
                }
            }
            else
            {
                Console.WriteLine($"Invalid position");

                return;
            }

            foreach (var move in moves)
            {
                try
                {
                    position = NavigationHelper.GetPossibleRotateDirection(position, move);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    return;
                }
                
            }

            if (position.X < 0 || position.X > pleateauSize[0] || position.Y < 0 || position.Y > pleateauSize[1])
            {
                Console.WriteLine($"Position can not be beyond bounderies (0 , 0) and ({pleateauSize[0]} , {pleateauSize[1]})");

                return;
            }

            Console.WriteLine($"New Position: {position.X} {position.Y} {position.Direction.ToString()}");

            Console.ReadLine();

        }
    }
}
