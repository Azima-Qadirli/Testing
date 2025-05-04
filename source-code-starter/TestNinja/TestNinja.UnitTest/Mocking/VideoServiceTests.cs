using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTest.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        private Mock<IFileReader> _fileReader;
        private VideoService _service;

        [SetUp]
        public void Setup()
        {
            _fileReader = new Mock<IFileReader>();
            _service = new VideoService(_fileReader.Object);
        }
        
        
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnsError()
        {
            _fileReader.Setup(fr=>fr.Read("video.txt")).Returns("");
            var result = _service.ReadVideoTitle();
            Assert.That(result,Does.Contain("error").IgnoreCase);
        }
    }
}