using System;

namespace VRPOptimizer
{
    public class Point
    {
        private readonly double _x;
        private readonly double _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double GetDistance(Point p)
        {
            return Math.Sqrt((p._x - this._x) * (p._x - this._x) +
                (p._y - this._y) * (p._y - this._y));
        }
    }
}