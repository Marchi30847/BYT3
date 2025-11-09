using NUnit.Framework;
using Rect = Shapes.Shapes.Rectangle;

namespace ShapesTest
{
    [TestFixture]
    public class RectangleTests
    {
        [TestCase(4, 8, 32)]
        [TestCase(2, 5, 10)]
        [TestCase(1, 1, 1)]
        public void CalculateAreaReturnsCorrect(double length, double width, double expected)
        {
            Rect rectangle = new Rect(length, width);
            double result = rectangle.CalculateArea();
            Assert.AreEqual(expected, result, 0.0001);
        }

        [TestCase(4, 8)]
        [TestCase(2, 5)]
        [TestCase(1, 1)]
        public void CalculateVolumeReturnsZero(double length, double width)
        {
            Rect rectangle = new Rect(length, width);
            double result = rectangle.CalculateVolume();
            Assert.AreEqual(0, result, 0.0001);
        }
    }
}