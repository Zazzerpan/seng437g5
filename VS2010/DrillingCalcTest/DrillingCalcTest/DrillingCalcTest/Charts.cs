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

            test.checkBox2.Checked = false;
            test.checkBox3.Checked = false;
            test.checkBox4.Checked = false;
            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34.Text == "Select") &&
                (test.textBox35.Text == "Select") &&
                (test.textBox36.Text == "Select"))
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

            test.checkBox2.Checked = true;
            test.checkBox3.Checked = false;
            test.checkBox4.Checked = false;

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34.Text == "Select Another") &&
                (test.textBox35.Text == "Select Another") &&
                (test.textBox36.Text == "Select Another"))
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

            test.checkBox2.Checked = true;
            test.checkBox3.Checked = true;

            test.comboBox2.SelectedItem = "2-7/8";
            test.comboBox3.SelectedItem = "1.995";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34.Text == "Recheck") &&
                (test.textBox35.Text == "Recheck") &&
                (test.textBox36.Text == "Recheck"))
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

            test.checkBox2.Checked = true;
            test.checkBox3.Checked = true;

            test.comboBox2.SelectedItem = "2-3/8";
            test.comboBox3.SelectedItem = "1.995";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34.Text == "2-3/8") &&
                (test.textBox35.Text == "1.995") &&
                (test.textBox36.Text == "4.85"))
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

            test.checkBox2.Checked = true;
            test.checkBox3.Checked = false;
            test.checkBox4.Checked = true;

            test.comboBox3.SelectedItem = "2.441";
            test.comboBox4.SelectedItem = "10.40";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34.Text == "Recheck") &&
                (test.textBox35.Text == "Recheck") &&
                (test.textBox36.Text == "Recheck"))
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

            test.checkBox2.Checked = true;
            test.checkBox3.Checked = false;
            test.checkBox4.Checked = true;

            test.comboBox2.SelectedItem = "2-3/8";
            test.comboBox4.SelectedItem = "6.65";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34.Text == "2-3/8") &&
                (test.textBox35.Text == "1.815") &&
                (test.textBox36.Text == "6.65"))
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

            test.checkBox2.Checked = false;
            test.checkBox3.Checked = true;
            test.checkBox4.Checked = false;

            test.comboBox3.SelectedItem = "3.340";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34.Text == "4") &&
                (test.textBox35.Text == "3.340") &&
                (test.textBox36.Text == "14.00"))
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

            test.checkBox2.Checked = false;
            test.checkBox3.Checked = true;
            test.checkBox4.Checked = false;

            test.comboBox3.SelectedItem = "invalid";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34.Text == "Recheck") &&
                (test.textBox35.Text == "Recheck") &&
                (test.textBox36.Text == "Recheck"))
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

            test.checkBox2.Checked = false;
            test.checkBox3.Checked = false;
            test.checkBox4.Checked = true;

            test.comboBox4.SelectedItem = "invalid";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34.Text == "Recheck") &&
                (test.textBox35.Text == "Recheck") &&
                (test.textBox36.Text == "Recheck"))
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

            test.checkBox2.Checked = false;
            test.checkBox3.Checked = false;
            test.checkBox4.Checked = true;

            test.comboBox4.SelectedItem = "6.85";

            test.button23_Click(null, null);

            bool actual;

            if ((test.textBox34.Text == "2-7/8") &&
                (test.textBox35.Text == "2.441") &&
                (test.textBox36.Text == "6.85"))
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

            test.checkBox5.Checked = false;
            test.checkBox6.Checked = false;
            test.checkBox7.Checked = false;

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37.Text == "Recheck") &&
                (test.textBox38.Text == "Recheck") &&
                (test.textBox39.Text == "Recheck"))
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

            test.checkBox5.Checked = true;
            test.checkBox6.Checked = true;
            test.checkBox7.Checked = false;

            test.comboBox5.SelectedItem = "24.00";

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37.Text == "24.00") &&
                (test.textBox38.Text == "3-1/4") &&
                (test.textBox39.Text == "1-1/4"))
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

            test.checkBox5.Checked = true;
            test.checkBox6.Checked = true;
            test.checkBox7.Checked = false;

            test.comboBox5.SelectedItem = "invalid";

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37.Text == "Recheck") &&
                (test.textBox38.Text == "Recheck") &&
                (test.textBox39.Text == "Recheck"))
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

            test.checkBox5.Checked = false;
            test.checkBox6.Checked = true;
            test.checkBox7.Checked = false;

            test.comboBox5.SelectedItem = "21.35";

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37.Text == "21.35") &&
                (test.textBox38.Text == "3") &&
                (test.textBox39.Text == "1"))
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

            test.checkBox5.Checked = false;
            test.checkBox6.Checked = true;
            test.checkBox7.Checked = false;

            test.comboBox5.SelectedItem = "invalid";

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37.Text == "Recheck") &&
                (test.textBox38.Text == "Recheck") &&
                (test.textBox39.Text == "Recheck"))
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

            test.checkBox5.Checked = true;
            test.checkBox6.Checked = false;
            test.checkBox7.Checked = true;

            test.comboBox7.SelectedItem = "3-3/8";
            test.comboBox6.SelectedItem = "1-1/2";

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37.Text == "24.39") &&
                (test.textBox38.Text == "3-3/8") &&
                (test.textBox39.Text == "1-1/2"))
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

            test.checkBox5.Checked = true;
            test.checkBox6.Checked = false;
            test.checkBox7.Checked = true;

            test.comboBox7.SelectedItem = "3";
            test.comboBox6.SelectedItem = "1-1/4";

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37.Text == "Recheck") &&
                (test.textBox38.Text == "Recheck") &&
                (test.textBox39.Text == "Recheck"))
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

            test.checkBox5.Checked = true;
            test.checkBox6.Checked = false;
            test.checkBox7.Checked = true;

            test.comboBox7.SelectedItem = "invalid";
            test.comboBox6.SelectedItem = "invalid";

            test.button24_Click(null, null);

            bool actual;

            if ((test.textBox37.Text == "Recheck") &&
                (test.textBox38.Text == "Recheck") &&
                (test.textBox39.Text == "Recheck"))
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

            test.checkBox8.Checked = false;
            test.checkBox9.Checked = false;
            test.checkBox10.Checked = false;

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40.Text == "Recheck") &&
                (test.textBox41.Text == "Recheck") &&
                (test.textBox42.Text == "Recheck") &&
                (test.textBox43.Text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [TestCase("18.01", "2-7/8", "1-1/2")]
        [TestCase("13.67", "2-7/8", "2")]
        [TestCase("14.21", "2-7/8", "2-1/16")]
        [TestCase("13.51", "2-7/8", "2-1/8")]
        [TestCase("25.38", "3-1/2", "2-1/16")]
        [TestCase("23.50", "3-1/2", "2-1/4")]
        [TestCase("30.68", "4", "2-1/2")]
        [TestCase("29.06", "4", "2-9/16")]
        [TestCase("43.70", "4-1/2", "2-1/2")]
        [TestCase("39.42", "4-1/2", "2-13/16")]
        [TestCase("50.23", "5", "3")]
        [TestCase("53.45", "5-1/2", "3-5/8")]
        [TestCase("48.93", "5-1/2", "3-7/8")]
        public void button25_OD_ID_Std_Match_Test(string expected, string selected1, string selected2)
        {
            Form1 test = new Form1();

            test.checkBox8.Checked = true;
            test.checkBox10.Checked = true;

            test.radioButton28.Checked = true;

            test.comboBox9.SelectedItem = selected2;
            test.comboBox10.SelectedItem = selected1; 

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40.Text == expected) &&
                (test.textBox41.Text == selected1) &&
                (test.textBox42.Text == selected2) &&
                (test.textBox43.Text == "STANDARD"))
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

            test.checkBox8.Checked = true;
            test.checkBox10.Checked = true;

            test.radioButton28.Checked = true;

            test.comboBox9.SelectedItem = "2-1/2";
            test.comboBox10.SelectedItem = "3-1/2";

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40.Text == "Recheck") &&
                (test.textBox41.Text == "Recheck") &&
                (test.textBox42.Text == "Recheck") &&
                (test.textBox43.Text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [TestCase("21.86", "2-7/8", "1-1/2")]
        [TestCase("16.98", "2-7/8", "2")]
        [TestCase("17.60", "2-7/8", "2-1/16")]
        [TestCase("16.81", "2-7/8", "2-1/8")]
        [TestCase("29.56", "3-1/2", "2-1/16")]
        [TestCase("27.68", "3-1/2", "2-1/4")]
        [TestCase("35.57", "4", "2-1/2")]
        [TestCase("33.94", "4", "2-9/16")]
        [TestCase("49.30", "4-1/2", "2-1/2")]
        [TestCase("45.03", "4-1/2", "2-13/16")]
        [TestCase("56.57", "5", "3")]
        [TestCase("60.51", "5-1/2", "3-5/8")]
        [TestCase("56.00", "5-1/2", "3-7/8")]
        public void button25_OD_ID_Spiral_Match_Test(string expected, string selected1, string selected2)
        {
            Form1 test = new Form1();

            test.checkBox8.Checked = true;
            test.checkBox10.Checked = true;

            test.radioButton29.Checked = true;

            test.comboBox9.SelectedItem = selected2;
            test.comboBox10.SelectedItem = selected1;

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40.Text == expected) &&
                (test.textBox41.Text == selected1) &&
                (test.textBox42.Text == selected2) &&
                (test.textBox43.Text == "SPIRAL"))
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

            test.checkBox8.Checked = true;
            test.checkBox10.Checked = true;

            test.radioButton29.Checked = true;

            test.comboBox9.SelectedItem = "3-7/8";
            test.comboBox10.SelectedItem = "2-7/8";

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40.Text == "Recheck") &&
                (test.textBox41.Text == "Recheck") &&
                (test.textBox42.Text == "Recheck") &&
                (test.textBox43.Text == "Recheck"))
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

            test.checkBox8.Checked = false;
            test.checkBox9.Checked = true;
            test.checkBox10.Checked = false;

            test.comboBox8.SelectedItem = "invalid";

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40.Text == "Recheck") &&
                (test.textBox41.Text == "Recheck") &&
                (test.textBox42.Text == "Recheck") &&
                (test.textBox43.Text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [TestCase("18.01", "2-7/8", "1-1/2")]
        [TestCase("13.67", "2-7/8", "2")]
        [TestCase("14.21", "2-7/8", "2-1/16")]
        [TestCase("13.51", "2-7/8", "2-1/8")]
        [TestCase("25.38", "3-1/2", "2-1/16")]
        [TestCase("23.50", "3-1/2", "2-1/4")]
        [TestCase("30.68", "4", "2-1/2")]
        [TestCase("29.06", "4", "2-9/16")]
        [TestCase("43.70", "4-1/2", "2-1/2")]
        [TestCase("39.42", "4-1/2", "2-13/16")]
        [TestCase("50.23", "5", "3")]
        [TestCase("53.45", "5-1/2", "3-5/8")]
        [TestCase("48.93", "5-1/2", "3-7/8")]
        public void button25_Wt_Match_FirstLoop_Test(string selectedWeight, string expected1, string expected2)
        {
            Form1 test = new Form1();

            test.checkBox8.Checked = false;
            test.checkBox9.Checked = true;
            test.checkBox10.Checked = false;

            test.comboBox8.SelectedItem = selectedWeight;

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40.Text == selectedWeight) &&
                (test.textBox41.Text == expected1) &&
                (test.textBox42.Text == expected2) &&
                (test.textBox43.Text == "STANDARD"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [TestCase("21.86", "2-7/8", "1-1/2")]
        [TestCase("16.98", "2-7/8", "2")]
        [TestCase("17.60", "2-7/8", "2-1/16")]
        [TestCase("16.81", "2-7/8", "2-1/8")]
        [TestCase("29.56", "3-1/2", "2-1/16")]
        [TestCase("27.68", "3-1/2", "2-1/4")]
        [TestCase("35.57", "4", "2-1/2")]
        [TestCase("33.94", "4", "2-9/16")]
        [TestCase("49.30", "4-1/2", "2-1/2")]
        [TestCase("45.03", "4-1/2", "2-13/16")]
        [TestCase("56.57", "5", "3")]
        [TestCase("60.51", "5-1/2", "3-5/8")]
        [TestCase("56.00", "5-1/2", "3-7/8")]
        public void button25_Wt_Match_SecondLoop_Test(string selectedWeight, string expected1, string expected2)
        {
            Form1 test = new Form1();

            test.checkBox8.Checked = false;
            test.checkBox9.Checked = true;
            test.checkBox10.Checked = false;

            test.comboBox8.SelectedItem = selectedWeight;

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40.Text == selectedWeight) &&
                (test.textBox41.Text == expected1) &&
                (test.textBox42.Text == expected2) &&
                (test.textBox43.Text == "SPIRAL"))
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

            test.checkBox8.Checked = true;
            test.checkBox9.Checked = true;
            test.checkBox10.Checked = false;

            test.comboBox8.SelectedItem = "invalid";

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40.Text == "Recheck") &&
                (test.textBox41.Text == "Recheck") &&
                (test.textBox42.Text == "Recheck") &&
                (test.textBox43.Text == "Recheck"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [TestCase("18.01", "2-7/8", "1-1/2")]
        [TestCase("13.67", "2-7/8", "2")]
        [TestCase("14.21", "2-7/8", "2-1/16")]
        [TestCase("13.51", "2-7/8", "2-1/8")]
        [TestCase("25.38", "3-1/2", "2-1/16")]
        [TestCase("23.50", "3-1/2", "2-1/4")]
        [TestCase("30.68", "4", "2-1/2")]
        [TestCase("29.06", "4", "2-9/16")]
        [TestCase("43.70", "4-1/2", "2-1/2")]
        [TestCase("39.42", "4-1/2", "2-13/16")]
        [TestCase("50.23", "5", "3")]
        [TestCase("53.45", "5-1/2", "3-5/8")]
        [TestCase("48.93", "5-1/2", "3-7/8")]
        public void button25_Wt_Alter_Match_FirstLoop_Test(string selectedWeight, string expected1, string expected2)
        {
            Form1 test = new Form1();

            test.checkBox8.Checked = true;
            test.checkBox9.Checked = true;
            test.checkBox10.Checked = false;

            test.comboBox8.SelectedItem = selectedWeight;

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40.Text == selectedWeight) &&
                (test.textBox41.Text == expected1) &&
                (test.textBox42.Text == expected2) &&
                (test.textBox43.Text == "STANDARD"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }

        [STAThread]
        [TestCase("21.86", "2-7/8", "1-1/2")]
        [TestCase("16.98", "2-7/8", "2")]
        [TestCase("17.60", "2-7/8", "2-1/16")]
        [TestCase("16.81", "2-7/8", "2-1/8")]
        [TestCase("29.56", "3-1/2", "2-1/16")]
        [TestCase("27.68", "3-1/2", "2-1/4")]
        [TestCase("35.57", "4", "2-1/2")]
        [TestCase("33.94", "4", "2-9/16")]
        [TestCase("49.30", "4-1/2", "2-1/2")]
        [TestCase("45.03", "4-1/2", "2-13/16")]
        [TestCase("56.57", "5", "3")]
        [TestCase("60.51", "5-1/2", "3-5/8")]
        [TestCase("56.00", "5-1/2", "3-7/8")]
        public void button25_Wt_Alter_Match_SecondLoop_Test(string selectedWeight, string expected1, string expected2)
        {
            Form1 test = new Form1();

            test.checkBox8.Checked = false;
            test.checkBox9.Checked = true;
            test.checkBox10.Checked = true;

            test.comboBox8.SelectedItem = selectedWeight;

            test.button25_Click(null, null);

            bool actual;

            if ((test.textBox40.Text == selectedWeight) &&
                (test.textBox41.Text == expected1) &&
                (test.textBox42.Text == expected2) &&
                (test.textBox43.Text == "SPIRAL"))
            {
                actual = true;
            }
            else
                actual = false;

            Assert.AreEqual(actual, true);

        }
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

            test.textBox34.Text = source;

            test.button26_Click(null, null);

            Assert.AreEqual(test.cp, result);
        }

        [STAThread]
        [Test]
        public void button27_Clipboard_Test()
        {
            Form1 test = new Form1();

            test.textBox35.Text = "1.234";

            test.button27_Click(null, null);

            Assert.AreEqual(test.cp2, 1.234);

        }

        [STAThread]
        [Test]
        public void button28_Clipboard_Test()
        {
            Form1 test = new Form1();

            test.textBox36.Text = "2.345";

            test.button28_Click(null, null);

            Assert.AreEqual(test.cp3, 2.345);
        }

        [STAThread]
        [Test]
        public void button29_Clipboard_Test()
        {
            Form1 test = new Form1();

            test.textBox37.Text = "12.12";

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

            test.textBox39.Text = source;

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

            test.textBox38.Text = source;

            test.button31_Click(null, null);

            Assert.AreEqual(test.cp, result);
        }

        [STAThread]
        [Test]
        public void button32_Clipboard_Test()
        {
            Form1 test = new Form1();

            test.textBox40.Text = "12.12";

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

            test.textBox42.Text = source;

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

            test.textBox41.Text = source;

            test.button34_Click(null, null);

            Assert.AreEqual(test.cp, result);
        }
    }

}
