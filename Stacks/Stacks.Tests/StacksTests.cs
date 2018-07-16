using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks.Library;
using System;

namespace Stacks.Tests
{
    [TestClass]
    public class StacksTests
    {
        /*
            requirements:
            1. can pop item off stacks
            2. last-in first-out (LIFO) stacks
            3. doesn't fail on popping an empty stack
            4. can't push null (throw exception)
         */

        [TestMethod]
        public void CanPopOffItem()
        {
            var stack = new MyStack(100);
            stack.Push("foo");
            Assert.AreEqual("foo", stack.Pop());
        }

        [TestMethod]
        public void CanPopOffMultipleItems() {
            var stack = new MyStack(100);
            stack.Push("foo");
            stack.Push("bar");
            Assert.AreEqual("bar", stack.Pop());
            Assert.AreEqual("foo", stack.Pop());
        }

        [TestMethod]
        public void CanPopFromEmptyStack() {
            var stack = new MyStack(100);
            Assert.AreEqual(null, stack.Pop());
        }

        [TestMethod]
        public void ShouldFailWhenPushingNull() {
            var stack = new MyStack(100);
            Assert.ThrowsException<Exception>(() => {
                stack.Push(null);
            });
        }
    }
}
