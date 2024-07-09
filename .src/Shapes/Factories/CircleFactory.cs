using Shapes.Figures;
using Shapes.Interfaces;

namespace Shapes.Factories;

public class CircleFactory : BaseShapeFactory
{
    public override IShape CreateShape(params double[] parameters)
    {
        if(parameters.Length != 1)
            throw new ArgumentException("Circle should have only one parameter - radius");

        return new Circle(parameters[0]);
    }
}