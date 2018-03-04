using NUnit.Framework;
using RobotCleaner.Commands;

namespace RobotCleaner.Tests.Commands {
    [TestFixture]
    public class NorthTests {
        [Test]
        public void Execute() {
            // Arrange
            var startPoint = new Point(0, 0);
            var north = new North(2);

            // Act
            Point endPoint = north.Execute(startPoint);

            // Assert
            Assert.That(endPoint.X, Is.EqualTo(0));
            Assert.That(endPoint.Y, Is.EqualTo(2));
        }
    }
}