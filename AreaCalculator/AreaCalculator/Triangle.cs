using AreaCalculator.Extensions;

namespace AreaCalculator;

public class Triangle : Shape
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public override double CalculateArea()
    {
        _a.Validate();
        _b.Validate();
        _c.Validate();
        
        var p = (_a + _b + _c) / 2;

        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    public bool IsRectangular()
    {
        _a.Validate();
        _b.Validate();
        _c.Validate();
        
        var sides = new[] { _a, _b, _c };
        Array.Sort(sides);

        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }
}