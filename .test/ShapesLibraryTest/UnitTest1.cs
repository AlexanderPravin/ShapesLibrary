using Shapes.Factories;
using Shapes.Figures;
using Shapes.Interfaces;

namespace ShapesLibraryTest;

public class UnitTest1
{
    [Fact]
    public void TestCircleArea()
    {
        var radius = 5d;

        IShapeFactory factory = new CircleFactory();

        IShape circle = factory.CreateShape(radius);
        
        var expectedArea = Math.PI * Math.Pow(radius, 2);
        Assert.Equal(expectedArea, circle.GetArea(), 1e-10);
    }

    [Fact]
    public void TestTriangleArea()
    {
        var sideA = 3d;
        var sideB = 4d;
        var sideC = 5d;
        
        IShapeFactory factory = new TriangleFactory();

        var triangle = factory.CreateShape(sideA, sideB, sideC);
        
        var expectedArea = 6d;
        
        Assert.Equal(expectedArea, triangle.GetArea(), 1e-10);
    }

    [Fact]
    public void TestRightTriangle()
    {
        var sideA = 3d;
        var sideB = 4d;
        var sideC = 5d;

        IShapeFactory factory = new TriangleFactory();
        
        var triangle = (Triangle)factory.CreateShape(sideA, sideB, sideC);
        
        Assert.True(triangle.IsRight());
    }
    
    [Fact]
    public void TestNotRightTriangle()
    {
        var sideA = 3d;
        var sideB = 4d;
        var sideC = 6d;

        IShapeFactory factory = new TriangleFactory();
        
        var triangle = (Triangle)factory.CreateShape(sideA, sideB, sideC);
        
        Assert.False(triangle.IsRight());
    }
    
    [Fact]
    public void TestWrongTriangle()
    {
        var sideA = 1d;
        var sideB = 2d;
        var sideC = 3d;

        IShapeFactory factory = new TriangleFactory();
        
        Assert.Throws<ArgumentException>(() => factory.CreateShape(sideA, sideB, sideC));
    }
    
    [Fact]
    public void TestWrongRadius()
    {
        var radius = -1d;

        IShapeFactory factory = new CircleFactory();
        
        Assert.Throws<ArgumentException>(() => factory.CreateShape(radius));
    }
    
    [Fact]
    public void TestWrongSide()
    {
        var sideA = -1d;
        var sideB = 2d;
        var sideC = 3d;

        IShapeFactory factory = new TriangleFactory();
        
        Assert.Throws<ArgumentException>(() => factory.CreateShape(sideA, sideB, sideC));
    }
}