using System;
using System.Linq;
using MarsRover.Helpers;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pleatue Size:");
            var pleateauSize = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();
            Console.Write("Start position:");
            var startPositions = Console.ReadLine().Trim().Split(' ');
            Console.Write("Moves:");
            var moves = Console.ReadLine().ToUpper();

            var position = new Position();

            if (startPositions.Count() == 3)
            {
                position.X = Convert.ToInt32(startPositions[0]);
                position.Y = Convert.ToInt32(startPositions[1]);
                position.direction = (DirectionEnum)Enum.Parse(typeof(DirectionEnum), startPositions[2]);
            }

            foreach (var move in moves)
            {
                position = NavigationHelper.GetPossibleRotateDirection(position, move);
            }

            if (position.X < 0 || position.X > pleateauSize[0] || position.Y < 0 || position.Y > pleateauSize[1])
            {
                throw new Exception($"Position can not be beyond bounderies (0 , 0) and ({pleateauSize[0]} , {pleateauSize[1]})");
            }

            Console.WriteLine($"New Position: {position.X} {position.Y} {position.direction.ToString()}");

            Console.ReadLine();

        }
    }
}
