using System.Collections.Generic;

namespace RobotCleaner {
    public class Room {
        private readonly HashSet<Point> cleaned = new HashSet<Point>();

        public void AddPath(IEnumerable<Point> points) {
            cleaned.UnionWith(points);
        }

        public int CleanedSquares() {
            return cleaned.Count;
        }

        public void AddPath(Point start, Point end) {
            IEnumerable<Point> visitedPoints = Path.GetPoints(start, end);
            AddPath(visitedPoints);
        }
    }
}