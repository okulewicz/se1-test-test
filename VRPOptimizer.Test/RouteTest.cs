using NUnit.Framework;

namespace VRPOptimizer.Test
{
    public class RouteTest
    {
        [Test]
        public void TestLength()
        {
            Route route = new Route();
            Assert.AreEqual(0, route.GetLength());
            Point p1 = new Point(0.0, 0.0);
            Point p2 = new Point(0.0, 1.0);
            Point p3 = new Point(1.0, 1.0);
            route.AddPoint(p1);
            Assert.AreEqual(0, route.GetLength());
            route.AddPoint(p2);
            Assert.AreEqual(1, route.GetLength());
            route.AddPoint(p3);
            Assert.AreEqual(2, route.GetLength());
        }

        [Test]
        public void TestLengthLimit()
        {
            Route route = new Route();
            Assert.AreEqual(0, route.GetLength());
            Point p_0 = new Point(0.0, 0.0);
            Point p_5 = new Point(0.0, 5.0);
            Point p_7_9999 = new Point(0.0, 7.9999);
            Point p_8 = new Point(0.0, 8.0);
            Point p_8_0001 = new Point(0.0, 8.0001);
            Point p_10 = new Point(0.0, 10.0);
            Assert.IsTrue(route.AddPoint(p_0));
            Assert.IsTrue(route.AddPoint(p_5));
            Assert.IsTrue(route.AddPoint(p_7_9999));
            Assert.IsTrue(route.AddPoint(p_8));
            Assert.IsFalse(route.AddPoint(p_8_0001));
            Assert.IsFalse(route.AddPoint(p_10));
        }
    }
}