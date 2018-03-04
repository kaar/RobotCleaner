using System;
using RobotCleaner.Commands;

namespace RobotCleaner {
    public class Program {
        public static void Main(string[] args) {
            int numberOfCommands = int.Parse(Console.ReadLine());
            string startPos = Console.ReadLine();
            var start = new Point(0, 0);
            var room = new Room();
            var robot = new Robot(room, start);
            for (var i = 0; i < numberOfCommands; i++) {
                string[] commandLine = Console.ReadLine()
                                         ?.Split(' ');
                string direction = commandLine[0];
                int steps = int.Parse(commandLine[1]);
                ICommand command = CommandFactory.Create(direction, steps);
                robot.ExecuteCommand(command);
            }

            Console.WriteLine($"=> Cleaned: {room.CleanedSquares()}");
        }
    }
}