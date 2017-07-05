using System;
using static NumericAlgorithms.NAlgorithms;
using NUnit.Framework;

namespace NumericAlgorithms.NUnitTests
{
    [TestFixture]
    public class NAlgorithmsTests
    {

        [TestCase(4, 2, ExpectedResult = 2)]
        [TestCase(169, 2, ExpectedResult = 13)]
        [TestCase(5032.84375, 5, ExpectedResult = 5.5)]
        [TestCase(34012224, 6, ExpectedResult = 18)]
        [TestCase(32768, 15, ExpectedResult = 2)]
        public double FindRootOfNumber_PositiveTests(double number, int n)
        {
            return FindRootOfNumber(number, n);
        }


        [TestCase(-4, 2)]
        [TestCase(0, -2)]
        [TestCase(1, 0)]
        [TestCase(0, 2)]
        public void FindRootOfNumber_ThrowsArgumentOutOfRangeException(double number, int n)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => FindRootOfNumber(number, n));
        }
    }
}
