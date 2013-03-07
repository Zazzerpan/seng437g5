using System;
using NUnit.Framework;
using WindowsFormsApplication5;


namespace Drilling_Calculator_NUnit
{
    //Button23
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

    /*
    [TestFixture]
    public class drillCollarTests
    {
        [STAThread]
        [Test]
        public void button24_None_Test()
        {

        }
    }
    */



}
