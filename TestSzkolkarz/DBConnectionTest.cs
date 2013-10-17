﻿using szkolkarz.core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;

namespace TestSzkolkarz
{
    
    
    /// <summary>
    ///This is a test class for DBConnectionTest and is intended
    ///to contain all DBConnectionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DBConnectionTest
    {


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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for DBConnection Constructor
        ///</summary>
        [TestMethod()]
        public void DBConnectionConstructorTest()
        {
            DBConnection target = new DBConnection();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for openConnection
        ///</summary>
        [TestMethod()]
        public void openConnectionTest()
        {
            DBConnection target = new DBConnection(); // TODO: Initialize to an appropriate value
            target.openConnection();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for executeQuery
        ///</summary>
        [TestMethod()]
        public void executeQueryTest()
        {
            DBConnection target = new DBConnection(); // TODO: Initialize to an appropriate value
            string query = string.Empty; // TODO: Initialize to an appropriate value
            SqlDataReader expected = null; // TODO: Initialize to an appropriate value
            SqlDataReader actual;
            actual = target.executeQuery(query);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for closeConnection
        ///</summary>
        [TestMethod()]
        public void closeConnectionTest()
        {
            DBConnection target = new DBConnection(); // TODO: Initialize to an appropriate value
            target.closeConnection();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
