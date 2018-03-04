using NUnit.Framework;
using RobotCleaner.Commands;

namespace RobotCleaner.Tests {
    public class RobotTests {
        [Test]
        public void Clean() {
            // Arrange
            Room room = new Room();
            Point origo = new Point(0, 0);
            Robot r = new Robot(room, origo);

            // Act
            ICommand command = new East(2);
            r.ExecuteCommand(command);

            // Assert
            Assert.That(room.CleanedSquares(), Is.EqualTo(3));
        }

        [Test]
        public void Clean_Two() {
            // Arrange
            Room room = new Room();
            Point origo = new Point(0, 0);
            Robot r = new Robot(room, origo);

            // Act
            ICommand command = new East(2);
            r.ExecuteCommand(command);
            r.ExecuteCommand(new South(1));

            // Assert
            Assert.That(room.CleanedSquares(), Is.EqualTo(4));
        }

        [Test]
        public void Clean_ThreeCommands() {
            // Arrange
            Room room = new Room();
            Point origo = new Point(0, 0);
            Robot r = new Robot(room, origo);

            // Act
            ICommand command = new East(2);
            r.ExecuteCommand(command);
            r.ExecuteCommand(new South(1));
            r.ExecuteCommand(new West(1));

            // Assert
            Assert.That(room.CleanedSquares(), Is.EqualTo(5));
        }

        [Test]
        public void Clean_FourCommands() {
            // Arrange
            Room room = new Room();
            Point origo = new Point(0, 0);
            Robot r = new Robot(room, origo);

            // Act
            ICommand command = new East(2);
            r.ExecuteCommand(new East(2));
            r.ExecuteCommand(new South(1));
            r.ExecuteCommand(new West(1));
            r.ExecuteCommand(new North(1));
            r.ExecuteCommand(new West(1));

            // Assert
            Assert.That(room.CleanedSquares(), Is.EqualTo(5));
        }
    }
}