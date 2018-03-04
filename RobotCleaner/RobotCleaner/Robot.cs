using RobotCleaner.Commands;

namespace RobotCleaner {
    public class Robot {
        private readonly Room room;
        private Point currentPos;

        public Robot(Room room, Point start) {
            this.room = room;
            currentPos = start;
        }

        public void ExecuteCommand(ICommand command) {
            //room.AddPath(s);
        }
    }
}