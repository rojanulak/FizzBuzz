using FizzBuzzLib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzUnitTest
{

    [TestFixture]
    public class FizzBuzzTest
    {


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(3, "Fizz")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(8, "8")]
        [TestCase(-100, "Buzz")]
        public void When_you_divide_by_3_or_5_need_to_return_fizz_or_buzz(int number, string expectedMsg)
        {
            var fizzBuzzEngine = GetFizzBuzzEngine(100);

            Assert.AreEqual(expectedMsg, fizzBuzzEngine.GetOutputResponse(number));

        }

        [Test]
        [TestCase(8, "Even")]
        [TestCase(7, "7")]
        public void When_you_divide_by_2_need_to_return_odd(int number, string expectedMsg)
        {
            var fizzBuzzEngine = GetFizzBuzzEngine(100);
            fizzBuzzEngine.AddTestParm(2, "Even");
            Assert.AreEqual(expectedMsg, fizzBuzzEngine.GetOutputResponse(number));

        }

        [Test]
        public void Should_not_return_empty_response()
        {
            var fizzBuzzEngine = GetFizzBuzzEngine(100);
            Assert.IsTrue(fizzBuzzEngine.GetOutputResponse(10).Length > 0);
        }

        [Test]
        [Explicit]
        public void Should_be_able_to_handle_int_max()
        {
            var fizzBuzzEngine = GetFizzBuzzEngine(int.MaxValue);
            Assert.IsTrue(fizzBuzzEngine.GenerateFizzBuzzResult().Length > 0);
        }

        [Test]
        public void Shouldbe_able_to_write_to_fileStream()
        {
            var fizzBuzzEngine = GetFizzBuzzEngine(100);
            Assert.IsTrue(fizzBuzzEngine.GenerateFizzBuzzResult().Length > 0);
        }


        private FizzBuzz GetFizzBuzzEngine(int maxBound)
        {
            FizzBuzz fizzBuzzEngine = new FizzBuzz(maxBound);
            fizzBuzzEngine.AddTestParm(3, "Fizz");
            fizzBuzzEngine.AddTestParm(5, "Buzz");
            return fizzBuzzEngine;
        }

    }
}
