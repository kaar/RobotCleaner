using NUnit.Framework;

namespace RobotCleaner.Tests {
    [TestFixture]
    public class CommandTests {
        [Test]
        public void Execute_TakeTwoStepsToEast() {
            var command = new Command("E", 2);

            int x = 0;
            int y = 0;

            // Act
            Point endpoint = command.Execute(new Point(x, y));

            // Assert
            Assert.That(endpoint.X, Is.EqualTo(2));
            Assert.That(endpoint.Y, Is.EqualTo(0));
        }
    }
}