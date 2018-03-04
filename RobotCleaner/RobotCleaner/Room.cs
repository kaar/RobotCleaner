using System.Collections.Generic;

namespace RobotCleaner {
    public class Room {
        private readonly HashSet<Point> cleaned = new HashSet<Point>(new PointComparer());

        public void AddPath(IList<Point> points) {
            cleaned.UnionWith(points);
        }

        //public Point AddPath(Point startPoint, Point endPoint) {
        //}

        public int CleanedSquares() {
            return cleaned.Count;
        }
    }

    internal class PointComparer : IEqualityComparer<Point> {
        // https://stackoverflow.com/questions/46142734/why-is-hashsetpoint-so-much-slower-than-hashsetstring/46142932
        public bool Equals(Point x, Point y) {
            return x.X == y.X && x.Y == y.Y;
        }

        public int GetHashCode(Point obj) {
            // Perfect hash for practical bitmaps, their width/height is never >= 65536
            return (obj.Y << 16) ^ obj.X;
        }
    }
}