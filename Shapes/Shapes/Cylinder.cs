namespace Shapes.Shapes;

public class Cylinder(double radius, double height) : IShape
{
    private readonly double radius = radius;
    private readonly double height = height;

    public double CalculateArea()
    {
        return 2 * Math.PI * radius * (radius + height);
    }

    public double CalculateVolume()
    {
        return Math.PI * Math.Pow(radius, 2) * height;
    }
}