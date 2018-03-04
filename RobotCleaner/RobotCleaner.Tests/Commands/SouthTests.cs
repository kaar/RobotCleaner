using NUnit.Framework;
using RobotCleaner.Commands;

namespace RobotCleaner.Tests.Commands {
    [TestFixture]
    public class SouthTests {
        [Test]
        public void Execute() {
            // Arrange
            var startPoint = new Point(0, 0);
            var south = new South(2);

            // Act
            Point endPoint = south.Execute(startPoint);

            // Assert
            Assert.That(endPoint, Is.EqualTo(new Point(0, -2)));
        }
    }
}