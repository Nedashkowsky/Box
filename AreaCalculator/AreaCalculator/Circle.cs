using AreaCalculator.Extensions;

namespace AreaCalculator;

public class Circle : Shape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double CalculateArea() 
    {
        _radius.Validate();
        return Math.PI * Math.Pow(_radius, 2);
    }
}