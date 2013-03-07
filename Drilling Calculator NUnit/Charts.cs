using System;
using NUnit.Framework;
using WindowsFormsApplication5;


namespace Drilling_Calculator_NUnit
{
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
}
