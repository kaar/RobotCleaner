namespace RobotCleaner.Commands {
    public class South : ICommand {
        public South(int steps) {
            Steps = steps;
        }

        public int Steps { get; }

        public Point Execute(Point start) {
            return new Point(start.X, start.Y - Steps);
        }
    }
}