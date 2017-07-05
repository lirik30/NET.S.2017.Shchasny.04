using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static NumericAlgorithms.NAlgorithms;

namespace NumericAlgorithms.Tests
{
    [TestClass]
    public class NAlgorithmsTests
    {
        public TestContext TestContext { get; set; }


        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\PositiveTestVariants.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("NumericAlgorithms.Tests\\PositiveTestVariants.xml")]
        [TestMethod]
        public void FindRootOfNumber_PositiveTests()
        {
            double actual = FindRootOfNumber(
                Convert.ToDouble(TestContext.DataRow["number"]),
                Convert.ToInt32(TestContext.DataRow["n"])
            );
            double expected = Convert.ToDouble(TestContext.DataRow["expectedResult"]);
            Assert.AreEqual(expected, actual);
        }


        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\ThrowsArgumentOutOfRangeExceptionTestVariants.xml",
            "TestCase",
            DataAccessMethod.Sequential)]
        [DeploymentItem("NumericAlgorithms.Tests\\ThrowsArgumentOutOfRangeExceptionTestVariants.xml")]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FindRootOfNumber_ThrowsArgumentOutOfRangeException()
        {
            FindRootOfNumber(
                Convert.ToDouble(TestContext.DataRow["number"]),
                Convert.ToInt32(TestContext.DataRow["n"])
            );
        }

    }
}
