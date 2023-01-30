using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculateAreaLibrary
{
    public class Triangle : Figure, ICalculate
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new ArgumentException("Each side of the triangle must be greater than 0");
            if (!(a + b > c) || !(a + c > b) || !(b + c > a))
                throw new ArgumentException("Side proportions are invalid for a triangle");
            _a = a;
            _b = b;
            _c = c;
            IsRightTriangle = CheckRightTriangle();
            Name = "Triangle";
            Perimeter = CalculatePerimeter();
            Area = CalculateArea();
        }
        
        public bool IsRightTriangle { get; }

        private bool CheckRightTriangle()
        {
            var a = new List<double>() { _a, _b, _c };
            var max = a.Max();
            
            a.Remove(max);
            return Math.Abs(Math.Pow(max, 2) - a.Aggregate((x, y) => Math.Pow(x, 2) + Math.Pow(y, 2))) < 0.000001;
        }

        public double CalculatePerimeter()
        {
            return _a + _b + _c;
        }
        
        public double CalculateArea()
        {
            var p = CalculatePerimeter() / 2;
            
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }
    }
}