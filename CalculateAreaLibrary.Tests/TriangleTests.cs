using System;
using FluentAssertions;
using Xunit;

namespace CalculateAreaLibrary.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(1, 2, 2.9, 0.5227)]
        [InlineData(3, 4, 5, 6)]
        [InlineData(4.9762, 1.246, 4.3, 2.405)]
        
        public void CalculateArea(double a, double b, double c, double expected)
        {
            //Arrange
            var triangle = new Triangle(a, b, c);
            
            //Act
            var result = Math.Round(triangle.CalculateArea(), 4, MidpointRounding.AwayFromZero);

            //Assert
            result.Should().Be(expected);
            Math.Round(triangle.Area, 4, MidpointRounding.AwayFromZero).Should().Be(expected);
        }
        
        [Theory]
        [InlineData(3, 4, 5, 12)]
        [InlineData(4.9762, 1.246, 4.3, 10.5222)]
        public void CalculatePerimeter(double a, double b, double c, double expected)
        {
            //Arrange
            var triangle = new Triangle(a, b, c);
            
            //Act
            var result =  Math.Round(triangle.CalculatePerimeter(), 4, MidpointRounding.AwayFromZero);

            //Assert
            result.Should().Be(expected);
            Math.Round(triangle.Perimeter, 4, MidpointRounding.AwayFromZero).Should().Be(expected);
        }
        
        [Theory]
        [InlineData(15, 4, 3)]
        [InlineData(15, 6, 8)]
        [InlineData(15, 6, 9)]
        public void InvalidArgumentsSideProportionsInConstructorExceptionTest(double a, double b, double c)
        {
            //Arrange
            
            
            //Act
            Action act = () =>
            {
                var triangle = new Triangle(a, b, c);
            };
            

            //Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Side proportions are invalid for a triangle");
        }
        
        [Theory]
        [InlineData(-4, 4, 3)]
        [InlineData(4, -5, 3)]
        [InlineData(4, 2, -5)]
        [InlineData(0, 4, 3)]
        [InlineData(4, 0, 3)]
        [InlineData(4, 2, 0)]
        public void InvalidArgumentsNegativeOrZeroInConstructorExceptionTest(double a, double b, double c)
        {
            //Arrange
            
            
            //Act
            Action act = () =>
            {
                var triangle = new Triangle(a, b, c);
            };
            

            //Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Each side of the triangle must be greater than 0");
        }
        
        [Theory]
        [InlineData(3, 4, 5)]
        public void CheckRightTriangleTrueTest(double a, double b, double c)
        {
            //Arrange
            var triangle = new Triangle(a, b, c);
            
            //Act
            var result = triangle.IsRightTriangle;
            

            //Assert
            result.Should().Be(true);
        }
        
        [Theory]
        [InlineData(3, 5, 5)]
        public void CheckRightTriangleFalseTest(double a, double b, double c)
        {
            //Arrange
            var triangle = new Triangle(a, b, c);
            
            //Act
            var result = triangle.IsRightTriangle;

            //Assert
            result.Should().Be(false);
        }
    }
}