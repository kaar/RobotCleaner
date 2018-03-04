namespace RobotCleaner.Commands {
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