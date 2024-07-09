using Shapes.Interfaces;

namespace Shapes.Figures;

public class Circle : IShape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius should be greater than zero");
        
        Radius = radius;
    }

    public double GetArea() => Math.PI * Math.Pow(Radius, 2);
}