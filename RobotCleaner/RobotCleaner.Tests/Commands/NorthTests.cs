using NUnit.Framework;
using RobotCleaner.Commands;

namespace RobotCleaner.Tests.Commands {
    [TestFixture]
    public class NorthTests {
        public static Point Origo { get; } = new Point(0, 0);

        [Test]
        public void Execute_OneStepFromOrigo_() {
            // Arrange
            var north = new North(1);

            // Act
            Point endPoint = north.Execute(Origo);

            // Assert
            Assert.That(endPoint, Is.EqualTo(new Point(0, 1)));
        }

        [Test]
        public void Execute_MoveTwoSteps() {
            // Arrange
            var north = new North(2);

            // Act
            Point endPoint = north.Execute(Origo);

            // Assert
            Assert.That(endPoint, Is.EqualTo(new Point(0, 2)));
        }
    }
}