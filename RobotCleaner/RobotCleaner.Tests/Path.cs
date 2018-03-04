using System;
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

            // Assert
            Assert.That(GetRange(0, 2), Is.EquivalentTo(new[] { 0, 1, 2 }));
            Assert.That(GetRange(0, -2), Is.EquivalentTo(new[] { 0, -1, -2 }));
            Assert.That(GetRange(-2, 2), Is.EquivalentTo(new[] { -2, -1, 0, 1, 2 }));
            Assert.That(GetRange(-1, -2), Is.EquivalentTo(new[] { -1, -2 }));
            Assert.That(GetRange(2, 4), Is.EquivalentTo(new[] { 2, 3, 4 }));
            Assert.That(GetRange(-2, -4), Is.EquivalentTo(new[] { -2, -3, -4 }));

        }

        [Test]
        public void Distance() {
            // Act

            // Assert
            Assert.That(GetDistance(0, 2), Is.EqualTo(2));
            Assert.That(GetDistance(1, 2), Is.EqualTo(1));
            Assert.That(GetDistance(-2, 2), Is.EqualTo(4));
        }

        public IEnumerable<int> GetRange(int start, int end) {
            if (end < start) {
                return Enumerable.Range(end, GetDistance(start, end) + 1);
            }

            return Enumerable.Range(start, GetDistance(start, end) + 1);
        }

        public int GetDistance(int x, int y) {
            return Math.Abs(y - x);
        }
    }
}