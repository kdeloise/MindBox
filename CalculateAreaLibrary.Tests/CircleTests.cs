using System;
using FluentAssertions;
using FluentAssertions.Extensions;
using Xunit;

namespace CalculateAreaLibrary.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(1, 3.1416)]
        [InlineData(2, 12.5664)]
        [InlineData(3, 28.2743)]
        [InlineData(4, 50.2655)]
        [InlineData(5, 78.5398)]
        [InlineData(6, 113.0973)]
        [InlineData(7, 153.938)]
        [InlineData(8, 201.0619)]
        [InlineData(9, 254.469)]
        public void CalculateArea(double radius, double expected)
        {
            //Arrange
            var circle = new Circle(radius);
            
            //Act
            var result = Math.Round(circle.CalculateArea(), 4, MidpointRounding.AwayFromZero);

            //Assert
            result.Should().Be(expected);
        }
        
        [Theory]
        [InlineData(1, 6.28319)]
        [InlineData(2, 12.56637)]
        [InlineData(3, 18.84956)]
        [InlineData(4, 25.13274)]
        [InlineData(5, 31.41593)]
        [InlineData(6, 37.69911)]
        [InlineData(7, 43.9823)]
        [InlineData(8, 50.26548)]
        [InlineData(9, 56.54867)]
        public void CalculatePerimeter(double radius, double expected)
        {
            //Arrange
            var circle = new Circle(radius);
            
            //Act
            var result = Math.Round(circle.CalculatePerimeter(), 5, MidpointRounding.AwayFromZero);

            //Assert
            result.Should().Be(expected);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void InvalidArgumentsConstructorExceptionTest(int radius)
        {
            //Arrange
            
            
            //Act
            Action act = () =>
            {
                var circle = new Circle(radius);
            };
            
            //Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Radius of the circle must be greater than 0");
        }
        
    }
}