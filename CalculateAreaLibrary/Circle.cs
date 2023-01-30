using System;

namespace CalculateAreaLibrary
{
    public class Circle : Figure, ICalculate
    {
        private double _r;

        public Circle(double r)
        {
            if (r <= 0)
                throw new ArgumentException("Radius of the circle must be greater than 0");
            _r = r;
            Name = "Circle";
            Perimeter = CalculatePerimeter();
            Area = CalculateArea();
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * _r;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_r, 2);
        }
    }
}