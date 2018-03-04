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
        public void Robot_OnStart_InitialVertexCleaned() {
            // Act
            int actual = room.CleanedSquares();

            // Assert
            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void ExecuteCommand_TwoStepsEast_CleanThreeSquares() {
            // Act
            robot.ExecuteCommand(new East(2));

            // Assert
            Assert.That(room.CleanedSquares(), Is.EqualTo(3));
        }

        [Test]
        public void Clean_Two() {
            // Act
            robot.ExecuteCommand(new East(2));
            robot.ExecuteCommand(new South(1));

            // Assert
            Assert.That(room.CleanedSquares(), Is.EqualTo(4));
        }

        [Test]
        public void Clean_ThreeCommands() {
            // Arrange

            // Act
            robot.ExecuteCommand(new East(2));
            robot.ExecuteCommand(new South(1));
            robot.ExecuteCommand(new West(1));

            // Assert
            Assert.That(room.CleanedSquares(), Is.EqualTo(5));
        }

        [Test]
        public void Clean_FourCommands() {
            // Arrange

            // Act
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