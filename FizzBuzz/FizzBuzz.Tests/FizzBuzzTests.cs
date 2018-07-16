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
            Assert.AreEqual("2", _fizzBuzz.Print(2));
        }

        [TestMethod]
        public void ShouldPrintFizz() {
            Assert.AreEqual("Fizz", _fizzBuzz.Print(3));
        }

        // triangulate by using 2 or more example for test values, if solution is not obvious
        [TestMethod]
        public void ShouldPrintBuzz() {
            Assert.AreEqual("Buzz", _fizzBuzz.Print(5));
            Assert.AreEqual("Buzz", _fizzBuzz.Print(10));
        }

        [TestMethod]
        public void ShouldPrintFizzBuzz() {
            Assert.AreEqual("FizzBuzz", _fizzBuzz.Print(15));
            Assert.AreEqual("FizzBuzz", _fizzBuzz.Print(30));
        }
    }
}
