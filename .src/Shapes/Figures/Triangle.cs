using Shapes.Interfaces;

namespace Shapes.Figures;

public class Triangle : IShape
{
    private const double Tolerance = 1e-10;
    
    public double SideA { get; } 

    public double SideB { get; }

    public double SideC { get; }
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA < 0 || sideB < 0 || sideC < 0)
            throw new ArgumentException("Sides must be greater than 0");
        
        var isCorrect = sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
        
        if(!isCorrect)
            throw new ArgumentException("Triangle with such sides does not exist");
        
                        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    public double GetArea()
    {
        var s = (SideA + SideB + SideC) / 2;
        
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsRight()
    {
        if (SideA > SideB && SideA > SideC)
            return Math.Abs(Math.Pow(SideA, 2) - (Math.Pow(SideB, 2) + Math.Pow(SideC, 2))) < Tolerance;
        if (SideB > SideA && SideB > SideC)
            return Math.Abs(Math.Pow(SideB, 2) - (Math.Pow(SideA, 2) + Math.Pow(SideC, 2))) < Tolerance;
        
        return Math.Abs(Math.Pow(SideC, 2) - (Math.Pow(SideB, 2) + Math.Pow(SideA, 2))) < Tolerance;
    }
}