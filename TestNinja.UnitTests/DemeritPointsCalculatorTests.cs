using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        private DemeritPointsCalculator demeritPointsCalculator = new DemeritPointsCalculator();

        [SetUp]
        public void Setup()
        {
            demeritPointsCalculator = new DemeritPointsCalculator();
        }

        //[Test]
        //public void CalculateDemeritPoints_SpeedIsLessThanZero_ThrowArgumentOutOfRangeException()
        //{
        //    Assert.Throws<ArgumentOutOfRangeException>(() => demeritPointsCalculator.CalculateDemeritPoints(-1));
        //}

        //[Test]
        //public void CalculateDemeritPoints_SpeedIsMoreThanMaxSpeed_ThrowArgumentOutOfRangeException()
        //{
        //    Assert.Throws<ArgumentOutOfRangeException>(() => demeritPointsCalculator.CalculateDemeritPoints(301));
        //}

        //[Test]
        //public void CalculateDemeritPoints_SpeedIsZero_ReturnZero()
        //{
        //    var result = demeritPointsCalculator.CalculateDemeritPoints(0);
        //    Assert.That(result, Is.EqualTo(0));
        //}

        //[Test]
        //public void CalculateDemeritPoints_SpeedIsLessThanSpeedLimit_ReturnZero()
        //{
        //    var result = demeritPointsCalculator.CalculateDemeritPoints(5);
        //    Assert.That(result, Is.EqualTo(0));
        //}

        //[Test]
        //public void CalculateDemeritPoints_SpeedIsMoreThanSpeedLimit_ReturnDemeritPoints()
        //{
        //    var result = demeritPointsCalculator.CalculateDemeritPoints(70);
        //    Assert.That(result, Is.EqualTo(1));
        //}

        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void CalculateDemeritPoints_WhenCalled_ReturnDemeritPoints(int speed)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => demeritPointsCalculator.CalculateDemeritPoints(speed));
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(64, 0)]
        [TestCase(65, 0)]
        [TestCase(66, 0)]
        [TestCase(70, 1)]
        [TestCase(75, 2)]
        public void CalculateDemeritPoints_SpeedIsOutOfRange_ThrowArgumentOutOfRangeException(int speed, int expectedResult)
        {
            var result = demeritPointsCalculator.CalculateDemeritPoints(speed);
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
