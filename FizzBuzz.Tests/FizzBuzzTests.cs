using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz.Library;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        private FizzBuzzService _fizzBuzz;

        // constructor & create instance of FizzBuzzService
        public FizzBuzzTests() {
            _fizzBuzz = new FizzBuzzService();
        }

        // start by testing default behavior by returning number argument
        [TestMethod]
        public void ShouldPrintNumber() {
            Assert.AreEqual("1", _fizzBuzz.Print(1));
        }
    }
}
