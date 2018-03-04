using System;

namespace RobotCleaner.Commands {
    public class CommandFactory {
        public static Command Create(string direction, int steps) {
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
}