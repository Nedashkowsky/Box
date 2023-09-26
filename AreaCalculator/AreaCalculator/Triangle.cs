using System.ComponentModel.DataAnnotations;

namespace AreaCalculator;

public class Triangle : Shape
{
    [Range(0, Double.MaxValue, ErrorMessage = "Value must be range between 0 to Double.MaxValue", ErrorMessageResourceType = typeof(ArgumentException))]
    private readonly double _a;

    [Range(0, Double.MaxValue, ErrorMessage = "Value must be range between 0 to Double.MaxValue", ErrorMessageResourceType = typeof(ArgumentException))]
    private readonly double _b;
    
    [Range(0, Double.MaxValue, ErrorMessage = "Value must be range between 0 to Double.MaxValue", ErrorMessageResourceType = typeof(ArgumentException))]
    private readonly double _c;

    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public override double CalculateShape()
    {
        var p = (_a + _b + _c) / 2;

        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }
}