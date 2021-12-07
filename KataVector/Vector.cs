using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KataVector
{
    [TestClass]
    public class Vector
    {
        double x;
        double y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        [TestMethod]
        public void TestVectorConstructor(double x, double y)
        {
            x = 5;
            y = 10;
            double xAxis = 5;
            double yAxis = 10;
            Assert.AreEqual(xAxis, x);
            Assert.AreEqual(yAxis,y );

        }
        [TestMethod]
        public void TestVectorConstructorFailed(double x, double y)
        {
            x = 5;
            y = 10;
            double xAxis = 9;
            double yAxis = 6;
            Assert.AreEqual(xAxis, x);
            Assert.AreEqual(yAxis, y);
        }
        [TestMethod]
        public void TestVectorMagnitude(double x, double y)
        {
            x = 20;
            y = 45;
            Vector vector = new(x, y);
           // double result = vector.Length;
           
        }
        [TestMethod]
        public void TestVectorDotProduct(double x, double y)
        {
            double product = x * y;
            x = 10;
            y = 10;
            Assert.AreEqual(100, product);
        }
        [TestMethod]
        public void TestVectorAngleBetween(double x, double y)
        {
            double angle = Math.Atan2(x, y);
            double result = angle;
            Assert.AreEqual(result, angle);
        }
    }
}
