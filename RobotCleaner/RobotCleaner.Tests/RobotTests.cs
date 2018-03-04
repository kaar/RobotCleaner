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
            Assert.That(r.CurrentPos, Is.EqualTo(new Point(2, 0)));
            r.ExecuteCommand(new South(1));
            Assert.That(r.CurrentPos, Is.EqualTo(new Point(2, -1)));
            r.ExecuteCommand(new West(1));
            Assert.That(r.CurrentPos, Is.EqualTo(new Point(1, -1)));
            r.ExecuteCommand(new North(1));
            Assert.That(r.CurrentPos, Is.EqualTo(new Point(1, 0)));
            r.ExecuteCommand(new West(1));

            // Assert
            Assert.That(room.CleanedSquares(), Is.EqualTo(5));
        }

        [Test]
        public void Clean_InputFromExample_() {
            // Arrange
            // Act
            var startX = 10;
            var startY = 22;
            var room = new Room();
            Robot r = new Robot(new Room(), new Point(startX, startY));
            r.ExecuteCommand(new East(2));
            Assert.That(r.CurrentPos(), Is.EqualTo(new Point(12, 22)));
            r.ExecuteCommand(new North(1));
            Assert.That(r.CurrentPos(), Is.EqualTo(new Point(12, 23)));

            // Assert
            Assert.That(room.CleanedSquares(), Is.EqualTo(4));
        }
    }
}