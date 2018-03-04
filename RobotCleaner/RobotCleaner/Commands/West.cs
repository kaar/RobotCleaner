namespace RobotCleaner.Commands {
    public class West : Command {
        public West(int steps)
            : base(steps) {
        }

        public override Point Execute(Point start) {
            return new Point(start.X - Steps, start.Y);
        }
    }
}