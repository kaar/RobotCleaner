namespace RobotCleaner {
    public interface ICommand {
        int Steps { get; }

        Point Execute(Point start);
    }

    public class CommandBuilder {
        public ICommand Create(string direction, int steps) {
            if (direction == "E") {
                return new East(steps);
            }

            if (direction == "W") {
                return new West(steps);
            }

            return null;
        }
    }

    public class East : ICommand {
        public East(int steps) {
            Steps = steps;
        }

        public int Steps { get; }

        public Point Execute(Point start) {
            return new Point(start.X + Steps, start.Y);
        }
    }

    public class West : ICommand {
        public West(int steps) {
            Steps = steps;
        }

        public int Steps { get; }

        public Point Execute(Point start) {
            throw new System.NotImplementedException();
        }
    }

    public class South : ICommand {
        public South(int steps) {
            Steps = steps;
        }

        public int Steps { get; }

        public Point Execute(Point start) {
            throw new System.NotImplementedException();
        }
    }
}