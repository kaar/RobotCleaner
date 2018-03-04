using RobotCleaner.Commands;

namespace RobotCleaner {
    public class Robot {
        private readonly Room room;
        private Point currentPos;

        public Robot(Room room, Point start) {
            this.room = room;
            currentPos = start;
            InitClean();
        }

        private void InitClean() {
            this.room.AddPath(currentPos, currentPos);
        }

        public void ExecuteCommand(ICommand command) {
            Point endpoint = command.Execute(currentPos);
            room.AddPath(currentPos, endpoint);
            currentPos = endpoint;
        }

        public Point CurrentPos() {
            return currentPos;
        }
    }
}