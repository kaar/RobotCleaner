namespace RobotCleaner.Commands {
    public class East : Command {
        public East(int steps)
            : base(steps) {
        }

        public override Point Execute(Point start) {
            return new Point(start.X + Steps, start.Y);
        }
    }
}