using AreaCalculator;

try
{
    var shapes = new Shape[]
    {
        new Triangle(1, 1, 1),
        new Circle(1.5)
    };
    
    foreach (var shape in shapes)
    {
        var area = shape.CalculateArea();
        Console.WriteLine($"Type={shape.GetType()}, area={Math.Round(area, 5)}");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}