using System;
using RobotCleaner.Commands;

namespace RobotCleaner {
    public class Program {
        public static void Main(string[] args) {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Console.ReadLine();
            var room = new Room();
            var robot = new Robot(room);
            for (var i = 0; i < numberOfCommands; i++) {
                string[] commandLine = Console.ReadLine()
                                         ?.Split(' ');
                string direction = commandLine[0];
                int steps = int.Parse(commandLine[1]);
                robot.ExecuteCommand(CommandFactory.Create(direction, steps));
            }

            Console.WriteLine($"=> Cleaned: {room.CleanedSquares()}");
        }
    }
}