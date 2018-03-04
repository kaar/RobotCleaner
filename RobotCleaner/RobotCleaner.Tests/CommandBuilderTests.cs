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
    }
}