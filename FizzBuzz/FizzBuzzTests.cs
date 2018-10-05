using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        [TestCase(33)]
        public void FizzForMultiplesOf3(int n)
        {
            Assert.That(FizzBuzz.Say(n), Is.EqualTo("Fizz"));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(25)]
        [TestCase(50000)]
        public void BuzzForMultiplesOf5(int n)
        {
            Assert.That(FizzBuzz.Say(n), Is.EqualTo("Buzz"));
        }

        [TestCase(15)]
        [TestCase(30)]
        [TestCase(165000)]
        public void FizzBuzzForMultiplesOf3And5(int n)
        {
            Assert.That(FizzBuzz.Say(n), Is.EqualTo("FizzBuzz"));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(7)]
        [TestCase(11)]
        [TestCase(13)]
        public void SayTheNumberIfNotDivisibleBy3Or5(int n)
        {
            Assert.That(FizzBuzz.Say(n), Is.EqualTo(n.ToString()));
        }
    }
}
