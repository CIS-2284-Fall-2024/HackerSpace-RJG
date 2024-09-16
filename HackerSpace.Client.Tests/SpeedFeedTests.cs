using HackerSpace.Client.Models;



namespace HackerSpace.Client.Tests
{
    [TestClass]
    public class SpeedFeedTests
    {
        [TestMethod]
        public void Test2000RPMWith4TeethChiploadpt01Is80()
        {
            //Test that RPM 2000, Teeth 4, ChipLoad 0.01 = 80
            var expectedResult = 80;
            //Get actualResult
            var classUnderTest = new SpeedFeed();
            classUnderTest.Rpm = 2000;
            classUnderTest.Teeth = 4;
            classUnderTest.ChipLoad = 0.01f;
            var actualResult = classUnderTest.FeedRate;
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestExceptionThrownWhenTeethIsZero()
        {
            //Test that an exception is thrown when Teeth is 0
            var classUnderTest = new SpeedFeed();
            Assert.ThrowsException<ArgumentException>(() => classUnderTest.Teeth = 0);
        }

        [TestMethod]
        public void TestExceptionThrownWhenTeethIsLessThanZero()
        {
            //Test that an exception is thrown when Teeth is 0
            var classUnderTest = new SpeedFeed();
            Assert.ThrowsException<ArgumentException>(() => classUnderTest.Teeth = -1);
        }
    }
}