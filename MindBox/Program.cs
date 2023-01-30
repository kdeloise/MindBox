using System;
using CalculateAreaLibrary;

namespace MindBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(3, 4, 5);
            var circle = new Circle(-3);
            
            // var rigthTriangle = triangle.IsRightTriangle;
            // var areaTriangle = triangle.CalculateArea();
            // var perimetrTriangle = triangle.CalculatePerimeter();
            //
            // var areaCircle = circle.CalculateArea();
            // var perimetrCircle = circle.CalculatePerimeter();
            
            
            Console.WriteLine($"{triangle.Name}  RightTriangle: {triangle.IsRightTriangle}," +
                              $" Perimeter: {triangle.Perimeter}, Area: {triangle.Area:f4}");
            Console.WriteLine($"{circle.Name}  " +
                              $"Perimeter: {circle.Perimeter}, Area: {circle.Area:f4}");
        }
    }
}