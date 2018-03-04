using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace RobotCleaner.Tests {
    [TestFixture]
    public class PathTests {
        [Test]
        public void GetPath() {
            // Arrange
            Point start = new Point(0, 0);
            Point end = new Point(0, 2);

            Path path = new Path(start, end);

            // Act
            List<Point> points = path.GetPath()
                                     .ToList();

            // Assert
            Assert.That(points, Is.EqualTo(new List<Point> { new Point(0, 0), new Point(0, 1), new Point(0, 2) }));
        }
    }
}