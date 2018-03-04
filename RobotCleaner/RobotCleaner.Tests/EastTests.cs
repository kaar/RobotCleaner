using NUnit.Framework;

namespace RobotCleaner.Tests {
    [TestFixture]
    public class EastTests {
        [Test]
        public void Execute_TakeTwoSteps_XIncremented() {
            // Arrange
            var command = new East(2);

            int x = 0;
            int y = 0;

            // Act
            Point endpoint = command.Execute(new Point(x, y));

            // Assert
            Assert.That(endpoint.X, Is.EqualTo(2));
            Assert.That(endpoint.Y, Is.EqualTo(0));
        }
    }
}