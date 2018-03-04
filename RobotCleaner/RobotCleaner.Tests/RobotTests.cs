using NUnit.Framework;
using RobotCleaner.Commands;

namespace RobotCleaner.Tests {
    public class RobotTests {
        private Room room;
        private Robot robot;

        [SetUp]
        public void SetUp() {
            room = new Room();
            robot = new Robot(room);
        }
        [Test]
        public void Robot_Started_OneVertexCleaned() {
            // Act

            // Assert
            Assert.That(room.CleanedSquares(), Is.EqualTo(1));
        }

        [Test]
        public void Clean() {
            // Arrange

            // Act
            ICommand command = new East(2);
            robot.ExecuteCommand(command);

            // Assert
            Assert.That(room.CleanedSquares(), Is.EqualTo(3));
        }

        [Test]
        public void Clean_Two() {
            // Arrange

            // Act
            ICommand command = new East(2);
            robot.ExecuteCommand(command);
            robot.ExecuteCommand(new South(1));

            // Assert
            Assert.That(room.CleanedSquares(), Is.EqualTo(4));
        }

        [Test]
        public void Clean_ThreeCommands() {
            // Arrange

            // Act
            ICommand command = new East(2);
            robot.ExecuteCommand(command);
            robot.ExecuteCommand(new South(1));
            robot.ExecuteCommand(new West(1));

            // Assert
            Assert.That(room.CleanedSquares(), Is.EqualTo(5));
        }

        [Test]
        public void Clean_FourCommands() {
            // Arrange

            // Act
            ICommand command = new East(2);
            robot.ExecuteCommand(new East(2));
            robot.ExecuteCommand(new South(1));
            robot.ExecuteCommand(new West(1));
            robot.ExecuteCommand(new North(1));
            robot.ExecuteCommand(new West(1));

            // Assert
            Assert.That(room.CleanedSquares(), Is.EqualTo(5));
        }

        [Test]
        public void Clean_InputFromExample_() {
            // Arrange
            // Act
            robot.ExecuteCommand(new East(2));
            robot.ExecuteCommand(new North(1));

            // Assert
            Assert.That(room.CleanedSquares(), Is.EqualTo(4));
        }
    }
}