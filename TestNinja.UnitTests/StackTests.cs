using NUnit.Framework;
using System;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Fundamentals.Stack<string> stack = new Fundamentals.Stack<string>();

        [SetUp]
        public void Setup()
        {
            stack = new Fundamentals.Stack<string>();
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Push_ArgumentIsNull_ThowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => stack.Push(null));
        }

        [Test]
        public void Push_ValidArgument_AddingArgumentToList()
        {
            stack.Push("nika");

            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void Pop_StackWithObjects_ReturnLastOne()
        {
            stack.Push("nika");
            stack.Push("ana");
            stack.Push("gio");

            var result = stack.Pop();

            Assert.That(result, Is.EqualTo("gio"));
        }

        [Test]
        public void Pop_StackWithObjects_RemovesLastObject()
        {
            stack.Push("nika");
            stack.Push("ana");
            stack.Push("gio");

            stack.Pop();

            Assert.That(stack.Count, Is.EqualTo(2));
        }

        [Test]
        public void Peek_EmptyStack_ThrowInvalidOperationException()
        {
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Test]
        public void Peek_StackWithObjects_ReturnLastObject()
        {
            stack.Push("nika");
            stack.Push("ana");

            var result = stack.Peek();

            Assert.That(result, Is.EqualTo("ana"));
        }

        [Test]
        public void Peek_StackWithObjects_DoesnotRemoveObhectOnTheTopOfStack()
        {
            stack.Push("nika");
            stack.Push("ana");

            stack.Peek();

            Assert.That(stack.Count, Is.EqualTo(2));
        }
    }
}
