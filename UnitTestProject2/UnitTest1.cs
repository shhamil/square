using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void CircleSquare_negativeradius_returned0()
        {
            var circle = new square.Circle(-5);
            double result = circle.square();
            double expected = 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CircleSquare_radius1_returnedPI()
        {
            var circle = new square.Circle(1);
            double result = circle.square();
            double expected = Math.PI;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TriangleSquare_a2b2c5_returned0()
        {
            var triangle = new square.Triangle(2, 2, 5);
            double result = triangle.square();
            double expected = 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TriangleSquare_a5b3c4_returned6()
        {
            var triangle = new square.Triangle(5, 3, 4);
            double result = triangle.square();
            double expected = 6;
            Assert.AreEqual(expected, result);
        }
    }
}
