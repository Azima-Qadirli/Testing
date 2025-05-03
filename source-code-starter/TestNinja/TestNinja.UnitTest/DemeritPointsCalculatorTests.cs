using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class DemeritPointsCalculatorTests
    {
        //Burda daha AAA metodu kimi deyilde SetUp ile yaza bilerik
        private DemeritPointsCalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new DemeritPointsCalculator();
        }
        
        [Test]
        [TestCase(-1)]
        [TestCase(301)]
        public void DemeritPointsCalculator_InvalidError_ThrowsArgumentException(int speed)
        {
            /*var calculator = new DemeritPointsCalculator();*/
            Assert.That(() => _calculator.CalculateDemeritPoints(speed),Throws.TypeOf<ArgumentOutOfRangeException>());
        }

        [Test]
        [TestCase(64)]
        [TestCase(65)]
        public void DemeritPointsCalculator_SpeedIsLessThanOrEqualToLimit_ReturnsZero(int speed)
        {
            Assert.That(() => _calculator.CalculateDemeritPoints(speed), Is.EqualTo(0));
        }

        [Test]
        public void DemeritPointsCalculator_SpeedIsGreaterThanLimit_ReturnsDemeritPoints()
        {
            var result = _calculator.CalculateDemeritPoints(70);
            Assert.That(result, Is.EqualTo(1));
        }
        
    }
}