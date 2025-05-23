using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class HtmlFormatterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            var formatter = new HtmlFormatter();
            
            var result = formatter.FormatAsBold("abc");
            
            Assert.That(result, Is.EqualTo("<strong>abc</strong>"));
        }
    }
}