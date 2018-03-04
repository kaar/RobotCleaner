using System.Collections.Generic;
using System.Linq;

namespace RobotCleaner {
    public class Path {
        private readonly Point start;
        private readonly Point end;

        public Path(Point start, Point end) {
            this.start = start;
            this.end = end;
        }

        public IEnumerable<Point> GetPoints() {
            var list = new List<Point>();
            for (int i = start.X; i < end.X; i++) {
                list.Add(new Point(i, start.Y));
            }

            for (int i = start.Y; i < end.Y; i++) {
                list.Add(new Point(start.X, i));
            }

            list.Add(end);
            return list;
        }
    }
}