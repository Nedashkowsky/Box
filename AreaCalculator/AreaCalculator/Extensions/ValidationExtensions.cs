namespace AreaCalculator.Extensions;

public static class ValidationExtensions
{
    public static void Validate(this double number)
    {
        if (number > Double.MaxValue
            || number < 1)
            throw new ArgumentException($"Invalid shape side value: {number}");
    }
}