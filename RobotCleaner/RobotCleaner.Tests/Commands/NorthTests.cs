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
            Assert.That(endPoint, Is.EqualTo(new Point(0, 2)));
        }

        [Test]
        public void Execute_UpOne() {
            // Arrange
            var startPoint = new Point(1, -1);
            var north = new North(1);

            // Act
            Point endPoint = north.Execute(startPoint);

            // Assert
            Assert.That(endPoint, Is.EqualTo(new Point(1, 0)));
        }
    }
}