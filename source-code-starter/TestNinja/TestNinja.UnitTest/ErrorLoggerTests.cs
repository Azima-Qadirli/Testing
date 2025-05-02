using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            var logger = new ErrorLogger();
            logger.Log("a");
            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            var logger = new ErrorLogger();
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            //bu test metodu her hansi event raise olarken istifade edile biler. burda arrange zamani mutleq lambda expression daxilinde
            //parametrler gonderilmelidir.
            var logger = new ErrorLogger();
            var id = Guid.Empty;    
            //to test a method that raises an event, we need to subscribe firstly as below, then assert it.
            logger.ErrorLogged += (sender, args) => { id = args;};
            
            logger.Log("a");
            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
            
        }
    }
}