﻿
namespace RobotCleaner {
    public interface ICommand {
        Point Execute(Point start);
    }

    public class CommandBuilder {
        public ICommand Create(string direction, int steps) {
            if (direction == "E") {
                return new East(steps);
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
}