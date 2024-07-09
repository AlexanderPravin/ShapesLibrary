using Shapes.Figures;
using Shapes.Interfaces;

namespace ShapesLibraryTest;

public class UnitTest1
{
    [Fact]
    public void TestCircleArea()
    {
        var radius = 5d;
        
        IShape circle = new Circle(radius);
        
        var expectedArea = Math.PI * Math.Pow(radius, 2);
        Assert.Equal(expectedArea, circle.GetArea(), 1e-10);
    }

    [Fact]
    public void TestTriangleArea()
    {
        var sideA = 3d;
        var sideB = 4d;
        var sideC = 5d;
        
        IShape triangle = new Triangle(sideA, sideB, sideC);
        
        var expectedArea = 6d;
        
        Assert.Equal(expectedArea, triangle.GetArea(), 1e-10);
    }

    [Fact]
    public void TestRightTriangle()
    {
        var sideA = 3d;
        var sideB = 4d;
        var sideC = 5d;
        
        var triangle = new Triangle(sideA, sideB, sideC);
        
        Assert.True(triangle.IsRight());
    }
}