using EnigmaSim.EnigmaEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EnigmaSim.Model;
using EnigmaSim.Components.Rotor;

namespace EnigmaSim.Tests
{
    
    
    /// <summary>
    ///This is a test class for Basic3WheelTest and is intended
    ///to contain all Basic3WheelTest Unit Tests
    ///</summary>
    [TestClass()]
    public class Basic3WheelTest
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


        ///// <summary>
        /////A test for Basic3Wheel Constructor
        /////</summary>
        //[TestMethod()]
        //public void Basic3WheelConstructorTest()
        //{
        //    string fastRotorName = string.Empty; // TODO: Initialize to an appropriate value
        //    string middleRotorName = string.Empty; // TODO: Initialize to an appropriate value
        //    string slowRotorName = string.Empty; // TODO: Initialize to an appropriate value
        //    string reflectorName = string.Empty; // TODO: Initialize to an appropriate value
        //    Basic3Wheel target = new Basic3Wheel(fastRotorName, middleRotorName, slowRotorName, reflectorName);
        //    Assert.Inconclusive("TODO: Implement code to verify target");
        //}

        /// <summary>
        ///A test for EnigmaSim.Model.IEnigma.DecipherCharacter
        ///</summary>
        [TestMethod()]
        [DeploymentItem("EnigmaSim.EnigmaEngine.dll")]
        public void DecipherCharacterTest()
        {
            string fastRotorName = "Rotor I";
            string middleRotorName = "Rotor II";
            string slowRotorName = "Rotor III";
            string reflectorName = "reflector B";
            IEnigma target = new Basic3Wheel(fastRotorName, middleRotorName, slowRotorName, reflectorName); // TODO: Initialize to an appropriate value
            char input = 'A'; 
            char expected = 'B'; 
            char actual;
            actual = target.DecipherCharacter(input);
            //Assert.AreEqual(expected, actual);
            actual = target.DecipherCharacter(input);
            //Assert.AreEqual(expected, actual);
        }
    }
}
