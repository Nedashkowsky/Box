using AreaCalculator.Extensions;

namespace AreaCalculator;

public class Triangle : Shape
{
    private readonly double _first;
    private readonly double _second;
    private readonly double _third;

    public Triangle(double first, double second, double third)
    {
        if (first.IsInvalid() 
             ||  second.IsInvalid()
             || third.IsInvalid())
            throw new ArgumentException("Invalid shape side value");

        _first = first;
        _second = second;
        _third = third;
    }

    public override double CalculateArea()
    {
        var perimeter = (_first + _second + _third) / 2;

        return Math.Sqrt(perimeter * (perimeter - _first) * (perimeter - _second) * (perimeter - _third));
    }

    public bool IsRectangular()
    {
        var sides = new[] { _first, _second, _third };
        Array.Sort(sides);

        return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
    }
}