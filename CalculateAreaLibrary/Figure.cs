namespace CalculateAreaLibrary
{
    public abstract class Figure
    {
        public string Name { get; protected init; }

        public double Area { get; protected init; }

        public double Perimeter { get; protected init; }
    }
}