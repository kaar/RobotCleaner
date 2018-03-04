namespace RobotCleaner.Commands {
    public class North : ICommand {
        public North(int steps) {
            Steps = steps;
        }

        public int Steps { get; }

        public Point Execute(Point start) {
            return new Point(start.X, start.Y + 2);
        }
    }
}