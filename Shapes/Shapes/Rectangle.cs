namespace Shapes.Shapes;

public class Rectangle(double length, double width) : IShape
{
    private readonly double length = length;
    private readonly double width = width;

    public double CalculateArea()
    {
        return length * width;
    }

    public double CalculateVolume()
    {
        // For 2D shapes, volume is not applicable.
        // Height of 2D shape is 0, therefore volume is 0
        return 0;
    }
}