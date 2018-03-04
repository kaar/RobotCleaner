using NUnit.Framework;

namespace RobotCleaner.Tests {
    public class PointTests {
        [Test]
        public void EqualTo_SamePoints_IsEqual() {
            // Arrange
            // Act
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 0);

            // Assert
            Assert.That(p1, Is.EqualTo(p2));
        }

        [Test]
        public void EqualTo_TwoDifferentPoints_NotEqual() {
            // Arrange
            Point p1 = new Point(0, 0);
            Point p2 = new Point(0, 1);

            // Act & Assert
            Assert.That(p1, Is.Not.EqualTo(p2));
        }

        [Test]
        public void EqualTo_DifferentXValues_TwoPointsNotEqual() {
            // Arrange
            Point p1 = new Point(0, 0);
            Point p2 = new Point(1, 0);

            // Act & Assert
            Assert.That(p1, Is.Not.EqualTo(p2));
        }

        [Test]
        public void ToString() {
            // Arrange
            Point p1 = new Point(0, 0);

            // Act & Assert
            Assert.That(p1.ToString(), Is.EqualTo("(0, 0)"));
        }
    }
}