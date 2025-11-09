using NUnit.Framework;
using Calc = Calculator.Calculator;

namespace CalculatorTest
{
    [TestFixture]
    public class CalculatorTests
    {
        [TestCase(2, 3, '+', 5)]
        [TestCase(-1, 1, '+', 0)]
        [TestCase(1.5, 2.5, '+', 4)]
        [TestCase(0, 0, '+', 0)]
        public void AddWorks(double a, double b, char op, double expected)
        {
            var c = new Calc(a, b, op);
            Assert.AreEqual(expected, c.Calculate(), 0.0001);
        }

        [TestCase(10, 4, '-', 6)]
        [TestCase(-3, -7, '-', 4)]
        [TestCase(2.5, 5.0, '-', -2.5)]
        [TestCase(0, 5, '-', -5)]
        public void SubtractWorks(double a, double b, char op, double expected)
        {
            var c = new Calc(a, b, op);
            Assert.AreEqual(expected, c.Calculate(), 0.0001);
        }

        [TestCase(3, 5, '*', 15)]
        [TestCase(-2, 8, '*', -16)]
        [TestCase(1.25, 2.0, '*', 2.5)]
        [TestCase(0, 123.456, '*', 0)]
        public void MultiplyWorks(double a, double b, char op, double expected)
        {
            var c = new Calc(a, b, op);
            Assert.AreEqual(expected, c.Calculate(), 0.0001);
        }

        [TestCase(20, 4, '/', 5)]
        [TestCase(7, 2, '/', 3.5)]
        [TestCase(-9, 3, '/', -3)]
        [TestCase(0, 5, '/', 0)]
        public void DivideWorks(double a, double b, char op, double expected)
        {
            var c = new Calc(a, b, op);
            Assert.AreEqual(expected, c.Calculate(), 0.0001);
        }

        [TestCase(10, -2, '/', -5)]
        [TestCase(-10, 2, '/', -5)]
        [TestCase(-10, -2, '/', 5)]
        public void DivideWithDifferentSignsWorks(double a, double b, char op, double expected)
        {
            var c = new Calc(a, b, op);
            Assert.AreEqual(expected, c.Calculate(), 0.0001);
        }

        [Test]
        public void DivideByZeroThrows()
        {
            var c = new Calc(1, 0, '/');
            Assert.Throws<DivideByZeroException>(() => c.Calculate());
        }

        [TestCase('^')]
        [TestCase('%')]
        [TestCase('x')]
        [TestCase(' ')]
        public void InvalidOperationThrows(char op)
        {
            var c = new Calc(1, 2, op);
            Assert.Throws<ArgumentException>(() => c.Calculate());
        }

        [Test]
        public void MaxValueAddZeroWorks()
        {
            var c = new Calc(double.MaxValue, 0, '+');
            Assert.AreEqual(double.MaxValue, c.Calculate(), 0.0001);
        }

        [Test]
        public void MaxValueSubtractZeroWorks()
        {
            var c = new Calc(double.MaxValue, 0, '-');
            Assert.AreEqual(double.MaxValue, c.Calculate(), 0.0001);
        }

        [Test]
        public void MaxValueMultiplyByOneWorks()
        {
            var c = new Calc(double.MaxValue, 1, '*');
            Assert.AreEqual(double.MaxValue, c.Calculate(), 0.0001);
        }

        [Test]
        public void MaxValueDivideByOneWorks()
        {
            var c = new Calc(double.MaxValue, 1, '/');
            Assert.AreEqual(double.MaxValue, c.Calculate(), 0.0001);
        }

        [Test]
        public void MinValueAddZeroWorks()
        {
            var c = new Calc(double.MinValue, 0, '+');
            Assert.AreEqual(double.MinValue, c.Calculate(), 0.0001);
        }

        [Test]
        public void MinValueSubtractZeroWorks()
        {
            var c = new Calc(double.MinValue, 0, '-');
            Assert.AreEqual(double.MinValue, c.Calculate(), 0.0001);
        }

        [Test]
        public void MinValueMultiplyByOneWorks()
        {
            var c = new Calc(double.MinValue, 1, '*');
            Assert.AreEqual(double.MinValue, c.Calculate(), 0.0001);
        }

        [Test]
        public void MinValueDivideByOneWorks()
        {
            var c = new Calc(double.MinValue, 1, '/');
            Assert.AreEqual(double.MinValue, c.Calculate(), 0.0001);
        }

        [Test]
        public void LargeNumbersToInfinityWorks()
        {
            var add = new Calc(double.MaxValue, double.MaxValue, '+').Calculate();
            Assert.IsTrue(double.IsPositiveInfinity(add));

            var mul = new Calc(1e308, 10, '*').Calculate();
            Assert.IsTrue(double.IsPositiveInfinity(mul));
        }

        [Test]
        public void LargeNegativeToNegativeInfinityWorks()
        {
            var mul = new Calc(double.MinValue, 2, '*').Calculate();
            Assert.IsTrue(double.IsNegativeInfinity(mul));
        }

        [Test]
        public void NaNPropagatesWorks()
        {
            var c1 = new Calc(double.NaN, 5, '+').Calculate();
            var c2 = new Calc(5, double.NaN, '*').Calculate();
            Assert.IsTrue(double.IsNaN(c1));
            Assert.IsTrue(double.IsNaN(c2));
        }

        [Test]
        public void PropertiesAreStable()
        {
            var c = new Calc(10, 5, '/');
            var r1 = c.Calculate();
            var r2 = c.Calculate();
            Assert.AreEqual(10, c.A);
            Assert.AreEqual(5, c.B);
            Assert.AreEqual('/', c.Op);
            Assert.AreEqual(r1, r2, 0.0001);
        }
    }
}