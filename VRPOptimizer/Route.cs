using System;
using System.Collections.Generic;
using System.Linq;

namespace VRPOptimizer
{
    public class Route
    {
        readonly List<Point> points;

        public Route()
        {
            points = new List<Point>();
        }

        public bool AddPoint(Point point)
        {
            if (points.Count == 0)
            {
                points.Add(point);
                return true;
            }
            else
            {
                Point lastPoint = points.Last();
                if (this.GetLength() + lastPoint.GetDistance(point) < 8)
                {
                    points.Add(point);
                    return true;
                }
                return false;
            }
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
