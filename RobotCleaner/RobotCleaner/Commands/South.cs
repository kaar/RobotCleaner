namespace RobotCleaner.Commands {
    public class South : Command {
        public South(int steps)
            : base(steps) {
        }

        public override Point Execute(Point start) {
            return new Point(start.X, start.Y - Steps);
        }
    }
}