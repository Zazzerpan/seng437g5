using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using WindowsFormsApplication5;

namespace DrillingCalcTest
{

    [TestFixture]
    public class PumpfactorTests
    {
        /// <summary>
        /// Positive textbox entry tests
        /// </summary>
        [Test]
        [STAThread]
        public void PosTestCubicInches() // Cubic inch / stroke
        {
            double actual26;
            double expected26 = 2618;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.textBox20.Text = "12"; // linear diamter
            test.textBox21.Text = "13"; // rod diamter
            test.textBox22.Text = "14"; // linear length
            test.textBox23.Text = "1"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual26 = Convert.ToDouble(test.textBox26.Text);

            Assert.AreEqual(expected26, actual26);

        }


        [Test]
        [STAThread]
        public void PosTestGallons() // Gallons / stroke
        {
            double actual27;
            double expected27 = 11.33333;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.textBox20.Text = "12"; // linear diamter
            test.textBox21.Text = "13"; // rod diamter
            test.textBox22.Text = "14"; // linear length
            test.textBox23.Text = "1"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual27 = Convert.ToDouble(test.textBox27.Text);

            Assert.AreEqual(expected27, actual27, "SHOULD BE EQUAL");

        }

        [Test]
        [STAThread]
        public void PosTestBarrels() // barrells / stroke
        {
            double actual28;
            double expected28 = 0.26984;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.textBox20.Text = "12"; // linear diamter
            test.textBox21.Text = "13"; // rod diamter
            test.textBox22.Text = "14"; // linear length
            test.textBox23.Text = "1"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual28 = Convert.ToDouble(test.textBox28.Text);

            Assert.AreEqual(expected28, actual28);

        }

        /// <summary>
        /// Zero textbox entry threads, ie, all inputs = 0
        /// </summary>
        [Test]
        [STAThread]
        public void ZeroTestCubicInches() // Cubic inch / stroke
        {
            double actual26;
            double expected26 = 0;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.textBox20.Text = "0"; // linear diamter
            test.textBox21.Text = "0"; // rod diamter
            test.textBox22.Text = "0"; // linear length
            test.textBox23.Text = "0"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual26 = Convert.ToDouble(test.textBox26.Text);

            Assert.AreEqual(expected26, actual26);

        }

        [Test]
        [STAThread]
        public void ZeroTestGallons() // Gallons / stroke
        {
            double actual27;
            double expected27 = 0;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.textBox20.Text = "0"; // linear diamter
            test.textBox21.Text = "0"; // rod diamter
            test.textBox22.Text = "0"; // linear length
            test.textBox23.Text = "0"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual27 = Convert.ToDouble(test.textBox27.Text);

            Assert.AreEqual(expected27, actual27);

        }

        [Test]
        [STAThread]
        public void ZeroTestCBarrels() // Barrels / stroke
        {
            double actual28;
            double expected28 = 0;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.textBox20.Text = "0"; // linear diamter
            test.textBox21.Text = "0"; // rod diamter
            test.textBox22.Text = "0"; // linear length
            test.textBox23.Text = "0"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual28 = Convert.ToDouble(test.textBox28.Text);

            Assert.AreEqual(expected28, actual28);

        }

        /// <summary>
        /// Negative textbox input tests
        /// </summary>
        [Test]
        [STAThread]
        public void NegTestCubicInches() // Cubic inch / stroke
        {
            double actual26;
            double expected26 = -1.570796;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.textBox20.Text = "-2"; // linear diamter
            test.textBox21.Text = "-3"; // rod diamter
            test.textBox22.Text = "-1"; // linear length
            test.textBox23.Text = "-1"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual26 = Convert.ToDouble(test.textBox26.Text);

            Assert.AreEqual(expected26, actual26);

        }

        [Test]
        [STAThread]
        public void NegTestGallons() // Cubic inch / stroke
        {
            double actual27;
            double expected27 = -0.0067999;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.textBox20.Text = "-2"; // linear diamter
            test.textBox21.Text = "-3"; // rod diamter
            test.textBox22.Text = "-1"; // linear length
            test.textBox23.Text = "-1"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual27 = Convert.ToDouble(test.textBox27.Text);

            Assert.AreEqual(expected27, actual27);

        }

        [Test]
        [STAThread]
        public void NegTestBarrels() // Cubic inch / stroke
        {
            double actual28;
            double expected28 = -0.0001619043;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.textBox20.Text = "-2"; // linear diamter
            test.textBox21.Text = "-3"; // rod diamter
            test.textBox22.Text = "-1"; // linear length
            test.textBox23.Text = "-1"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual28 = Convert.ToDouble(test.textBox28.Text);

            Assert.AreEqual(expected28, actual28);

        }

        /// <summary>
        /// Positive textbox entry tests for triplex pumps
        /// </summary>
        [Test]
        [STAThread]
        public void TriplexPosTestCubicInches() // Cubic inch / stroke
        {
            double actual26;
            double expected26 = 4752;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.radioButton20.Checked = true;
            test.textBox20.Text = "12"; // linear diamter
            test.textBox22.Text = "14"; // linear length
            test.textBox23.Text = "1"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual26 = Convert.ToDouble(test.textBox26.Text);

            Assert.AreEqual(expected26, actual26, "ROUNDING ERROR");

        }


        [Test]
        [STAThread]
        public void TriplexPosTestGallons() // Gallons / stroke
        {
            double actual27;
            double expected27 = 20.5714;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.radioButton20.Checked = true;
            test.textBox20.Text = "12"; // linear diamter
            test.textBox22.Text = "14"; // linear length
            test.textBox23.Text = "1"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual27 = Convert.ToDouble(test.textBox27.Text);

            Assert.AreEqual(expected27, actual27, "ROUNDING ERROR");

        }

        [Test]
        [STAThread]
        public void TriplexPosTestBarrels() // barrells / stroke
        {
            double actual28;
            double expected28 = 0.48980;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.radioButton20.Checked = true;
            test.textBox20.Text = "12"; // linear diamter
            test.textBox22.Text = "14"; // linear length
            test.textBox23.Text = "1"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual28 = Convert.ToDouble(test.textBox28.Text);

            Assert.AreEqual(expected28, actual28, "ROUNDING ERROR");

        }

        /// <summary>
        /// Negative Triplex pump tests
        /// </summary>
        [Test]
        [STAThread]
        public void TriplexNegTestCubicInches() // Cubic inch / stroke
        {
            double actual26;
            double expected26 = 9.42857142857143;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.radioButton20.Checked = true;
            test.textBox20.Text = "-2"; // linear diamter
            test.textBox22.Text = "-1"; // linear length
            test.textBox23.Text = "-1"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual26 = Convert.ToDouble(test.textBox26.Text);

            Assert.AreEqual(expected26, actual26, "ROUNDING ERROR");

        }

        [Test]
        [STAThread]
        public void TriplexNegTestGallons() // Cubic inch / stroke
        {
            double actual27;
            double expected27 = 0.040817;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.radioButton20.Checked = true;
            test.textBox20.Text = "-2"; // linear diamter
            test.textBox22.Text = "-1"; // linear length
            test.textBox23.Text = "-1"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual27 = Convert.ToDouble(test.textBox27.Text);

            Assert.AreEqual(expected27, actual27, "ROUNDING ERROR");

        }

        [Test]
        [STAThread]
        public void TriplexNegTestBarrels() // Cubic inch / stroke
        {
            double actual28;
            double expected28 = 0.000971817;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.radioButton20.Checked = true;
            test.textBox20.Text = "-2"; // linear diamter
            test.textBox22.Text = "-1"; // linear length
            test.textBox23.Text = "-1"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual28 = Convert.ToDouble(test.textBox28.Text);

            Assert.AreEqual(expected28, actual28, "ROUNDING ERROR");

        }

        [Test]
        [STAThread]
        public void TriplexZeroTestCubicInches() // Cubic inch / stroke
        {
            double actual26;
            double expected26 = 0;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.radioButton20.Checked = true;
            test.textBox20.Text = "0"; // linear diamter
            test.textBox22.Text = "0"; // linear length
            test.textBox23.Text = "0"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual26 = Convert.ToDouble(test.textBox26.Text);

            Assert.AreEqual(expected26, actual26);

        }

        [Test]
        [STAThread]
        public void TriplexZeroTestGallons() // Gallons / stroke
        {
            double actual27;
            double expected27 = 0;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.radioButton20.Checked = true;
            test.textBox20.Text = "0"; // linear diamter
            test.textBox22.Text = "0"; // linear length
            test.textBox23.Text = "0"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual27 = Convert.ToDouble(test.textBox27.Text);

            Assert.AreEqual(expected27, actual27);

        }

        [Test]
        [STAThread]
        public void TriplexZeroTestCBarrels() // Barrels / stroke
        {
            double actual28;
            double expected28 = 0;

            WindowsFormsApplication5.Form1 test = new WindowsFormsApplication5.Form1();
            //test.Show();
            //test.Activate();

            test.radioButton20.Checked = true;
            test.textBox20.Text = "0"; // linear diamter
            test.textBox22.Text = "0"; // linear length
            test.textBox23.Text = "0"; // volumetric effeciancy

            test.button19_Click(null, null);

            actual28 = Convert.ToDouble(test.textBox28.Text);

            Assert.AreEqual(expected28, actual28);

        }
    }
}
