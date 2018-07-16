using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using GenericStacks.Library;

namespace GenericStacks.Tests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void CanPopOffItem()
        {
            var stack = new MyStack<string>();
            stack.Push("foo");
            Assert.AreEqual("foo", stack.Pop());
        }

        [TestMethod]
        public void CanPopOffMultipleItems() {
            // fluent interface
            // method chaining, making multiple push calls back to back
            var stack = new MyStack<String>()
                .Push("foo")
                .Push("bar");

            Assert.AreEqual("bar", stack.Pop());
            Assert.AreEqual("foo", stack.Pop());
        }

        [TestMethod]
        public void CanPopFromEmptyStack() {
            var stack = new MyStack<string>();
            Assert.AreEqual(null, stack.Pop());
        }
    }
}
