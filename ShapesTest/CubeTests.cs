using NUnit.Framework;
using Cube = Shapes.Shapes.Cube;

namespace ShapesTest
{
    [TestFixture]
    public class CubeTests
    {
        [TestCase(1, 6)]
        [TestCase(2, 24)]
        [TestCase(4, 96)]
        public void CalculateAreaReturnsCorrect(double side, double expected)
        {
            Cube cube = new Cube(side);
            double result = cube.CalculateArea();
            Assert.AreEqual(expected, result, 0.0001);
        }

        [TestCase(1, 1)]
        [TestCase(2, 8)]
        [TestCase(4, 64)]
        public void CalculateVolumeReturnsCorrect(double side, double expected)
        {
            Cube cube = new Cube(side);
            double result = cube.CalculateVolume();
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}