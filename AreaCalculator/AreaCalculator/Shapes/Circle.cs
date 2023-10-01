using AreaCalculator.Extensions;

namespace AreaCalculator;

public class Circle : Shape
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if(radius.IsInvalid())
            throw new ArgumentException("Invalid shape side value");
        
        _radius = radius;
    }

    public override double CalculateArea() => Math.PI * _radius * _radius;
}