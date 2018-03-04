namespace RobotCleaner.Commands {
    public interface ICommand {
        int Steps { get; }

        Point Execute(Point start);
    }
}