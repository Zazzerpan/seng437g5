using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        double ln, dl, dr, ev, fp;
        public void button19_Click(object sender, EventArgs e)
        {
            dl = Convert.ToDouble(textBox20.Text);
            dr = Convert.ToDouble(textBox21.Text);
            ev = Convert.ToDouble(textBox23.Text);
            ln = Convert.ToDouble(textBox22.Text);

            if (radioButton23.Checked == true)
                dl = dl * 0.3937;

            if (radioButton24.Checked == true)
                dr = dr * 0.3937;

            if (radioButton27.Checked == true)
                ln = ln * 0.3937;

            if (ev > 1.0)
                ev = ev / 100;

            if (radioButton20.Checked == true)
                fp = ((22.0 / 14.0) * ln * ((2 * (dl * dl)) - (dr * dr)) * ev);
            else
                fp = ((66.0 / 28.0) * ln * ev * (dl * dl));

            textBox26.Text = Convert.ToString(fp);
            fp = fp / 231.0;
            textBox27.Text = Convert.ToString(fp);
            textBox28.Text = Convert.ToString((fp / 42.0));
        }

        public void button23_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 21; i++)
            {
                dp[i, 0] = dpa[i];
            }
            for (int i = 0; i < 21; i++)
            {
                dp[0, i] = dpb[i];
            }
            for (int i = 0; i < 21; i++)
            {
                dp[i, i] = dpc[i];
            }

            // None
            if ((checkBox2.Checked == false) && (checkBox4.Checked == false) && (checkBox3.Checked == false))
            {
                textBox34.Text = "Select";
                textBox35.Text = "Select";
                textBox36.Text = "Select";
            }

            //OD
            else if ((checkBox2.Checked == true) && (checkBox4.Checked == false) && (checkBox3.Checked == false))
            {
                textBox34.Text = "Select Another";
                textBox35.Text = "Select Another";
                textBox36.Text = "Select Another";
            }


            // OD + ID

            else if ((checkBox2.Checked == true) && (checkBox3.Checked == true))
            {
                checkBox4.Checked = false;
                int i = 0;
                for (i = 1; i < 21; i++)
                {
                    if ((Convert.ToString(comboBox2.SelectedItem) == dp[0, i]) && (Convert.ToString(comboBox3.SelectedItem) == dp[i, 0]))
                    {
                        break;
                    }

                }

                if (i > 20)
                {
                    textBox34.Text = "Recheck";
                    textBox35.Text = "Recheck";
                    textBox36.Text = "Recheck";
                }
                else
                {
                    textBox34.Text = dp[0, i];
                    textBox35.Text = dp[i, 0];
                    textBox36.Text = dp[i, i];
                }
            }

            // OD + wt/ft
            else if ((checkBox2.Checked == true) && (checkBox4.Checked == true) && (checkBox3.Checked == false))
            {
                int i = 0;
                for (i = 1; i < 21; i++)
                {
                    if ((Convert.ToString(comboBox2.SelectedItem) == dp[0, i]) && (Convert.ToString(comboBox4.SelectedItem) == dp[i, i]))
                    {
                        break;
                    }

                }

                if (i > 20)
                {
                    textBox34.Text = "Recheck";
                    textBox35.Text = "Recheck";
                    textBox36.Text = "Recheck";
                }
                else
                {
                    textBox34.Text = dp[0, i];
                    textBox35.Text = dp[i, 0];
                    textBox36.Text = dp[i, i];
                }
            }

            // Internal Diameter
            else if ((checkBox2.Checked == false) && (checkBox4.Checked == false) && (checkBox3.Checked == true))
            {
                int i = 0;
                for (i = 1; i < 21; i++)
                {
                    if (Convert.ToString(comboBox3.SelectedItem) == dp[i, 0])
                    {
                        break;
                    }

                }

                if (i > 20)
                {
                    textBox34.Text = "Recheck";
                    textBox35.Text = "Recheck";
                    textBox36.Text = "Recheck";
                }
                else
                {
                    textBox34.Text = dp[0, i];
                    textBox35.Text = dp[i, 0];
                    textBox36.Text = dp[i, i];
                }

            }
            // Weight / foot
            else if ((checkBox2.Checked == false) && (checkBox4.Checked == true) && (checkBox3.Checked == false))
            {
                int i = 0;
                for (i = 1; i < 21; i++)
                {
                    if (Convert.ToString(comboBox4.SelectedItem) == dp[i, i])
                    {
                        break;
                    }

                }

                if (i > 20)
                {
                    textBox34.Text = "Recheck";
                    textBox35.Text = "Recheck";
                    textBox36.Text = "Recheck";
                }
                else
                {
                    textBox34.Text = dp[0, i];
                    textBox35.Text = dp[i, 0];
                    textBox36.Text = dp[i, i];
                }
            }
        }

        public void button24_Click(object sender, EventArgs e)
        {
            int i, j, k = 0;

            if ((checkBox7.Checked == true) && (checkBox5.Checked == true))
            {
                checkBox6.Checked = false;

                for (i = 0; i < 42; i++)
                {
                    for (j = 0; j < 15; j++)
                    {
                        if ((comboBox7.SelectedItem == dcd[i, 0]) && (comboBox6.SelectedItem == dcd[0, j]))
                        {
                            textBox38.Text = Convert.ToString(comboBox7.SelectedItem);
                            textBox39.Text = Convert.ToString(comboBox6.SelectedItem);
                            if (dcd[i, j] != "")
                            {
                                textBox37.Text = dcd[i, j];
                                k = 1;
                            }
                            break;
                        }
                    }
                }
            }
            else if ((checkBox6.Checked == true) && (checkBox7.Checked == false) && (checkBox5.Checked == false))
            {
                for (i = 1; i < 42; i++)
                {
                    for (j = 1; j < 15; j++)
                    {
                        if (comboBox5.SelectedItem == dcd[i, j])
                        {
                            textBox38.Text = dcd[i, 0];
                            textBox39.Text = dcd[0, j];
                            textBox37.Text = dcd[i, j];
                            k = 1;
                            break;
                        }
                    }
                }
            }
            else
            {
                if (checkBox6.Checked == true)
                {
                    checkBox7.Checked = false;
                    checkBox5.Checked = false;
                    for (i = 1; i < 42; i++)
                    {
                        for (j = 1; j < 15; j++)
                        {
                            if (comboBox5.SelectedItem == dcd[i, j])
                            {
                                textBox38.Text = dcd[i, 0];
                                textBox39.Text = dcd[0, j];
                                textBox37.Text = dcd[i, j];
                                k = 1;
                                break;
                            }
                        }
                    }
                }
            }
            if (k == 0)
            {
                textBox38.Text = "Recheck";
                textBox39.Text = "Recheck";
                textBox37.Text = "Recheck";

            }



        }

        public double cp = 0.0, cp2 = 0.0, cp3 = 0.0;
        public void button26_Click(object sender, EventArgs e)
        {
            if (textBox34.Text == "2-3/8")
                cp = 2.375;
            else if (textBox34.Text == "2-7/8")
                cp = 2.875;
            else if (textBox34.Text == "3-1/2")
                cp = 3.5;
            else if (textBox34.Text == "4")
                cp = 4;
            else if (textBox34.Text == "4-1/2")
                cp = 4.5;
            else if (textBox34.Text == "5-1/2")
                cp = 5.5;
            else if (textBox34.Text == "6-5/8")
                cp = 6.625;
            else
                cp = Convert.ToDouble(textBox34.Text);
        }

        public void button27_Click(object sender, EventArgs e)
        {
            cp2 = Convert.ToDouble(textBox35.Text);
        }

        public void button28_Click(object sender, EventArgs e)
        {
            cp3 = Convert.ToDouble(textBox36.Text);
        }

        public void button29_Click(object sender, EventArgs e)
        {
            cp3 = Convert.ToDouble(textBox37.Text);
        }

        public void button30_Click(object sender, EventArgs e)
        {
            if (textBox39.Text == "11/8")
                cp2 = 1.375;
            else if (textBox39.Text == "1-1/4")
                cp2 = 1.25;
            else if (textBox39.Text == "1-1/2")
                cp2 = 1.5;
            else if (textBox39.Text == "1-3/4")
                cp2 = 1.75;
            else if (textBox39.Text == "2-1/4")
                cp2 = 2.25;
            else if (textBox39.Text == "2-1/2")
                cp2 = 2.5;
            else if (textBox39.Text == "2-13/16")
                cp2 = 2.8125;
            else if (textBox39.Text == "3-3/4")
                cp2 = 3.75;
            else if (textBox39.Text == "3-1/2")
                cp2 = 3.5;
            else if (textBox39.Text == "3-3/4")
                cp2 = 3.75;
            else
                cp2 = Convert.ToDouble(textBox34.Text);
        }

        public void button31_Click(object sender, EventArgs e)
        {
            if (textBox38.Text == "3-1/8")
                cp = 3.125;
            else if (textBox38.Text == "3-1/4")
                cp = 3.25;
            else if (textBox38.Text == "3-3/8")
                cp = 3.375;
            else if (textBox38.Text == "3-1/2")
                cp = 3.5;
            else if (textBox38.Text == "3-3/4")
                cp = 3.75;
            else if (textBox38.Text == "3-7/8")
                cp = 3.875;
            else if (textBox38.Text == "4-1/8")
                cp = 4.125;
            else if (textBox38.Text == "4-1/4")
                cp = 4.25;
            else if (textBox38.Text == "4-1/2")
                cp = 4.5;
            else if (textBox38.Text == "4-3/4")
                cp = 4.75;
            else if (textBox38.Text == "5-1/4")
                cp = 5.25;
            else if (textBox38.Text == "5-1/2")
                cp = 5.5;
            else if (textBox38.Text == "5-3/4")
                cp = 5.75;
            else if (textBox38.Text == "6-1/4")
                cp = 6.25;
            else if (textBox38.Text == "6-1/2")
                cp = 6.5;
            else if (textBox38.Text == "7-1/4")
                cp = 7.25;
            else if (textBox38.Text == "7-1/2")
                cp = 7.5;
            else if (textBox38.Text == "7-3/4")
                cp = 7.75;
            else if (textBox38.Text == "8-1/4")
                cp = 8.25;
            else if (textBox38.Text == "8-1/2")
                cp = 8.5;
            else if (textBox38.Text == "8-3/4")
                cp = 8.75;
            else if (textBox38.Text == "9-1/4")
                cp = 9.25;
            else if (textBox38.Text == "9-1/2")
                cp = 9.5;
            else if (textBox38.Text == "9-3/4")
                cp = 9.75;
            else if (textBox38.Text == "10-1/4")
                cp = 10.25;
            else if (textBox38.Text == "10-1/2")
                cp = 10.5;
            else if (textBox38.Text == "10-3/4")
                cp = 10.75;
            else if (textBox38.Text == "11-1/4")
                cp = 11.25;
            else if (textBox38.Text == "11-1/2")
                cp = 11.5;
            else if (textBox38.Text == "11-3/4")
                cp = 11.75;
            else
                cp = Convert.ToDouble(textBox34.Text);
        }

        public void button32_Click(object sender, EventArgs e)
        {
            cp3 = Convert.ToDouble(textBox40.Text);
        }

        public void button33_Click(object sender, EventArgs e)
        {
            if (textBox42.Text == "1-1/2")
                cp2 = 1.5;
            else if (textBox42.Text == "2-1/16")
                cp2 = 2.0625;
            else if (textBox42.Text == "2-1/8")
                cp2 = 2.125;
            else if (textBox42.Text == "2-1/4")
                cp2 = 2.25;
            else if (textBox42.Text == "2-1/16")
                cp2 = 2.0625;
            else if (textBox42.Text == "2-1/2")
                cp2 = 2.5;
            else if (textBox42.Text == "2-9/16")
                cp2 = 2.5625;
            else if (textBox42.Text == "2-13/16")
                cp2 = 2.8125;
            else if (textBox42.Text == "3-5/8")
                cp2 = 3.625;
            else if (textBox42.Text == "3-7/8")
                cp2 = 3.875;
            else
                cp2 = Convert.ToDouble(textBox42.Text);
        }

        public void button34_Click(object sender, EventArgs e)
        {
            if (textBox41.Text == "2-7/8")
                cp = 2.875;
            else if (textBox41.Text == "3-1/2")
                cp = 3.5;
            else if (textBox41.Text == "4-1/2")
                cp = 4.5;
            else if (textBox41.Text == "5-1/2")
                cp = 5.5;
            else
                cp = Convert.ToDouble(textBox41.Text);

        }

        public void button35_Click(object sender, EventArgs e)
        {
            textBox44.Text = "0";
        }
    }
}