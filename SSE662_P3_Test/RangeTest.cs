using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSE662_P3;

namespace SSE662_P3_Test
{
    /// <summary>
    /// Summary description for RangeTest
    /// </summary>
    [TestClass]
    public class RangeTest
    {
        public RangeTest()
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
         public void InRangeTest()
        {
            int min = 5;
            int max = 10;

            int inRangeValue = 7;
            int outOfRangeValue = 45;

            Range range = new Range(min, max);

            Assert.IsTrue(range.InRange(inRangeValue));
            Assert.IsFalse(range.InRange(outOfRangeValue));

            List<int> listOfValues = new List<int>() { 1, 2, 3, 10, 0, 15, 25, 5, 7, 6 };

            Assert.IsTrue(range.InRange(listOfValues, inRangeValue));
            Assert.IsFalse(range.InRange(listOfValues, outOfRangeValue));
        }
    }
}
