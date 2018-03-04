using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotCleaner {
    public class Path {
        public static IEnumerable<Point> GetPoints(Point start, Point end) {
            if (MovingHorizontally(start.X, end.X)) {
                return GetRange(start.X, end.X)
                    .Select(i => new Point(i, start.Y));
            }

            if (MovingVertically(start.Y, end.Y)) {
                return GetRange(start.Y, end.Y)
                    .Select(i => new Point(start.X, i));
            }

            return null;
        }

        public static bool MovingVertically(int startY, int endY) {
            return GetDistance(startY, endY) > 0;
        }

        private static bool MovingHorizontally(int startX, int endX) {
            return GetDistance(startX, endX) > 0;
        }

        private static IEnumerable<int> GetRange(int start, int end) {
            return Enumerable.Range(end < start ? end : start, GetDistance(start, end) + 1);
        }

        private static int GetDistance(int i1, int i2) {
            return Math.Abs(i2 - i1);
        }
    }
}