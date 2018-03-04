namespace RobotCleaner.Commands {
    public abstract class Command {
        protected Command(int steps) {
            Steps = steps;
        }

        public int Steps { get; }

        public abstract Point Execute(Point start);
    }
}