using System;
using NUnit.Framework;

namespace RobotCleaner.Tests {
    [TestFixture]
    public class CommandBuilderTests {
        private CommandBuilder commandBuilder;

        [SetUp]
        public void SetUp() {
            commandBuilder = new CommandBuilder();
        }

        [Test]
        public void Create_DirectionEast_BuildEastCommand() {
            // Arrange

            // Act
            ICommand actual = commandBuilder.Create("E", 10);

            // Assert
            Assert.That(actual, Is.TypeOf(typeof(East)));
        }

        [Test]
        public void Create_DirectionWest_BuildWest() {
            // Arrange

            // Act
            ICommand actual = commandBuilder.Create("W", 10);

            // Assert
            Assert.That(actual, Is.TypeOf(typeof(West)));
        }

        [Test]
        public void Create_DirectionSouth_BuildSouth() {
            // Arrange

            // Act
            ICommand actual = commandBuilder.Create("S", 10);

            // Assert
            Assert.That(actual, Is.TypeOf(typeof(South)));
        }

        [Test]
        public void Create_DirectionNorth_BuildNorth() {
            // Arrange

            // Act
            ICommand actual = commandBuilder.Create("N", 10);

            // Assert
            Assert.That(actual, Is.TypeOf(typeof(North)));
        }

        [Test]
        public void Create_UnknownDirection_ThrowsException() {
            // Act & Assert
            Assert.Throws<Exception>(() => commandBuilder.Create("X", 10));
        }
    }
}