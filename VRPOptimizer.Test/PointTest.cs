using NUnit.Framework;
using System;

namespace VRPOptimizer.Test
{
    class PointTest
    {
        [Test, Sequential]
        public void TestDistance(
            [Values(0, 1, 0, 1)] double x,
            [Values(0, 0, 1, 1)] double y,
            [Values(0, 1, 1, 1.41)] double expected)
        {
            Point referencePoint = new Point(0, 0);
            Point otherPoint = new Point(x, y);
            Assert.AreEqual(expected, referencePoint.GetDistance(otherPoint), 1e-2);
            Assert.AreEqual(expected, otherPoint.GetDistance(referencePoint), 1e-2);
        }
    }
}
