namespace RobotCleaner {
    public class Point {
        public Point(int x, int y) {
            X = x;
            Y = y;
        }

        public int X { get; }

        public int Y { get; }

        public override bool Equals(object obj) {
            // Check for null values and compare run-time types.
            if (obj == null || GetType() != obj.GetType()) {
                return false;
            }

            Point otherPoint = (Point)obj;
            return X == otherPoint.X && Y == otherPoint.Y;
        }

        public override int GetHashCode() {
            return X ^ Y;
        }

        public override string ToString() {
            return $"({X}, {Y})";
        }
    }
}