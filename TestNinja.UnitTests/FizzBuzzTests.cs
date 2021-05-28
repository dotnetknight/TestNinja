using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void Output_WhenDevisableByThreeAndFive_ReturnsFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void Output_WhenPassingZero_ReturnsFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(0);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void Output_WhenDevisableByThree_ReturnsFizz()
        {
            var result = FizzBuzz.GetOutput(3);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void Output_WhenDevisableByFive_ReturnsBuzz()
        {
            var result = FizzBuzz.GetOutput(5);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void Output_WhenIsNotDevisableNorFiveNorThree_ReturnsSameNumber()
        {
            var result = FizzBuzz.GetOutput(1);

            Assert.That(result, Is.EqualTo("1"));
        }
    }
}
