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
        [Test]
        public void FizzFor3()
        {
            Assert.That(FizzBuzz.Say(3), Is.EqualTo("Fizz"));
        }

        [Test]
        public void BuzzFor5()
        {
            Assert.That(FizzBuzz.Say(5), Is.EqualTo("Buzz"));
        }

        [Test]
        public void SayTheNumberIfNotDivisibleBy3Or5()
        {
            Assert.That(FizzBuzz.Say(1), Is.EqualTo("1"));
        }
    }

    public class FizzBuzz
    {
        public static string Say(int n)
        {
            if (n == 3)
            {
                return "Fizz";
            }

            if (n == 5)
            {
                return "Buzz";
            }

            return n.ToString();
        }
    }
}
