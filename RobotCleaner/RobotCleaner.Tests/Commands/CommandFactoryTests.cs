using System;
using NUnit.Framework;
using RobotCleaner.Commands;

namespace RobotCleaner.Tests.Commands {
    [TestFixture]
    public class CommandFactoryTests {
        [Test]
        public void Create_DirectionEast_BuildEastCommand() {
            // Arrange

            // Act
            Command actual = CommandFactory.Create("E", 10);

            // Assert
            Assert.That(actual, Is.TypeOf(typeof(East)));
        }

        [Test]
        public void Create_DirectionWest_BuildWest() {
            // Arrange

            // Act
            Command actual = CommandFactory.Create("W", 10);

            // Assert
            Assert.That(actual, Is.TypeOf(typeof(West)));
        }

        [Test]
        public void Create_DirectionSouth_BuildSouth() {
            // Arrange

            // Act
            Command actual = CommandFactory.Create("S", 10);

            // Assert
            Assert.That(actual, Is.TypeOf(typeof(South)));
        }

        [Test]
        public void Create_DirectionNorth_BuildNorth() {
            // Arrange

            // Act
            Command actual = CommandFactory.Create("N", 10);

            // Assert
            Assert.That(actual, Is.TypeOf(typeof(North)));
        }

        [Test]
        public void Create_UnknownDirection_ThrowsException() {
            // Act & Assert
            Assert.Throws<Exception>(() => CommandFactory.Create("X", 10));
        }
    }
}