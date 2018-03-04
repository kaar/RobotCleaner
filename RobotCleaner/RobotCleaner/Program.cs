using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using RobotCleaner.Commands;

namespace RobotCleaner {
    public class Robot {
        private Point currentPos;

        public Robot(Room room, Point start) {
            currentPos = start;
        }

        public void ExecuteCommand(ICommand command) {
        }
    }

    public class Program {
        public static void Main(string[] args) {
            int numberOfCommands = int.Parse(args[0]);

            //var commands = new Command[numberOfCommands];

            // Robot robot = new Robot(x,y);
            Room room = new Room();
        }
    }
}