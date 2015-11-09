using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSE662_P3;

namespace SSE662_P3_Test
{
    /// <summary>
    /// Summary description for CompanyTest
    /// </summary>
    [TestClass]
    public class CompanyTest
    {
        public CompanyTest()
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
        public void CompanyConstructorTest()
        {
            Company c = new Company();
            Assert.IsNotNull(c);  
        }

        [TestMethod]
        public void EmployeeConstructorTest()
        {
            Employee e = new Employee("John", "Doe");
            Assert.IsNotNull(e);

            Assert.AreEqual("John", e.FirstName);
            Assert.AreEqual("Doe", e.LastName);
        }

        [TestMethod]
        public void AddEmployeeTest()
        {
            Company c = new Company();
            Employee e = new Employee("John", "Doe");

            c.AddEmployee(e);
            Assert.IsTrue(c.GetNumberOfEmployees() == 1);
        }

        [TestMethod]
        public void RemoveEmployeeTest()
        {
            Company c = new Company();
            Employee e = new Employee("John", "Doe");

            c.RemoveEmployee(e);
            Assert.IsTrue(c.GetNumberOfEmployees() == 0);
        }

        [TestMethod]
        public void GetEmployeePositionTest()
        {
            const string POSITION = "Supervisor";
            Company c = new Company();
            Employee e = new Employee("John", "Doe");
            e.Position = POSITION;

             c.AddEmployee(e);

            Assert.AreEqual(POSITION, c.GetEmployeePosition(e));
        }
    }  
}
