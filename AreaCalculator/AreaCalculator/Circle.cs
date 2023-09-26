using System.ComponentModel.DataAnnotations;

namespace AreaCalculator;

public class Circle : Shape
{
    [Range(0, Double.MaxValue, ErrorMessage = "Value must be range between 0 to Double.MaxValue", ErrorMessageResourceType = typeof(ArgumentException))]
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double CalculateShape() => Math.PI * Math.Pow(_radius, 2);
}