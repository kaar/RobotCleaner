using System.Collections.Generic;

namespace RobotCleaner {
    public class Path {
        private readonly Point start;
        private readonly Point end;

        public Path(Point start, Point end) {
            this.start = start;
            this.end = end;
        }

        public IEnumerable<Point> GetPath() {
        }
    }
}