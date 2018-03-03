namespace RobotCleaner {
//HashSet<Point> list = new HashSet<Point>(new PointComparer());
    public class Point {
        public Point(int x, int y) {
            X = x;
            Y = y;
        }

        public int X { get; set; }

        public int Y { get; set; }
//class PointComparer : IEqualityComparer<Point> {
//    public bool Equals(Point x, Point y) {
//        return x.X == y.X && x.Y == y.Y;
//    }

//    public int GetHashCode(Point obj) {
//        // Perfect hash for practical bitmaps, their width/height is never >= 65536
//        return (obj.Y << 16) ^ obj.X;
//    }
//}
        public override int GetHashCode() {
            unchecked {
                int hash = 17;

                // Suitable nullity checks etc, of course :)
                hash = hash * 23 + X.GetHashCode();
                hash = hash * 23 + Y.GetHashCode();
                return hash;
            }
        }
    }
}