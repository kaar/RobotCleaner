using System.Collections.Generic;

namespace RobotCleaner {
    public class Room {
        private readonly HashSet<Point> cleaned = new HashSet<Point>();

        public void AddPath(IList<Point> points) {
            cleaned.UnionWith(points);
        }

        //public Point AddPath(Point startPoint, Point endPoint) {
        //}

        public int CleanedSquares() {
            return cleaned.Count;
        }
    }
}