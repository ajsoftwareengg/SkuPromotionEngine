using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SkuPromotionEngine;
namespace UnitTestSkuPromotionEngine
{
    /// <summary>
    /// Summary description for UnitTestSkuPromotionEngline
    /// </summary>
    [TestClass]
    public class UnitTestSkuPromotionEngline
    {
        public UnitTestSkuPromotionEngline()
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

        #region Test Method For Order1 Senarion
        [TestMethod]
        public void TestMethod1()
        {
            SkuPromotionEngine.Program.Order1();    
            // TODO: Add test logic here
            //
        }
        #endregion

        #region Test Method For Order2 Senarion
        [TestMethod]
        public void TestMethod2()
        {
            SkuPromotionEngine.Program.Order2();
            // TODO: Add test logic here
            //
        }
        #endregion

        #region Test Method For Order3 Senarion
        [TestMethod]
        public void TestMethod3()
        {
            SkuPromotionEngine.Program.Order3();
            // TODO: Add test logic here
            //
        #endregion

        }
    }
}
