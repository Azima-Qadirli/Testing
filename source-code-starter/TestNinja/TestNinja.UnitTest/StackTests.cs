using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> _stack;
        [SetUp]
        public void Setup()
        {
            _stack = new Stack<string>();
        }
        
        [Test]
        public void Push_ObjectIsNull_ThrowsArgumentNullException()
        {
            Assert.That(()=>_stack.Push(null),Throws.ArgumentNullException);
        }

        [Test]
        public void Push_ObjectIsNotNull_AddingObject()
        {
            _stack.Push("Aziko");
            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_ObjectIsZero_ThrowsInvalidOperationException()
        {
            Assert.That(()=>_stack.Pop(),Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_ObjectIsNotZero_ReturnsResult()
        {
            _stack.Push("Aziko");
            _stack.Push("Leylosh");
            var count = _stack.Count;
            var result = _stack.Pop();
            Assert.That(result,Is.EqualTo("Leylosh").IgnoreCase); 
        }

        [Test]
        public void Peek_ObjectIsZero_ThrowsInvalidOperationException()
        {
            Assert.That(()=>_stack.Peek(),Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_ObjectIsNotZero_ReturnsResult()
        {
            _stack.Push("Aziko");
            _stack.Push("Leylosh");
            var result = _stack.Peek();
            Assert.That(result,Is.EqualTo("Leylosh").IgnoreCase);
        }
    }
}