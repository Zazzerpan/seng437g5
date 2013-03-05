using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace DrillingCalculatorTests
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }

        [TestMethod]
        public void ZeroTest()//CodedUITestMethod1()
        {
            // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
            // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
            this.UIMap.PumpFactorZeroRecording();
            this.UIMap.PumpFactorZeroAssertion();
            
            
        }

        [TestMethod]
        public void NegTest()
        {
            this.UIMap.PumpFactorNegRecording();
            this.UIMap.PumpFactorNegAssertion();
        }

        [TestMethod]
        public void PosTest()
        {
            this.UIMap.PumpFactorPosRecording();
            this.UIMap.PumpFactorPosAssertion();
        }

        [TestMethod]
        public void NegTriplexTest()
        {
            this.UIMap.PumpFactorNegTriplexRecording();
            this.UIMap.PumpFactorNegTriplexAssertion();
        }

        [TestMethod]
        public void ZeroTriplexTest()
        {
            this.UIMap.PumpFactorZeroTriplexRecording();
            this.UIMap.PumpFactorZeroTriplexAssertion();
        }

        [TestMethod]
        public void PosTriplexTest()
        {
            this.UIMap.PumpFactorPosTriplexRecording();
            this.UIMap.PumpFactorPosTriplexAssertion();
        }

        [TestMethod]
        public void ConvertTest()
        {
            this.UIMap.PumpFactorConvertRecording();
            this.UIMap.PumpFactorConvertAssertion();
        }

        ///Test for Ton Miles
        ///

        [TestMethod]
        public void TonMilesZero()
        {
            this.UIMap.TonMilesZeroRecording();
            this.UIMap.TonMilesZeroAssertion();
        }

        [TestMethod]
        public void TonMilesNeg()
        {
            this.UIMap.TonMilesNegRecording();
            this.UIMap.TonMilesNegAssertion();
        }

        [TestMethod]
        public void TonMilesPos()
        {
            this.UIMap.TonMilesPosRecording();
            this.UIMap.TonMilesPosAssertion();
        }

        [TestMethod]
        public void TonMilesclearrecording()
        {
            this.UIMap.TonMilesClearRecording();
            this.UIMap.TonMilesClearAssertion();
        }


        /// <summary>
        ///  BHA TESTING
        /// </summary>


        [TestMethod]
        public void BHAZero()
        {
            this.UIMap.BHAZero();
            this.UIMap.BHAZeroAssertion();
        }

        [TestMethod]
        public void BHANeg()
        {
            this.UIMap.BHANegRecording();
            this.UIMap.BHANegAssertion();
        }

        [TestMethod]
        public void BHAPos()
        {
            this.UIMap.BHAPosRecording();
            this.UIMap.BHAPosAssertion();
        }

        [TestMethod]
        public void BHAClearTest()
        {
            this.UIMap.BHAClearRecording();
            this.UIMap.BHAClearAssertion();
        }




        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

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
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
