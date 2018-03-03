using NUnit.Framework;

namespace RobotCleaner.Tests {
    public class PointTests {
        [TestCase(1, 1, 9017)]
        [TestCase(1, 2, 9018)]
        [TestCase(2, 1, 9040)]
        [TestCase(1, 1, 9017)]
        public void GetHashCode_SameXY_DifferentHash(int x, int y, int expectedHash) {
            // Arrange
            var point = new Point(x, y);

            // Act
            int actualHash = point.GetHashCode();

            // Assert
            Assert.That(actualHash, Is.EqualTo(expectedHash));
        }
    }
}