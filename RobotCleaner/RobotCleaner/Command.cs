using System.Collections.Generic;

namespace RobotCleaner {
    public class Command {
        private readonly string direction;
        private readonly int steps;

        public Command(string direction, int steps) {
            this.direction = direction;
            this.steps = steps;
        }

        public Point Execute(Point start) {
            if (direction == "E") {
                return new Point(start.X + steps, start.Y);
            }
            return null;
        }
    }

    public class CommandBuild {
        public Command Create(string direction, int steps) {
            if direction == 
            return new Command(directionm);
        }
    }

    public class East : Command {
        public East (int steps) : base(steps) {
            
        }
    }
}