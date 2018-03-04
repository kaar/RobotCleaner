﻿using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace RobotCleaner.Tests {
    [TestFixture]
    public class PathTests {
        [Test]
        public void GetPoints_MovingYAxis_AllPoints() {
            // Arrange
            Point start = new Point(0, 0);
            Point end = new Point(0, 2);

            // Act
            List<Point> points = Path.GetPoints(start, end)
                                     .ToList();

            // Assert
            Assert.That(points, Is.EquivalentTo(new List<Point> { new Point(0, 0), new Point(0, 1), new Point(0, 2) }));
        }

        [Test]
        public void GetPoints_MovingXAxis_AllPoints() {
            // Arrange
            Point start = new Point(0, 0);
            Point end = new Point(2, 0);

            // Act
            List<Point> points = Path.GetPoints(start, end)
                                     .ToList();

            // Assert
            Assert.That(points, Is.EquivalentTo(new List<Point> { new Point(0, 0), new Point(1, 0), new Point(2, 0) }));
        }

        [Test]
        public void GetPoints_MovingNegativeXAxis_AllPoints() {
            // Arrange
            Point start = new Point(2, 0);
            Point end = new Point(0, 0);

            // Act
            List<Point> points = Path.GetPoints(start, end)
                                     .ToList();

            // Assert
            Assert.That(points, Is.EquivalentTo(new List<Point> { new Point(0, 0), new Point(1, 0), new Point(2, 0) }));
        }

        [Test]
        public void GetPoints_MovingNegativeYAxis_AllPoints() {
            // Arrange
            Point start = new Point(0, 2);
            Point end = new Point(0, 0);

            // Act
            List<Point> points = Path.GetPoints(start, end)
                                     .ToList();

            // Assert
            Assert.That(points, Is.EquivalentTo(new List<Point> { new Point(0, 0), new Point(0, 1), new Point(0, 2) }));
        }

        [Test]
        public void GetPoints_NoMoving_OnePoint() {
            // Arrange
            Point start = new Point(0, 0);
            Point end = new Point(0, 0);

            // Act
            List<Point> points = Path.GetPoints(start, end)
                                     .ToList();

            // Assert
            Assert.That(points.Count,Is.EqualTo(1));
            Assert.That(points, Is.EqualTo(new List<Point> { new Point(0, 0) }));
        }
    }
}