using Shapes.Figures;
using Shapes.Interfaces;

namespace Shapes.Factories;

public class TriangleFactory : BaseShapeFactory
{
    public override IShape CreateShape(params double[] parameters)
    {
        if(parameters.Length != 3)
            throw new ArgumentException("Triangle should have three parameters - 3 sides lengths");

        return new Triangle(parameters[0], parameters[1], parameters[2]);
    }
}