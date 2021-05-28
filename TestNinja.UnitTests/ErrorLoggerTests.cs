using NUnit.Framework;
using TestNinja.Exceptions;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        private ErrorLogger logger = new ErrorLogger();

        [SetUp]
        public void Setup()
        {
            logger = new ErrorLogger();
        }

        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            logger.Log("a");

            Assert.That(logger.LastError, Is.EqualTo("a"));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
            //Assert.That(() => logger.Log(error), Throws.Exception.TypeOf<MyException>()); //throw custom exception
        }
    }
}
