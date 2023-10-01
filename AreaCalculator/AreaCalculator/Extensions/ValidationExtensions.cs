namespace AreaCalculator.Extensions;

public static class ValidationExtensions
{
    public static bool IsInvalid(this double number)
    {
        return number > Double.MaxValue 
               || number <= 0;
    }
}