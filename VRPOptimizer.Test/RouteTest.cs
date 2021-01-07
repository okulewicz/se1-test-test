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
            Point p1 = new Point(0.0, 0.0);
            Point p2 = new Point(0.0, 5.0);
            Point p3 = new Point(0.0, 10.0);
            Assert.IsTrue(route.AddPoint(p1));
            Assert.IsTrue(route.AddPoint(p2));
            Assert.IsFalse(route.AddPoint(p3));
        }
    }
}