using System.Collections.Generic;

namespace RobotCleaner {
    public class Command {
        private readonly string direction;
        private readonly int steps;

        public Command(string direction, int steps) {
            this.direction = direction;
            this.steps = steps;
        }

        public IEnumerable<Point> Execute(Point start) {
            return null;
        }
    }
}