using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace RobotCleaner.Tests {
    [TestFixture]
    public class RobotCleanerTests {
        [Test]
        public void Clean() {
            // Act
            // RobotCleaner r = new RobotCleaner(new Room());
            int x = 0;
            int y = 0;
            Room room = new Room();
            Robot r = new Robot(room, new Point(x, y));
            //r.ExecuteCommand(new Command("E", 2));
            //Assert.That(room.CleanedSquares, Is.EquivalentTo(2));
        }
    }
}