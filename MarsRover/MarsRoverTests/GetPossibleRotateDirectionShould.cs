using System;
using Xunit;
using MarsRover.Domain;
using MarsRover.Helpers;

namespace MarsRoverTests
{
    public class GetPossibleRotateDirectionShould
    {
        [Theory]
        [InlineData("1 2 N", "LMLMLMLMM", "1 3 N")]
        [InlineData("3 3 E", "MMRMMRMRRM", "5 1 E")]
        public void ReturnValidPossibleRotatePosition(string startPosition, string moves, string expected)
        {
            //Arrange
            var position = new Position();

            if (startPosition.Length == 5)
            {
                position.X = Convert.ToInt32(startPosition[0].ToString());
                position.Y = Convert.ToInt32(startPosition[2].ToString());
                position.Direction = (Direction)Enum.Parse(typeof(Direction), startPosition[4].ToString());
            }

            // Act
            Position actual = new Position();
            foreach (var move in moves)
            {
                actual = NavigationHelper.GetPossibleRotateDirection(position, move);
            }

            // Assert
            var expectedPosition = new Position();

            if (expected.Length == 5)
            {
                expectedPosition.X = Convert.ToInt32(expected[0].ToString());
                expectedPosition.Y = Convert.ToInt32(expected[2].ToString());
                expectedPosition.Direction = (Direction)Enum.Parse(typeof(Direction), expected[4].ToString());
            }
            Assert.Equal(expectedPosition.X, actual.X);
            Assert.Equal(expectedPosition.Y, actual.Y);
            Assert.Equal(expectedPosition.Direction, actual.Direction);
        }

    }
}
