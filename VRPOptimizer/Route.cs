using System;
using System.Collections.Generic;

namespace VRPOptimizer
{
    public class Route
    {
        readonly List<Point> points;

        public Route()
        {
            points = new List<Point>();
        }

        public void AddPoint(Point point)
        {
            points.Add(point);
        }

        public double GetLength()
        {
            double length = 0.0;
            for (int i = 0; i < points.Count - 1; ++i)
            {
                length += points[i].GetDistance(points[i + 1]);
            }
            return length;
        }
    }
}
