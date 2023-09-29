using AreaCalculator;
using FluentAssertions;

namespace AreaCalcucatorTests;

public class CircleTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(100)]
    [InlineData(Double.MaxValue)]
    public void CalculateArea_ValidInput_ReturnsValue(double radius)
    {
        var circle = new Circle(radius);
        var result = circle.CalculateArea();
        result.Should().BeGreaterThan(0);
    }
    
    [Theory]
    [InlineData(0)]
    [InlineData(-100)]
    [InlineData(Double.MinValue)]
    public void CalculateArea_InvalidInput_ThrowsError(double radius)
    {
        var circle = new Circle(radius);
        Assert.Throws<ArgumentException>(() => circle.CalculateArea());
    }
}