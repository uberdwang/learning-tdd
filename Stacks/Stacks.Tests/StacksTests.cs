using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stacks.Library;

namespace Stacks.Tests
{
    [TestClass]
    public class StacksTests
    {
        private MyStacks _myStacks;

        public StacksTests() {
            _myStacks = new MyStacks();
        }

        [TestMethod]
        public void ShouldPrint1()
        {
           Assert.AreEqual("1", _myStacks.Print());
        }
    }
}
