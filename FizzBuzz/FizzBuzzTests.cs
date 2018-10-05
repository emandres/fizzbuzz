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
        [TestCase(300)]
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

    public class FizzBuzz
    {
        public static string Say(int n)
        {
            if (n % 3 == 0)
            {
                return "Fizz";
            }

            if (n % 5 == 0)
            {
                return "Buzz";
            }

            return n.ToString();
        }
    }
}
