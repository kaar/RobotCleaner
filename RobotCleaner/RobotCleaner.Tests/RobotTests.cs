using NUnit.Framework;
using RobotCleaner.Commands;

namespace RobotCleaner.Tests {
    public class RobotTests {
        [Test]
        public void Test() {
            // Arrange
            Room room = new Room();
            Point origo = new Point(0, 0);
            Robot r = new Robot(room, origo);

            // Act
            ICommand command = new East(2);
            r.ExecuteCommand(command);

            // Assert
            //Assert.That(room.CleanedSquares(), Is.EqualTo(2));
        }
    }
}