using NUnit.Framework;
using Cylinder = Shapes.Shapes.Cylinder;

namespace ShapesTest
{
    [TestFixture]
    public class CylinderTests
    {
        [TestCase(3, 7, 188.4956)]
        [TestCase(1, 5, 37.6991)]
        [TestCase(2, 10, 150.7964)]
        public void CalculateAreaReturnsCorrect(double radius, double height, double expected)
        {
            Cylinder cylinder = new Cylinder(radius, height);
            double result = cylinder.CalculateArea();
            Assert.AreEqual(expected, result, 0.0001);
        }

        [TestCase(3, 7, 197.9203)]
        [TestCase(1, 5, 15.708)]
        [TestCase(2, 10, 125.6637)]
        public void CalculateVolumeReturnsCorrect(double radius, double height, double expected)
        {
            Cylinder cylinder = new Cylinder(radius, height);
            double result = cylinder.CalculateVolume();
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}