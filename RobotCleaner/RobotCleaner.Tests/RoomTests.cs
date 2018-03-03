﻿using System.Collections.Generic;
using NUnit.Framework;

namespace RobotCleaner.Tests {
    public class RoomTests {
        private Room room;

        [SetUp]
        public void SetUp() {
            room = new Room();
        }

        [Test]
        public void AddPath_TwoUniquePointsAdded_CleanReturnsTwo() {
            // Act
            room.AddPath(new List<Point> { new Point(1, 1), new Point(1, 2) });

            // Assert
            int actual = room.CleanedSquares();
            Assert.That(actual, Is.EqualTo(2));
        }

        [Test]
        public void AddPath_SamePointAddedTwice_ReturnOne() {
            // Act
            room.AddPath(new List<Point> { new Point(1, 1), new Point(1, 1) });

            // Assert
            int actual = room.CleanedSquares();
            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void AddPath_TwoUniqueTwoSame_ReturnTwoCleaned() {
            // Act
            room.AddPath(new List<Point> { new Point(1, 1), new Point(1, 1), new Point(1, 2) });

            // Assert
            int actual = room.CleanedSquares();
            Assert.That(actual, Is.EqualTo(2));
        }
    }
}