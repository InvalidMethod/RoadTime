using NUnit.Framework;
using RoadTime;

namespace DriverTimeUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0, 6, 4, 0, 0)]
        [TestCase(1, 0, 0, 0, 0)]
        [TestCase(1, 6, 4, 1, 0)]
        [TestCase(8, 6, 4, 6, 2)]
        [TestCase(10, 6, 4, 6, 4)]
        [TestCase(19, 6, 4, 12, 7)]
        [TestCase(21, 6, 4, 13, 8)]
        [TestCase(43, 6, 4, 27, 16)]
        [TestCase(43, 5, 5, 23, 20)]
        public void TestDriverTimes (int totalTime, int maxDriveTime, int minRestTime, int expectedDriveTime, int expectedRestTime)
        {
            (int driveTime, int restTime) testResult = DriverTimeCalculator.FindDriveAndRestTime(totalTime, maxDriveTime, minRestTime);
            Assert.AreEqual(testResult.driveTime, expectedDriveTime);
            Assert.AreEqual(testResult.restTime, expectedRestTime);
        }
    }
}