using NUnit.Framework;
using Sphere = Shapes.Shapes.Sphere;

namespace ShapesTest
{
    [TestFixture]
    public class SphereTests
    {
        [TestCase(1, 12.5664)]
        [TestCase(2, 50.2655)]
        [TestCase(3, 113.0973)]
        public void CalculateAreaReturnsCorrect(double radius, double expected)
        {
            Sphere sphere = new Sphere(radius);
            double result = sphere.CalculateArea();
            Assert.AreEqual(expected, result, 0.0001);
        }

        [TestCase(1, 4.1888)]
        [TestCase(2, 33.5103)]
        [TestCase(3, 113.0973)]
        public void CalculateVolumeReturnsCorrect(double radius, double expected)
        {
            Sphere sphere = new Sphere(radius);
            double result = sphere.CalculateVolume();
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}