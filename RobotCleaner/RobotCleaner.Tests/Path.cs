using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace RobotCleaner.Tests {
    [TestFixture]
    public class PathTests {
        [Test]
        public void GetPoints_MovingYAxis_AllPoints() {
            // Arrange
            Point start = new Point(0, 0);
            Point end = new Point(0, 2);

            Path path = new Path(start, end);

            // Act
            List<Point> points = path.GetPoints()
                                     .ToList();

            // Assert
            Assert.That(points, Is.EquivalentTo(new List<Point> { new Point(0, 0), new Point(0, 1), new Point(0, 2) }));
        }

        [Test]
        public void GetPoints_MovingXAxis_AllPoints() {
            // Arrange
            Point start = new Point(0, 0);
            Point end = new Point(2, 0);

            Path path = new Path(start, end);

            // Act
            List<Point> points = path.GetPoints()
                                     .ToList();

            // Assert
            Assert.That(points, Is.EquivalentTo(new List<Point> { new Point(0, 0), new Point(1, 0), new Point(2, 0) }));
        }

        [Test]
        public void GetPoints_MovingNegativeXAxis_AllPoints() {
            // Arrange
            Point start = new Point(2, 0);
            Point end = new Point(0, 0);

            Path path = new Path(start, end);

            // Act
            List<Point> points = path.GetPoints()
                                     .ToList();

            // Assert
            Assert.That(points, Is.EquivalentTo(new List<Point> { new Point(0, 0), new Point(1, 0), new Point(2, 0) }));
        }

        [Test]
        public void GetPoints_MovingNegativeYAxis_AllPoints() {
            // Arrange
            Point start = new Point(0, 2);
            Point end = new Point(0, 0);

            Path path = new Path(start, end);

            // Act
            List<Point> points = path.GetPoints()
                                     .ToList();

            // Assert
            Assert.That(points, Is.EquivalentTo(new List<Point> { new Point(0, 0), new Point(0, 1), new Point(0, 2) }));
        }

        [Test]
        public void Range() {
            // Act
            IEnumerable<int> positiveNumbers = GetRange(0, 2);
            IEnumerable<int> negativeNumbers = Enumerable.Range(-3, 3)
                                                         .Reverse()
                                                         .ToList();

            // Assert
            Assert.That(positiveNumbers, Is.EquivalentTo(new[] { 0, 1, 2 }));
            Assert.That(negativeNumbers, Is.EquivalentTo(new[] { -1, -2, -3 }));
        }

        public IEnumerable<int> GetRange(int start, int end) {
            return Enumerable.Range(start, end - start + 1);
        }
    }
}