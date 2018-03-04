using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotCleaner {
    public class Path {
        public static IEnumerable<Point> GetPoints(Point start, Point end) {
            int dx = GetDistance(start.X, end.X);
            int dy = GetDistance(start.Y, end.Y);

            // Moving Horisonaly
            if (dx > 0) {
                return GetRange(start.X, end.X)
                    .Select(i => new Point(i, start.Y));
            }

            // Moving Vericaly
            if (dy > 0) {
                return GetRange(start.Y, end.Y)
                    .Select(i => new Point(start.X, i));
            }

            return null;
        }

        public static IEnumerable<int> GetRange(int start, int end) {
            return Enumerable.Range(end < start ? end : start, GetDistance(start, end) + 1);
        }

        public static int GetDistance(int i1, int i2) {
            return Math.Abs(i2 - i1);
        }
    }
}