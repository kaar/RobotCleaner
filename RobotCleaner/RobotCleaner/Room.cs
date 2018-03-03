using System.Collections.Generic;

namespace RobotCleaner {
    public class Room {
        private readonly HashSet<Point> cleaned = new HashSet<Point>(new PointComparer());

        public Room() {
            //cleaned = new HashSet<Point>();
        }

        public void AddPath(IList<Point> points) {
            //foreach (Point point in points) {
            //    cleaned.Add(point);
            //}

            cleaned.UnionWith(points);
        }

        public int CleanedSquares() {
            return cleaned.Count;
        }
    }

    internal class PointComparer : IEqualityComparer<Point> {
        public bool Equals(Point x, Point y) {
            return x.X == y.X && x.Y == y.Y;
        }

        public int GetHashCode(Point obj) {
            // Perfect hash for practical bitmaps, their width/height is never >= 65536
            return (obj.Y << 16) ^ obj.X;
        }
    }
}