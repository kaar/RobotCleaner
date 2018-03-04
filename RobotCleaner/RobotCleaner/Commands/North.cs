namespace RobotCleaner.Commands {
    public class North : Command {
        public North(int steps)
            : base(steps) {
        }

        public override Point Execute(Point start) {
            return new Point(start.X, start.Y + Steps);
        }
    }
}