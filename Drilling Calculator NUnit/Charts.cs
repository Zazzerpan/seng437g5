using System;
using NUnit.Framework;
using WindowsFormsApplication5;


namespace Drilling_Calculator_NUnit
{
    //Bug found not sure if done before: the "copy" buttons in the chart window are all crap when the box is empty

    //Complete Statement & Edge coverage, Condition & Path not done yet
    [TestFixture]
    public class drillPipeTests
    {

        [STAThread]
        [Test]
        public void button23_None_Test()
        {
            Form1 test = new Form1();

            test.checkBox2_Checked = false;
            test.checkBox3_Checked = false;
            test.checkBox4_Checked = false;

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34_text == "Select") &&
                (test.textBox35_text == "Select") &&
                (test.textBox36_text == "Select"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);
        }

        [STAThread]
        [Test]
        public void button23_OD_Test()
        {
            Form1 test = new Form1();

            test.checkBox2_Checked = true;
            test.checkBox3_Checked = false;
            test.checkBox4_Checked = false;

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34_text == "Select Another") &&
                (test.textBox35_text == "Select Another") &&
                (test.textBox36_text == "Select Another"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);
        }

        [STAThread]
        [Test]
        public void button23_OD_ID_NoMatch_Test()
        {
            Form1 test = new Form1();

            test.checkBox2_Checked = true;
            test.checkBox3_Checked = true;

            test.comboBox2_selected = "2-7/8";
            test.comboBox3_selected = "1.995";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34_text == "Recheck") &&
                (test.textBox35_text == "Recheck") &&
                (test.textBox36_text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;
 

            Assert.AreEqual(actual, true);
        }

        [STAThread]
        [Test]
        public void button23_OD_ID_Match_Test()
        {
            Form1 test = new Form1();

            test.checkBox2_Checked = true;
            test.checkBox3_Checked = true;

            test.comboBox2_selected = "2-3/8";
            test.comboBox3_selected = "1.995";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34_text == "2-3/8") &&
                (test.textBox35_text == "1.995") &&
                (test.textBox36_text == "4.85"))
            {
                actual = true;
            }
            else
                actual = false;


            Assert.AreEqual(actual, true);
        }

        [STAThread]
        [Test]
        public void button23_OD_WtFt_NoMatch_Test()
        {
            Form1 test = new Form1();

            test.checkBox2_Checked = true;
            test.checkBox3_Checked = false;
            test.checkBox4_Checked = true;

            test.comboBox3_selected = "2.441";
            test.comboBox4_selected = "10.40";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34_text == "Recheck") &&
                (test.textBox35_text == "Recheck") &&
                (test.textBox36_text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;


            Assert.AreEqual(actual, true);
        }

        [STAThread]
        [Test]
        public void button23_OD_WtFt_Match_Test()
        {
            Form1 test = new Form1();

            test.checkBox2_Checked = true;
            test.checkBox3_Checked = false;
            test.checkBox4_Checked = true;

            test.comboBox2_selected = "2-3/8";
            test.comboBox4_selected = "6.65";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34_text == "2-3/8") &&
                (test.textBox35_text == "1.815") &&
                (test.textBox36_text == "6.65"))
            {
                actual = true;
            }
            else
                actual = false;


            Assert.AreEqual(actual, true);
        }

        [STAThread]
        [Test]
        public void button23_ID_Match_Test()
        {
            Form1 test = new Form1();

            test.checkBox2_Checked = false;
            test.checkBox3_Checked = true;
            test.checkBox4_Checked = false;

            test.comboBox3_selected = "3.340";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34_text == "4") &&
                (test.textBox35_text == "3.340") &&
                (test.textBox36_text == "14.00"))
            {
                actual = true;
            }
            else
                actual = false;


            Assert.AreEqual(actual, true);
        }


        [STAThread]
        [Test]
        public void button23_ID_NoMatch_Test()
        {
            Form1 test = new Form1();

            test.checkBox2_Checked = false;
            test.checkBox3_Checked = true;
            test.checkBox4_Checked = false;

            test.comboBox3_selected = "invalid";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34_text == "Recheck") &&
                (test.textBox35_text == "Recheck") &&
                (test.textBox36_text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;


            Assert.AreEqual(actual, true);
        }

        [STAThread]
        [Test]
        public void button23_WtFt_NoMatch_Test()
        {
            Form1 test = new Form1();

            test.checkBox2_Checked = false;
            test.checkBox3_Checked = false;
            test.checkBox4_Checked = true;

            test.comboBox4_selected = "invalid";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34_text == "Recheck") &&
                (test.textBox35_text == "Recheck") &&
                (test.textBox36_text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;


            Assert.AreEqual(actual, true);
        }

        [STAThread]
        [Test]
        public void button23_WtFt_Match_Test()
        {
            Form1 test = new Form1();

            test.checkBox2_Checked = false;
            test.checkBox3_Checked = false;
            test.checkBox4_Checked = true;

            test.comboBox4_selected = "6.85";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34_text == "2-7/8") &&
                (test.textBox35_text == "2.441") &&
                (test.textBox36_text == "6.85"))
            {
                actual = true;
            }
            else
                actual = false;


            Assert.AreEqual(actual, true);
        }
    }

    [TestFixture]
    public class drillCollarTests
    {
        [STAThread]
        [Test]
        public void button24_None_Test()
        {
            Form1 test = new Form1();

            test.checkBox5_checked = false;
            test.checkBox6_checked = false;
            test.checkBox7_checked = false;

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37_text == "Recheck") &&
                (test.textBox38_text == "Recheck") &&
                (test.textBox39_text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);
        }

        [STAThread]
        [Test]
        public void button24_WtFt_Match_Test()
        {
            Form1 test = new Form1();

            test.checkBox5_checked = true;
            test.checkBox6_checked = true;
            test.checkBox7_checked = false;

            test.comboBox5_selected = "24.00";

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37_text == "24.00") &&
                (test.textBox38_text == "3-1/4") &&
                (test.textBox39_text == "1-1/4"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);
        }

        [STAThread]
        [Test]
        public void button24_WtFt_NoMatch_Test()
        {
            Form1 test = new Form1();

            test.checkBox5_checked = true;
            test.checkBox6_checked = true;
            test.checkBox7_checked = false;

            test.comboBox5_selected = "invalid";

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37_text == "Recheck") &&
                (test.textBox38_text == "Recheck") &&
                (test.textBox39_text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);
        }

        [STAThread]
        [Test]
        public void button24_WtFt_Match_Alternative_Test()
        {
            Form1 test = new Form1();

            test.checkBox5_checked = false;
            test.checkBox6_checked = true;
            test.checkBox7_checked = false;

            test.comboBox5_selected = "21.35";

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37_text == "21.35") &&
                (test.textBox38_text == "3") &&
                (test.textBox39_text == "1"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);
        }

        [STAThread]
        [Test]
        public void button24_WtFt_NoMatch_Alternative_Test()
        {
            Form1 test = new Form1();

            test.checkBox5_checked = false;
            test.checkBox6_checked = true;
            test.checkBox7_checked = false;

            test.comboBox5_selected = "invalid";

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37_text == "Recheck") &&
                (test.textBox38_text == "Recheck") &&
                (test.textBox39_text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);
        }

        [STAThread]
        [Test]
        public void button24_OD_ID_Match_Test()
        {
            Form1 test = new Form1();

            test.checkBox5_checked = true;
            test.checkBox6_checked = false;
            test.checkBox7_checked = true;

            test.comboBox7_selected = "3-3/8";
            test.comboBox6_selected = "1-1/2";

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37_text == "24.39") &&
                (test.textBox38_text == "3-3/8") &&
                (test.textBox39_text == "1-1/2"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);
        }

        [STAThread]
        [Test]
        public void button24_OD_ID_MatchButEmpty_Test()
        {
            Form1 test = new Form1();

            test.checkBox5_checked = true;
            test.checkBox6_checked = false;
            test.checkBox7_checked = true;

            test.comboBox7_selected = "3";
            test.comboBox6_selected = "1-1/4";

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37_text == "Recheck") &&
                (test.textBox38_text == "Recheck") &&
                (test.textBox39_text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);
        }

        [STAThread]
        [Test]
        public void button24_OD_ID_NoMatch_Test()
        {
            Form1 test = new Form1();

            test.checkBox5_checked = true;
            test.checkBox6_checked = false;
            test.checkBox7_checked = true;

            test.comboBox7_selected = "invalid";
            test.comboBox6_selected = "invalid";

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37_text == "Recheck") &&
                (test.textBox38_text == "Recheck") &&
                (test.textBox39_text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);
        }
    }

    [TestFixture]
    public class heavyWeightTests
    {

        [STAThread]
        [Test]
        public void button25_None_Test()
        {
            Form1 test = new Form1();

            test.checkBox8_checked = false;
            test.checkBox9_checked = false;
            test.checkBox10_checked = false;

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40_text == "Recheck") &&
                (test.textBox41_text == "Recheck") &&
                (test.textBox42_text == "Recheck") &&
                (test.textBox43_text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [Test]
        public void button25_OD_ID_Std_Match_Test()
        {
            Form1 test = new Form1();

            test.checkBox8_checked = true;
            test.checkBox10_checked = true;

            test.radioButton28_checked = true;

            test.comboBox9_selected = "2-1/8";
            test.comboBox10_selected = "2-7/8"; 

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40_text == "13.51") &&
                (test.textBox41_text == "2-7/8") &&
                (test.textBox42_text == "2-1/8") &&
                (test.textBox43_text == "STANDARD"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [Test]
        public void button25_OD_ID_Std_NoMatch_Test()
        {
            Form1 test = new Form1();

            test.checkBox8_checked = true;
            test.checkBox10_checked = true;

            test.radioButton28_checked = true;

            test.comboBox9_selected = "2-1/2";
            test.comboBox10_selected = "3-1/2";

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40_text == "Recheck") &&
                (test.textBox41_text == "Recheck") &&
                (test.textBox42_text == "Recheck") &&
                (test.textBox43_text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [Test]
        public void button25_OD_ID_Spiral_Match_Test()
        {
            Form1 test = new Form1();

            test.checkBox8_checked = true;
            test.checkBox10_checked = true;

            test.radioButton29_checked = true;

            test.comboBox9_selected = "1-1/2";
            test.comboBox10_selected = "2-7/8";

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40_text == "21.86") &&
                (test.textBox41_text == "2-7/8") &&
                (test.textBox42_text == "1-1/2") &&
                (test.textBox43_text == "SPIRAL"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [Test]
        public void button25_OD_ID_Spiral_NoMatch_Test()
        {
            Form1 test = new Form1();

            test.checkBox8_checked = true;
            test.checkBox10_checked = true;

            test.radioButton29_checked = true;

            test.comboBox9_selected = "3-7/8";
            test.comboBox10_selected = "2-7/8";

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40_text == "Recheck") &&
                (test.textBox41_text == "Recheck") &&
                (test.textBox42_text == "Recheck") &&
                (test.textBox43_text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [Test]
        public void button25_Wt_NoMatch_Test()
        {
            Form1 test = new Form1();

            test.checkBox8_checked = false;
            test.checkBox9_checked = true;
            test.checkBox10_checked = false;

            test.comboBox8_selected = "invalid";

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40_text == "Recheck") &&
                (test.textBox41_text == "Recheck") &&
                (test.textBox42_text == "Recheck") &&
                (test.textBox43_text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [Test]
        public void button25_Wt_Match_FirstLoop_Test()
        {
            Form1 test = new Form1();

            test.checkBox8_checked = false;
            test.checkBox9_checked = true;
            test.checkBox10_checked = false;

            test.comboBox8_selected = "14.21";

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40_text == "14.21") &&
                (test.textBox41_text == "2-7/8") &&
                (test.textBox42_text == "2-1/16") &&
                (test.textBox43_text == "STANDARD"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [Test]
        public void button25_Wt_Match_SecondLoop_Test()
        {
            Form1 test = new Form1();

            test.checkBox8_checked = false;
            test.checkBox9_checked = true;
            test.checkBox10_checked = false;

            test.comboBox8_selected = "16.81";

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40_text == "16.81") &&
                (test.textBox41_text == "2-7/8") &&
                (test.textBox42_text == "2-1/8") &&
                (test.textBox43_text == "SPIRAL"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [Test]
        public void button25_Wt_Alter_NoMatch_Test()
        {
            Form1 test = new Form1();

            test.checkBox8_checked = true;
            test.checkBox9_checked = true;
            test.checkBox10_checked = false;

            test.comboBox8_selected = "invalid";

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40_text == "Recheck") &&
                (test.textBox41_text == "Recheck") &&
                (test.textBox42_text == "Recheck") &&
                (test.textBox43_text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [Test]
        public void button25_Wt_Alter_Match_FirstLoop_Test()
        {
            Form1 test = new Form1();

            test.checkBox8_checked = true;
            test.checkBox9_checked = true;
            test.checkBox10_checked = false;

            test.comboBox8_selected = "14.21";

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40_text == "14.21") &&
                (test.textBox41_text == "2-7/8") &&
                (test.textBox42_text == "2-1/16") &&
                (test.textBox43_text == "STANDARD"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [Test]
        public void button25_Wt_Alter_Match_SecondLoop_Test()
        {
            Form1 test = new Form1();

            test.checkBox8_checked = false;
            test.checkBox9_checked = true;
            test.checkBox10_checked = true;

            test.comboBox8_selected = "16.81";

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40_text == "16.81") &&
                (test.textBox41_text == "2-7/8") &&
                (test.textBox42_text == "2-1/8") &&
                (test.textBox43_text == "SPIRAL"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        /*  test.comboBox8_selected = "";
            test.comboBox9_selected = "";
            test.comboBox10_selected = "";

            test.checkBox8_checked = false;
            test.checkBox9_checked = false;
            test.checkBox10_checked = false;

            test.radioButton28_checked = false;
            test.radioButton29_checked = false;

            test.textBox40_text = "";
            test.textBox41_text = "";
            test.textBox42_text = "";
            test.textBox43_text = "";
         */
    }

    [TestFixture]
    public class copyButtonTests
    {
        [STAThread]
        [TestCase("2-3/8", 2.375)]
        [TestCase("2-7/8", 2.875)]
        [TestCase("3-1/2", 3.5)]
        [TestCase("4", 4)]
        [TestCase("4-1/2", 4.5)]
        [TestCase("5-1/2", 5.5)]
        [TestCase("6-5/8", 6.625)]
        [TestCase("4.12345", 4.12345)]
        public void button26_Clipboard_Tests(string source, double result)
        {
            Form1 test = new Form1();

            test.textBox34_text = source;

            test.button26_Click(null, null);

            Assert.AreEqual(test.cp, result);
        }

        [STAThread]
        [Test]
        public void button27_Clipboard_Test()
        {
            Form1 test = new Form1();

            test.textBox35_text = "1.234";

            test.button27_Click(null, null);

            Assert.AreEqual(test.cp2, 1.234);

        }

        [STAThread]
        [Test]
        public void button28_Clipboard_Test()
        {
            Form1 test = new Form1();

            test.textBox36_text = "2.345";

            test.button28_Click(null, null);

            Assert.AreEqual(test.cp3, 2.345);
        }

        [STAThread]
        [Test]
        public void button29_Clipboard_Test()
        {
            Form1 test = new Form1();

            test.textBox37_text = "12.12";

            test.button29_Click(null, null);

            Assert.AreEqual(test.cp3, 12.12);
        }

        [STAThread]
        [TestCase("11/8", 1.375)]
        [TestCase("1-1/4", 1.25)]
        [TestCase("1-1/2", 1.5)]
        [TestCase("1-3/4", 1.75)]
        [TestCase("2-1/4", 2.25)]
        [TestCase("2-1/2", 2.5)]
        [TestCase("2-13/16", 2.8125)]
        [TestCase("3-3/4", 3.75)]
        [TestCase("3-1/2", 3.5)]
        [TestCase("3-3/4", 3.75)]
        [TestCase("1.234", 1.234)]
        public void button30_Clipboard_Tests(string source, double result)
        {
            Form1 test = new Form1();

            test.textBox39_text = source;

            test.button30_Click(null, null);

            Assert.AreEqual(test.cp2, result);
        }

        [STAThread]
        [TestCase("3-1/8", 3.125)]
        [TestCase("3-1/4", 3.25)]
        [TestCase("3-3/8", 3.375)]
        [TestCase("3-1/2", 3.5)]
        [TestCase("3-3/4", 3.75)]
        [TestCase("3-7/8", 3.875)]
        [TestCase("4-1/8", 4.125)]
        [TestCase("4-1/4", 4.25)]
        [TestCase("4-1/2", 4.5)]
        [TestCase("4-3/4", 4.75)]
        [TestCase("5-1/4", 5.25)]
        [TestCase("5-1/2", 5.5)]
        [TestCase("5-3/4", 5.75)]
        [TestCase("6-1/4", 6.25)]
        [TestCase("6-1/2", 6.5)]
        [TestCase("7-1/4", 7.25)]
        [TestCase("7-1/2", 7.5)]
        [TestCase("7-3/4", 7.75)]
        [TestCase("8-1/4", 8.25)]
        [TestCase("8-1/2", 8.5)]
        [TestCase("8-3/4", 8.75)]
        [TestCase("9-1/4", 9.25)]
        [TestCase("9-1/2", 9.5)]
        [TestCase("9-3/4", 9.75)]
        [TestCase("10-1/4", 10.25)]
        [TestCase("10-1/2", 10.5)]
        [TestCase("10-3/4", 10.75)]
        [TestCase("11-1/4", 11.25)]
        [TestCase("11-1/2", 11.5)]
        [TestCase("11-3/4", 11.75)]
        [TestCase("0.1234", 0.1234)]
        public void button31_Clipboard_Tests(string source, double result)
        {
            Form1 test = new Form1();

            test.textBox38_text = source;

            test.button31_Click(null, null);

            Assert.AreEqual(test.cp, result);
        }

        [STAThread]
        [Test]
        public void button32_Clipboard_Test()
        {
            Form1 test = new Form1();

            test.textBox40_text = "12.12";

            test.button32_Click(null, null);

            Assert.AreEqual(test.cp3, 12.12);
        }

        [STAThread]
        [TestCase("1-1/2", 1.5)]
        [TestCase("2-1/16", 2.0625)]
        [TestCase("2-1/8", 2.125)]
        [TestCase("2-1/4", 2.25)]
        [TestCase("2-1/16", 2.0625)]
        [TestCase("2-1/2", 2.5)]
        [TestCase("2-9/16", 2.5625)]
        [TestCase("2-13/16", 2.8125)]
        [TestCase("3-5/8", 3.625)]
        [TestCase("3-7/8", 3.875)]
        [TestCase("1.234", 1.234)]
        public void button33_Clipboard_Tests(string source, double result)
        {
            Form1 test = new Form1();

            test.textBox42_text = source;

            test.button33_Click(null, null);

            Assert.AreEqual(test.cp2, result);
        }

        [STAThread]
        [TestCase("2-7/8", 2.875)]
        [TestCase("3-1/2", 3.5)]
        [TestCase("4-1/2", 4.5)]
        [TestCase("5-1/2", 5.5)]
        [TestCase("34.56", 34.56)]
        public void button34_Clipboard_Tests(string source, double result)
        {
            Form1 test = new Form1();

            test.textBox41_text = source;

            test.button34_Click(null, null);

            Assert.AreEqual(test.cp, result);
        }
    }

}
