namespace RobotCleaner.Commands {
    public class West : ICommand {
        public West(int steps) {
            Steps = steps;
        }

        public int Steps { get; }

        public Point Execute(Point start) {
            return new Point(start.X - Steps, start.Y);
        }
    }
}