using RobotCleaner.Commands;

namespace RobotCleaner {
    public class Robot {
        private readonly Room room;
        private Point currentPos;

        public Robot(Room room) {
            this.room = room;
            currentPos = new Point(0, 0);
            InitClean();
        }

        public void ExecuteCommand(ICommand command) {
            Point endpoint = command.Execute(currentPos);
            room.AddPath(currentPos, endpoint);
            currentPos = endpoint;
        }

        public Point CurrentPos() {
            return currentPos;
        }

        private void InitClean() {
            room.AddPath(currentPos, currentPos);
        }
    }
}