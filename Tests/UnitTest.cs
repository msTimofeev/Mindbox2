using System;
using Mindbox;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Triangle_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Calculator(new Triangle(-8, -5, -5)));
        }

        [Test]
        public void Circle_ArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Calculator(new Circle(-6)));
        }

        [Test]
        public void Circle_Area()
        {
            var area = new Calculator(new Circle(6)).CalculateArea();

            Assert.AreEqual(Math.PI * Math.Pow(6, 2), area);
        }

        [Test]
        public void Triangle_Area()
        {
            var area = new Calculator(new Triangle(8, 5, 5)).CalculateArea();

            Assert.AreEqual(12, area);
        }
    }
}