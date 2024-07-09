using Shapes.Interfaces;

namespace Shapes.Factories;

public abstract class BaseShapeFactory : IShapeFactory
{
    public abstract IShape CreateShape(params double[] parameters);
}