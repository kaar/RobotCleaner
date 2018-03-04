using System;

namespace RobotCleaner {
    public interface ICommand {
        int Steps { get; }

        Point Execute(Point start);
    }

    public class CommandBuilder {
        public ICommand Create(string direction, int steps) {
            switch (direction) {
                case "E":
                    return new East(steps);
                case "W":
                    return new West(steps);
                case "N":
                    return new North(steps);
                case "S":
                    return new South(steps);
                default:
                    throw new Exception($"Unknown direction {direction}");
            }
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
            return new Point(start.X - Steps, start.Y);
        }
    }

    public class South : ICommand {
        public South(int steps) {
            Steps = steps;
        }

        public int Steps { get; }

        public Point Execute(Point start) {
            return new Point(start.X, start.Y - Steps);
        }
    }

    public class North : ICommand {
        public North(int steps) {
            Steps = steps;
        }

        public int Steps { get; }

        public Point Execute(Point start) {
            throw new System.NotImplementedException();
        }
    }
}