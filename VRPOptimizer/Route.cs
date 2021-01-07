using System;
using System.Collections.Generic;
using System.Linq;

namespace VRPOptimizer
{
    public class Route
    {
        private const double MAX_ROUTE_LENGTH = 8.0;
        readonly List<Point> points;

        public Route()
        {
            points = new List<Point>();
        }

        public bool AddPoint(Point point)
        {
            double currentRouteLength = GetLength();
            double distanceToNewPoint = GetDistanceToNewPoint(point);

            if (currentRouteLength + distanceToNewPoint <= MAX_ROUTE_LENGTH)
            {
                points.Add(point);
                return true;
            }
            return false;
        }

        private double GetDistanceToNewPoint(Point point)
        {
            double distanceToNewPoint = 0.0;
            Point lastPoint = points.LastOrDefault();
            if (lastPoint != null)
            {
                distanceToNewPoint = lastPoint.GetDistance(point);
            }

            return distanceToNewPoint;
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
