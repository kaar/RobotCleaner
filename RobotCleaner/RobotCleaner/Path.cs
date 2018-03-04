using System;
using System.Collections.Generic;
using System.Linq;

namespace RobotCleaner {
    public class Path {
        /// <summary>
        /// Calculates all visited points along the path from start to end.
        /// </summary>
        /// <param name="start">Starting point</param>
        /// <param name="end">Ending point</param>
        /// <returns>All points between and included start and end.</returns>
        public static IEnumerable<Point> GetPoints(Point start, Point end) {
            if (MovedHorizontally(start.X, end.X)) {
                return GetRange(start.X, end.X)
                    .Select(i => new Point(i, start.Y));
            }

            if (MovedVertically(start.Y, end.Y)) {
                return GetRange(start.Y, end.Y)
                    .Select(i => new Point(start.X, i));
            }

            // In case you did not move.
            return new List<Point> {
                start
            };
        }

        private static bool MovedVertically(int startY, int endY) {
            return GetDistance(startY, endY) > 0;
        }

        private static bool MovedHorizontally(int startX, int endX) {
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