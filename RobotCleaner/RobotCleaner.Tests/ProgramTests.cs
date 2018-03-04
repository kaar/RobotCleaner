using System;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace RobotCleaner.Tests {
    public class ProgramTests {
        private StringWriter stringWriter;

        [SetUp]
        public void SetUp() {
            stringWriter = new StringWriter();
            Console.SetOut(stringWriter);
        }

        [Test]
        public void Main_WithInputExample() {
            // Arrange
            const string testData = "2\n10 22\nE 2\nN 1\n";
            var sr = new StringReader(testData);
            Console.SetIn(sr);

            // Act
            string[] args = { };
            Program.Main(args);

            // Assert
            string result = stringWriter.ToString();
            Console.WriteLine(result);
            Assert.That(result, Is.EqualTo("=> Cleaned: 4\r\n"));
        }
    }
}