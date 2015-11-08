using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSE662_P3;

namespace SSE662_P3_Test
{
    /// <summary>
    /// Summary description for CalculateTest
    /// </summary>
    [TestClass]
    public class CalculateTest
    {
        public CalculateTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ComputeTest()
        {
            double op1 = 1;
            double op2 = 2;

            Assert.AreEqual(3 ,Calculate.Compute("+", op1, op2));
            Assert.AreEqual(-1 ,Calculate.Compute("-", op1, op2));
            Assert.AreEqual(2 ,Calculate.Compute("*", op1, op2));
            Assert.AreEqual(0.5 ,Calculate.Compute("/", op1, op2));
        }

        [TestMethod]
        public void AreaOfCircleTest()
        {
            double radius = 5;
            double expectedOutcome = Math.PI * Math.Pow(5, 2);

            Assert.AreEqual(expectedOutcome, Calculate.AreaOfCircle(radius));
        }

        [TestMethod]
        public void GetFactorsTest()
        {
            double number = 18;
            List<double> expectedFactors = new List<double>() { 1, 2, 3, 6, 9, 18 };

            Assert.IsTrue(expectedFactors.Except(Calculate.GetFactors(number)).ToArray().Length == 0);    
        }
    }
}
