using System.Collections.Generic;

namespace RobotCleaner {
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