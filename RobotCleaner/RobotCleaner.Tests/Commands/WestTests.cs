using NUnit.Framework;
using RobotCleaner.Commands;

namespace RobotCleaner.Tests.Commands {
    [TestFixture]
    public class WestTests {
        [Test]
        public void Execute() {
            // Arrange
            var startPoint = new Point(0, 0);
            var west = new West(2);

            // Act
            Point endPoint = west.Execute(startPoint);

            // Assert
            Assert.That(endPoint, Is.EqualTo(new Point(-2, 0)));
        }
    }
}