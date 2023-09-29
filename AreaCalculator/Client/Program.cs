// See https://aka.ms/new-console-template for more information

using AreaCalculator;

var shapes = new Shape[]
{
    new Triangle(1, 1, 1),
    new Circle(1.5)
};

try
{
    foreach (var shape in shapes)
    {
        var area = shape.CalculateArea();
        Console.WriteLine($"Type={shape.GetType()}, area={Math.Round(area,5)}");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}