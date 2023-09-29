using AreaCalculator;
using FluentAssertions;

namespace AreaCalcucatorTests;

public class TriangleTests
{
    [Theory]
    [InlineData(1,1,1)]
    [InlineData(Double.MaxValue,Double.MaxValue,Double.MaxValue)]
    public void CalculateArea_ValidInput_ReturnsValue(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        var result = triangle.CalculateArea();
        result.Should().BeGreaterThan(0);
    }
    
    [Theory]
    [InlineData(1,1,-1)]
    [InlineData(1,Double.MinValue,1)]
    [InlineData(0,0,0)]
    public void CalculateArea_InvalidInput_ThrowsError(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        Assert.Throws<ArgumentException>(() => triangle.CalculateArea());
    }
    
    [Theory]
    [InlineData(1,-1,1)]
    [InlineData(Double.MinValue,2,1)]
    public void IsRectangular_InvalidInput_ThrowsError(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        Assert.Throws<ArgumentException>(() => triangle.IsRectangular());
    }
    
    [Theory]
    [InlineData(6,8,10)]
    public void IsRectangular_ValidInput_ReturnsTrue(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        var result = triangle.IsRectangular();
        result.Should().BeTrue();
    }
   
   [Theory]
   [InlineData(Double.MaxValue,Double.MaxValue,Double.MaxValue)]
   public void IsRectangular_ValidInput_ReturnsBool(double a, double b, double c)
   {
       var triangle = new Triangle(a, b, c);
       var result = triangle.IsRectangular();
       Assert.IsType<bool>(result);
   }
}