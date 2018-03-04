using NUnit.Framework;

namespace RobotCleaner.Tests {
    [TestFixture]
    public class EastTests {
        [Test]
        public void Execute_TakeTwoSteps_XIncremented() {
            // Arrange
            var command = new East(2);

            var startPoint = new Point(0, 0);

            // Act
            Point endpoint = command.Execute(startPoint);

            // Assert
            Assert.That(endpoint.X, Is.EqualTo(2));
            Assert.That(endpoint.Y, Is.EqualTo(0));
        }
    }

    [TestFixture]
    public class WestTests {
        [Test]
        public void Execute() {
            // Arrange
            var startPoint = new Point(0, 0);

            // Act
            var west = new West(2);

            // Assert
        }
    }

}