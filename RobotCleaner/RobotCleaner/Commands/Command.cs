namespace RobotCleaner.Commands {
    public abstract class Command {
        protected Command(int steps) {
            Steps = steps;
        }

        public int Steps { get; }

        /// <summary>
        /// Execute given command and return the end position.
        /// </summary>
        /// <param name="start">Position to start from.</param>
        /// <returns>End position after command is executed.</returns>
        public abstract Point Execute(Point start);
    }
}