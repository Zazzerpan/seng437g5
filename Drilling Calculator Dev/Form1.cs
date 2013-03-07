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
        public Form1()
        {
            InitializeComponent();
        }

        double p1 = 0.0;

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
            textBox2.BackColor = Color.Yellow;
            textBox3.BackColor = Color.Yellow;
        }
        
        private void button1_Click_2(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;
            textBox2.BackColor = Color.LightYellow;
            textBox3.BackColor = Color.White;
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            double rpm = 0, av = 0, t = 0, p = 0,p2=0;
           

            rpm = Convert.ToDouble(textBox1.Text);
            if (radioButton2.Checked == true)
                rpm = rpm / 60;

            if ((textBox2.Text == "0")||(textBox2.ReadOnly==true))
            {
                av = ((22.0 / 7.0) * (2.0) * (rpm));
                textBox2.Text = Convert.ToString(av);
            }
            else
            {
                
                av = Convert.ToDouble(textBox2.Text);
            }

            t = Convert.ToInt32(textBox3.Text);
            if (radioButton4.Checked == true)
                t = t / 1.3558;

            p = av * t;
            textBox4.Text = Convert.ToString(p);

            p1 = p / 33000;

            textBox5.Text = Convert.ToString(p1);
            textBox13.Text = Convert.ToString(p1);
            p2 = p1 * 745.7;

            
            textBox6.Text = Convert.ToString(p2);


            }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked == false)
            {
                textBox7.ReadOnly = true;
                textBox8.ReadOnly = true;
                
            }
            else
            {
                textBox8.ReadOnly = false;
                textBox7.ReadOnly = false;
                textBox8.Text = "";
                textBox7.Text = "";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            radioButton9.Checked = true;
            textBox9.Text = "0";
            textBox8.Text = "";
            textBox7.Text = "";


        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked == true)
            {
                textBox7.Text = "7.2";
                textBox8.Text = "19000";
            }

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                textBox7.Text = "4.7";
                textBox8.Text = "21000";
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked == true) 
            {
                textBox7.Text = "6.6";
                textBox8.Text = "20000";
            }
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            groupBox6.BackColor = Color.Yellow;
            textBox9.BackColor = Color.Yellow;
        }
        
        private void button3_Click_2(object sender, EventArgs e)
        {
            groupBox6.BackColor = Color.WhiteSmoke;
            textBox9.BackColor = Color.White;
        }
        
        
        
        
        double he = 0.0, he1 = 0.0, he2 = 0.0;
        
        
        
        private void button3_Click(object sender, EventArgs e)
        {
            double d = 0.0, h = 0.0, lb=0.0,rc=0.0;
            d = Convert.ToDouble(textBox7.Text);
            h = Convert.ToDouble(textBox8.Text);
            rc = Convert.ToDouble(textBox9.Text);

            if (radioButton12.Checked == true)
                rc = rc / 60.0;
            if (radioButton14.Checked == true)
                rc = rc / (3.78541 * 60);
            if (radioButton14.Checked == true)
                rc = rc / 3.78541;

            lb = rc * d;

            he = lb * h * 779.0;


            textBox10.Text = Convert.ToString(he);
            he1 = he / 33000.0;
            
            textBox11.Text = Convert.ToString(he1);
            textBox14.Text = Convert.ToString(he1);
            he2 = he1 * 745.7;

            textBox12.Text = Convert.ToString(he2);





        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox13.Text = "0";
            textBox14.Text = "1";
            textBox14.ReadOnly = false;
            textBox13.ReadOnly = false;
            radioButton19.Checked = true;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton19.Checked == true)
            {
                textBox13.Text = "0";
                textBox14.Text = "1";
                textBox14.ReadOnly = false;
                textBox13.ReadOnly = false;

            }
            else
            {
                textBox13.Text = Convert.ToString(p1);
                textBox14.Text = Convert.ToString(he1);
                textBox14.ReadOnly = true;
                textBox13.ReadOnly = true;
            }





        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox13.BackColor = Color.Yellow;
            textBox14.BackColor = Color.Yellow;
        }
        private void button5_Click_2(object sender, EventArgs e)
        {
            textBox13.BackColor = Color.White;
            textBox14.BackColor = Color.White;


        }
        
        
        private void button5_Click(object sender, EventArgs e)
        {
            double ef = 0.0, pe=0.0, qe=0.0;
            pe = Convert.ToDouble(textBox13.Text);
            qe = Convert.ToDouble(textBox14.Text);
            ef = pe / qe;
            ef = ef * 100.0;
            textBox15.Text = Convert.ToString(ef);

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text=="0")
                textBox2.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text=="0")
                textBox1.ReadOnly = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();

        }

        double val = 0.0;
        int ad = 0, su = 0, mu = 0, di = 0, pw = 0;
        private void button7_Click(object sender, EventArgs e)
        {
            val = val + Convert.ToDouble(textBox16.Text);
            textBox16.Text = Convert.ToString(val);
            ad = 1;
            

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(val!=0.0)
                val = val - Convert.ToDouble(textBox16.Text);
            else
                val = Convert.ToDouble(textBox16.Text);

            textBox16.Text = Convert.ToString(val);
            su = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (val == 0.0)
                val = 1.0;
            val = val * Convert.ToDouble(textBox16.Text);
            textBox16.Text = Convert.ToString(val);
            mu = 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (val != 0.0)
                val = val / Convert.ToDouble(textBox16.Text);
            else
                val = Convert.ToDouble(textBox16.Text);
            
            textBox16.Text = Convert.ToString(val);
            di = 1;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double ba = Convert.ToDouble(textBox16.Text);
            textBox16.Text = "";
            //double
        }

        private void button13_Click(object sender, EventArgs e)
        {
            val = 0.0;
            textBox16.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(ad==1)
                val = val + Convert.ToDouble(textBox16.Text);
            if (su == 1)
                val = val - Convert.ToDouble(textBox16.Text);
            if (mu == 1)
                val = val * Convert.ToDouble(textBox16.Text);
            if (di == 1)
                val = val / Convert.ToDouble(textBox16.Text);
            ad = su = mu = di = 0;
            textBox16.Text = Convert.ToString(val);
            val = 0.0;
        }

        private void textBox16_Click(object sender, EventArgs e)
        {
            textBox16.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Process pro = new Process();

            pro.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";

            pro.Start();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_Click(object sender, EventArgs e)
        {
            
        }

        double l = 0.0, r = 0.0;
        /*
         * 1. Feet - Metres
2. Inches - Metres
3. Pounds - Kilograms
4. Pounds - Metric Tons
5. Horsepower - Watts
6. Pascals - Atmosphere
7. Fahrenheit - Celsius
8. Feet/sec - Km/h
9. Gallons - Litre
10. Barrels - Gallons
11. Barrels - Litres
12. Barrels - Cubic feet
13. Barrels - Cubic inches
14. Square feet - Square metres
         */
         
        private void button11_Click_1(object sender, EventArgs e)
        {
            l=Convert.ToDouble(textBox17.Text);
            if (comboBox1.SelectedIndex == 0)
                r = l * 0.3048;
            if (comboBox1.SelectedIndex == 1)
                r = l * 0.0254;
            if (comboBox1.SelectedIndex == 2)
                r = l * 0.45359;
            if (comboBox1.SelectedIndex == 3)
                r = l * 0.00045;
            if (comboBox1.SelectedIndex == 4)
                r = l * 745.7;
            if (comboBox1.SelectedIndex == 5)
                r = l * 0.00001;
            if (comboBox1.SelectedIndex == 6)
                r = (l * (9.0/5.0))+32.0;
            if (comboBox1.SelectedIndex == 7)
                r = l * 1.09728;
            if (comboBox1.SelectedIndex == 8)
                r = l * 3.78541;
            if (comboBox1.SelectedIndex == 9)
                r = l * 42;
            if (comboBox1.SelectedIndex == 10)
                r = l * 158.98729;
            if (comboBox1.SelectedIndex == 11)
                r = l * 5.61458;
            if (comboBox1.SelectedIndex == 12)
                r = l * 9702;
            if (comboBox1.SelectedIndex == 13)
                r = l * 0.0929;
            textBox18.Text = Convert.ToString(r);




        }

        private void button15_Click(object sender, EventArgs e)
        {
            r = Convert.ToDouble(textBox18.Text);
            if (comboBox1.SelectedIndex == 0)
                l = r * (1.0/0.3048);
            if (comboBox1.SelectedIndex == 1)
                l = r * (1.0/0.0254);
            if (comboBox1.SelectedIndex == 2)
                l = r * (1.0/0.45359);
            if (comboBox1.SelectedIndex == 3)
                l = r * (1.0/0.00045);
            if (comboBox1.SelectedIndex == 4)
                l = r * (1.0/745.7);
            if (comboBox1.SelectedIndex == 5)
                l = r * (1.0/0.00001);
            if (comboBox1.SelectedIndex == 6)
                l = (l - 32.0)* (5.0 / 9.0);
            if (comboBox1.SelectedIndex == 7)
                l = r * (1.0/1.09728);
            if (comboBox1.SelectedIndex == 8)
                l = r * (1.0/3.78541);
            if (comboBox1.SelectedIndex == 9)
                l = r * (1.0/42);
            if (comboBox1.SelectedIndex == 10)
                l = r * (1.0/158.98729);
            if (comboBox1.SelectedIndex == 11)
                l = r * (1.0/5.61458);
            if (comboBox1.SelectedIndex == 12)
                l = r * (1.0/9702);
            if (comboBox1.SelectedIndex == 13)
                l = r * (1.0/0.0929);
            textBox17.Text = Convert.ToString(l);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox17.Text = "";
            textBox18.Text = "";
            l = 0;
            r = 0;
            comboBox1.SelectedIndex = 14;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            string a, b;
            a = textBox19.Text;
            b = "http://www.glossary.oilfield.slb.com/Display.cfm?Term=";
            string c=b+a; 

            

            Uri url = new Uri(c);

            webBrowser1.Url = url;

        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox19.Text = "";
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox23.Enabled = true;
            else
            {
                textBox23.Text = "100.0";
                textBox23.Enabled = false;
            }
        }

        private void radioButton21_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton21.Checked == true)
            {
                textBox21.Text = "0";
                textBox21.Enabled = false;
            }
            else
                textBox21.Enabled = true;
        }


        private void button19_Click_1(object sender, EventArgs e)
        {
            textBox20.BackColor = Color.Yellow;
            textBox21.BackColor = Color.Yellow;
            if(checkBox1.Checked==true)
             textBox23.BackColor = Color.LightGray;
            textBox22.BackColor = Color.Yellow;

        }
        private void button19_Click_2(object sender, EventArgs e)
        {
            textBox20.BackColor = Color.White;
            textBox21.BackColor = Color.White;
            textBox23.BackColor = Color.White;
            textBox22.BackColor = Color.White;
        }

        
        
        
        
        
        double ln, dl, dr, ev,fp;
        public void button19_Click(object sender, EventArgs e)
        {
            dl = Convert.ToDouble(textBox20.Text); // linear diameter
            dr = Convert.ToDouble(textBox21.Text); // diamter of rod
            ev = Convert.ToDouble(textBox23.Text); // volumetric efficiency
            ln = Convert.ToDouble(textBox22.Text); // liner length

            if (radioButton23.Checked == true)
                dl = dl * 0.3937; // convert to cm 

            if (radioButton24.Checked == true)
                dr = dr * 0.3937; // convert to cm 

            if (radioButton27.Checked == true)
                ln = ln * 0.3937; // convert to cm 
             
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


        private void button20_Click_1(object sender, EventArgs e)
        {
            textBox20.BackColor = Color.Yellow;
            textBox21.BackColor = Color.Yellow;
            if (checkBox1.Checked == true)
              textBox23.BackColor = Color.LightGray;
            textBox22.BackColor = Color.Yellow;
            textBox25.BackColor = Color.Yellow;

        }
        private void button20_Click_2(object sender, EventArgs e)
        {
            textBox20.BackColor = Color.White;
            textBox21.BackColor = Color.White;
            textBox23.BackColor = Color.White;
            textBox22.BackColor = Color.White;
            textBox25.BackColor = Color.White;
        }
        
        
        double cpm,dc;
        private void button20_Click(object sender, EventArgs e)
        {
            cpm = Convert.ToDouble(textBox25.Text);
            if (radioButton31.Checked == true)
                cpm = cpm * 60.0;
            dc = fp * cpm;

            textBox31.Text = Convert.ToString(dc);
            textBox30.Text = Convert.ToString((dc / 42.0));
        }


        private void button21_Click_1(object sender, EventArgs e)
        {
            textBox20.BackColor = Color.Yellow;
            textBox21.BackColor = Color.Yellow;
            if (checkBox1.Checked == true)
               textBox23.BackColor = Color.LightGray;
            textBox22.BackColor = Color.Yellow;
            textBox25.BackColor = Color.Yellow;
            textBox24.BackColor = Color.Yellow;

        }
        private void button21_Click_2(object sender, EventArgs e)
        {
            textBox20.BackColor = Color.White;
            textBox21.BackColor = Color.White;
            textBox23.BackColor = Color.White;
            textBox22.BackColor = Color.White;
            textBox25.BackColor = Color.White;
            textBox24.BackColor = Color.White;
        }
        
        
        double p, pwr;
        private void button21_Click(object sender, EventArgs e)
        {
            p = Convert.ToDouble(textBox24.Text);
            pwr = ((p * dc) / 1714.0);

            textBox33.Text = Convert.ToString(pwr);
            textBox32.Text = Convert.ToString((pwr * 745.7));
            textBox29.Text=Convert.ToString((pwr*33000));


        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox20.Text = "0";
            textBox21.Text = "0";
            textBox22.Text = "0";
            textBox23.Text = "1";
            textBox24.Text = "0";
            textBox25.Text = "0";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            textBox30.Text = "";
            textBox31.Text = "";
            textBox32.Text = "";
            textBox33.Text = "";
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            textBox20.Text = "";
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            textBox21.Text = "";
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            textBox22.Text = "";
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            textBox23.Text = "";
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            textBox24.Text = "";
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            textBox25.Text = "";
        }

        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                comboBox2.Enabled = true;
            else
                comboBox2.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                comboBox3.Enabled = true;
            else
                comboBox3.Enabled = false;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                comboBox4.Enabled = true;
            else
                comboBox4.Enabled = false;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
                comboBox7.Enabled = true;
            else
                comboBox7.Enabled = false;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
                comboBox6.Enabled = true;
            else
                comboBox6.Enabled = false;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
                comboBox5.Enabled = true;
            else
                comboBox5.Enabled = false;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
                comboBox10.Enabled = true;
            else
                comboBox10.Enabled = false;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
                comboBox9.Enabled = true;
            else
                comboBox9.Enabled = false;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
                comboBox8.Enabled = true;
            else
                comboBox8.Enabled = false;
        }

        string[] dpa = new string[21] {" ","1.995","1.815","2.441","2.151","2.992","2.764","2.602","3.476","3.340","3.240","3.958","3.826","3.640","4.408","4.276","4.000","4.892","4.778","4.670","5.965"};
        string[] dpb = new string[21] {" ","2-3/8", "2-3/8", "2-7/8", "2-7/8", "3-1/2", "3-1/2", "3-1/2", "4", "4", "4", "4-1/2", "4-1/2", "4-1/2", "5", "5", "5", "5-1/2", "5-1/2", "5-1/2", "6-5/8" };
        string[] dpc = new string[21] {" ","4.85", "6.65", "6.85", "10.40", "9.50", "13.30", "15.50", "11.85", "14.00", "15.70", "13.75", "16.60", "20.00", "16.25", "19.50", "25.60", "19.20", "21.90", "24.70", "25.20" };

        string[,] dp = new string[21, 21];

                
        



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
                int i=0;
                for (i = 1; i < 21; i++)
                {
                    if ((Convert.ToString(comboBox2.SelectedItem) == dp[0,i])&&(Convert.ToString(comboBox3.SelectedItem) == dp[i, 0]))
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
            else if((checkBox2.Checked==true)&&(checkBox4.Checked==true)&&(checkBox3.Checked==false))
            {
                int i=0;
                for (i = 1; i < 21; i++)
                {
                    if ((Convert.ToString(comboBox2.SelectedItem) == dp[0,i])&&(Convert.ToString(comboBox4.SelectedItem) == dp[i, i]))
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

        
        /*OD*/        string[] hwdpa = new string[13] { "2-7/8", "2-7/8", "2-7/8", "2-7/8", "3-1/2", "3-1/2", "4", "4", "4-1/2", "4-1/2", "5", "5-1/2", "5-1/2" };
        /*ID*/        string[] hwdpb = new string[13] { "1-1/2", "2", "2-1/16", "2-1/8", "2-1/16", "2-1/4", "2-1/2", "2-9/16", "2-1/2", "2-13/16", "3", "3-5/8", "3-7/8" };
        /*Std. Wt.*/  string[] hwdpc = new string[13] { "18.01","13.67","14.21","13.51","25.38","23.50","30.68","29.06","43.70","39.42","50.23","53.45","48.93"};
        /*sprl. wt*/  string[] hwdpd = new string[13] { "21.86", "16.98", "17.60", "16.81", "29.56", "27.68", "35.57", "33.94", "49.30", "45.03", "56.57", "60.51", "56.00" };


        
        private void button25_Click(object sender, EventArgs e)
        {
            int k=0;
            //OD+ID+Spiral
            if ((checkBox8.Checked == true) && (checkBox10.Checked == true) && (radioButton28.Checked == true))
            {
                int j;
                checkBox9.Checked = false;

                
                
                    for (j = 0; j < 13; j++)
                    {
                        if ((comboBox10.SelectedItem == hwdpa[j]) && (comboBox9.SelectedItem == hwdpb[j]))
                        {
                            textBox41.Text = Convert.ToString(comboBox10.SelectedItem);
                            textBox42.Text = Convert.ToString(comboBox9.SelectedItem);
                            textBox43.Text = "STANDARD";
                            textBox40.Text = hwdpc[j];
                            k = 1;
                            break;
                        }
                    }
                
            }
             //OD+ID+spiral
            else if ((checkBox8.Checked == true) && (checkBox10.Checked == true) && (radioButton29.Checked == true))
            {
                int j;
                checkBox9.Checked = false;
                
                
                    for (j = 0; j < 13; j++)
                    {
                        if ((comboBox10.SelectedItem == hwdpa[j]) && (comboBox9.SelectedItem == hwdpb[j]))
                        {
                            textBox41.Text = Convert.ToString(comboBox10.SelectedItem);
                            textBox42.Text = Convert.ToString(comboBox9.SelectedItem);
                            textBox43.Text = "SPIRAL";
                            textBox40.Text = hwdpd[j];
                            k = 1;
                            break;
                        }
                    }
                
            }
            //Wt/foot
            else if ((checkBox9.Checked == true) && (checkBox10.Checked == false) && (checkBox8.Checked == false))
            {
                radioButton28.Checked = false;
                radioButton29.Checked = false;
                int j;
                for (j = 0; j < 13; j++)
                {
                    if (comboBox8.SelectedItem == hwdpc[j])
                    {
                        textBox41.Text = hwdpa[j];
                        textBox42.Text = hwdpb[j];
                        textBox43.Text = "STANDARD";
                        textBox40.Text = hwdpc[j];
                        k = 1;
                        break;
                    }
                }
                for (j = 0; j < 13; j++)
                {
                    if (comboBox8.SelectedItem == hwdpd[j])
                    {
                        textBox41.Text = hwdpa[j];
                        textBox42.Text = hwdpb[j];
                        textBox43.Text = "SPIRAL";
                        textBox40.Text = hwdpd[j];
                        k = 1;
                        break;
                    }
                }

            }
            else
            {
                if (checkBox9.Checked == true)
                {
                    radioButton28.Checked = false;
                    radioButton29.Checked = false;
                    checkBox8.Checked = false;
                    checkBox10.Checked = false;
                    int j;
                    for (j = 0; j < 13; j++)
                    {
                        if (comboBox8.SelectedItem == hwdpc[j])
                        {
                            textBox41.Text = hwdpa[j];
                            textBox42.Text = hwdpb[j];
                            textBox43.Text = "STANDARD";
                            textBox40.Text = hwdpc[j];
                            k = 1;
                            break;
                        }
                    }
                    for (j = 0; j < 13; j++)
                    {
                        if (comboBox8.SelectedItem == hwdpd[j])
                        {
                            textBox41.Text = hwdpa[j];
                            textBox42.Text = hwdpb[j];
                            textBox43.Text = "SPIRAL";
                            textBox40.Text = hwdpd[j];
                            k = 1;
                            break;
                        }
                    }
                }
            }

            if (k == 0)
            {
                textBox41.Text = "Recheck";
                textBox42.Text = "Recheck";
                textBox43.Text = "Recheck";
                textBox40.Text = "Recheck";
            }

        

        }

        string[,] dcd = new string[42, 15] { {"","1","11/8","1-1/4","1-1/2","1-3/4","2","2-1/4","2-1/2","2-13/16","3","3-3/4","3-1/2","3-3/4","4"},
                                         {"3","21.35","20.61","","","","","","","","","","","",""},
                                         {"3-1/8","23.39","22.71","22.00","20.00","","","","","","","","","",""},
                                         {"3-1/4","25.52","24.81","24.00","22.19","","","","","","","","","",""},
                                         {"3-3/8","","","26.19","24.39","22.19","","","","","","","","",""},
                                         {"3-1/2","","","28.52","26.71","24.52","","","","","","","","",""},
                                         {"3-3/4","","","33.39","31.61","29.39","","","","","","","","",""},
                                         {"3-7/8","","","35.90","34.10","31.90","29.39","26.61","","","","","","",""},
                                         {"4","","","","36.71","34.52","32.00","29.19","","","","","","",""},
                                         {"4-1/8","","","","39.39","37.19","34.71","31.90","","","","","","",""},
                                         {"4-1/4","","","","42.19","40.00","37.52","34.71","","","","","","",""},
                                         {"4-1/2","","","","48.10","45.90","43.39","40.61","","","","","","",""},
                                         {"4-3/4","","","","54.29","52.10","49.61","46.81","43.61","","","","","",""},
                                         {"5","","","","60.77","58.61","56.10","53.29","50.10","","","","","",""},
                                         {"5-1/4","","","","67.61","65.39","62.90","60.10","56.90","53.39","","","","",""},
                                         {"5-1/2","","","","74.81","72.61","70.10","67.29","64.10","60.61","56.81","","","",""},
                                         {"5-3/4","","","","82.29","80.10","77.61","74.81","71.61","68.10","64.29","","","",""},
                                         {"6","","","","90.29","87.90","85.39","82.61","79.39","75.90","72.10","67.90","63.39","",""},
                                         {"6-1/4","","","","98.00","90.00","93.29","90.52","87.29","83.81","80.00","75.81","71.29","",""},
                                         {"6-1/2","","","","107.00","104.81","102.29","99.52","96.29","92.81","89.00","84.81","80.19","",""},
                                         {"6-3/4","","","","116.00","113.81","111.29","108.52","105.29","101.81","98.00","93.81","89.29","",""},
                                         {"7","","","","125.00","122.81","120.29","117.52","114.29","110.81","107.00","102.81","98.29","93.39","88.29"},
                                         {"7-1/4","","","","134.00","131.81","129.29","126.52","123.29","119.81","116.00","111.81","107.29","102.39","97.29"},
                                         {"7-1/2","","","","144.00","141.81","139.29","136.52","133.29","129.81","126.00","121.81","117.29","112.39","107.29"},
                                         {"7-3/4","","","","154.00","151.81","149.29","146.52","143.29","139.81","136.00","131.81","127.29","122.39","117.29"},
                                         {"8","","","","165.00","162.81","160.29","157.52","154.29","150.81","147.00","142.81","138.29","133.39","128.29"},
                                         {"8-1/4","","","","176.00","173.81","171.29","168.52","165.29","161.81","158.00","153.81","149.29","144.39","139.29"},
                                         {"8-1/2","","","","187.00","184.81","182.29","179.52","176.29","172.81","169.00","164.81","160.29","155.39","150.29"},
                                         {"8-3/4","","","","199.00","196.81","194.29","191.52","188.29","184.81","181.00","176.81","172.29","167.39","162.29"},
                                         {"9","","","","","207.81","205.29","202.52","199.29","195.81","192.00","187.81","183.29","178.39","173.29"},
                                         {"9-1/4","","","","","220.81","217.52","215.52","212.29","208.81","205.00","200.81","196.29","288.16","186.29"},
                                         {"9-1/2","","","","","232.81","230.00","227.52","224.29","220.81","217.00","212.81","208.29","203.39","198.29"},
                                         {"9-3/4","","","","","245.81","243.29","240.52","237.29","233.81","230.00","225.81","221.29","216.39","211.29"},
                                         {"10","","","","","","256.29","253.52","250.29","246.81","243.00","238.81","234.29","229.39","224.29"},
                                         {"10-1/4","","","","","","270.29","267.52","264.29","260.81","257.00","252.81","248.29","243.39","238.29"},
                                         {"10-1/2","","","","","","283.29","267.52","264.29","260.81","257.00","252.81","248.29","243.39","238.29"},
                                         {"10-3/4","","","","","","298.29","295.52","292.29","288.81","285.00","280.81","276.29","271.39","266.29"},
                                         {"11","","","","","","","","306.29","302.81","299.00","294.81","290.29","285.39","280.29"},
                                         {"11-1/4","","","","","","","","321.29","317.81","314.00","309.81","305.29","300.39","295.29"},
                                         {"11-1/2","","","","","","","","336.29","332.81","329.00","324.77","320.29","315.39","310.29"},
                                         {"11-3/4","","","","","","","","352.29","348.81","344.68","340.81","336.29","331.39","326.29"},
                                         {"12","","","","","","","","368.29","364.81","361.00","356.81","352.29","347.35","342.29"},};



        private void button24_Click(object sender, EventArgs e)
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

        double cp=0.0,cp2=0.0,cp3=0.0;
        private void button26_Click(object sender, EventArgs e)
        {
            if(textBox34.Text=="2-3/8")
                cp=2.375;
            else if(textBox34.Text=="2-7/8")
                cp=2.875;
            else if(textBox34.Text=="3-1/2")
                cp=3.5;
            else if(textBox34.Text=="4")
                cp=4;
            else if(textBox34.Text=="4-1/2")
                cp=4.5;
            else if(textBox34.Text=="5-1/2")
                cp=5.5;
            else if(textBox34.Text=="6-5/8")
                cp=6.625;
            else
                cp=Convert.ToDouble(textBox34.Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            cp2=Convert.ToDouble(textBox35.Text);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            cp3=Convert.ToDouble(textBox36.Text);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if(textBox38.Text=="3-1/8")
                cp=3.125;
            else if(textBox38.Text=="3-1/4")
                cp=3.25;
            else if(textBox38.Text=="3-3/8")
                cp=3.375;
            else if(textBox38.Text=="3-1/2")
                cp=3.5;
            else if(textBox38.Text=="3-3/4")
                cp=3.75;
            else if(textBox38.Text=="3-7/8")
                cp=3.875;
            else if(textBox38.Text=="4-1/8")
                cp=4.125;
            else if(textBox38.Text=="4-1/4")
                cp=4.25;
            else if(textBox38.Text=="4-1/2")
                cp=4.5;
            else if(textBox38.Text=="4-3/4")
                cp=4.75;
            else if(textBox38.Text=="5-1/4")
                cp=5.25;
            else if(textBox38.Text=="5-1/2")
                cp=5.5;
            else if(textBox38.Text=="5-3/4")
                cp=5.75;
            else if(textBox38.Text=="6-1/4")
                cp=6.25;
            else if(textBox38.Text=="6-1/2")
                cp=6.5;
            else if(textBox38.Text=="7-1/4")
                cp=7.25;
            else if(textBox38.Text=="7-1/2")
                cp=7.5;
            else if(textBox38.Text=="7-3/4")
                cp=7.75;
            else if(textBox38.Text=="8-1/4")
                cp=8.25;
            else if(textBox38.Text=="8-1/2")
                cp=8.5;
            else if(textBox38.Text=="8-3/4")
                cp=8.75;
            else if(textBox38.Text=="9-1/4")
                cp=9.25;
            else if(textBox38.Text=="9-1/2")
                cp=9.5;
            else if(textBox38.Text=="9-3/4")
                cp=9.75;
            else if(textBox38.Text=="10-1/4")
                cp=10.25;
            else if(textBox38.Text=="10-1/2")
                cp=10.5;
            else if(textBox38.Text=="10-3/4")
                cp=10.75;
            else if(textBox38.Text=="11-1/4")
                cp=11.25;
            else if(textBox38.Text=="11-1/2")
                cp=11.5;
            else if(textBox38.Text=="11-3/4")
                cp=11.75;
            else
                cp=Convert.ToDouble(textBox34.Text);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if(textBox39.Text=="11/8")
                cp2=1.375;
            else if(textBox39.Text=="1-1/4")
                cp2=1.25;
            else if(textBox39.Text=="1-1/2")
                cp2=1.5;
            else if(textBox39.Text=="1-3/4")
                cp2=1.75;
            else if(textBox39.Text=="2-1/4")
                cp2=2.25;
            else if(textBox39.Text=="2-1/2")
                cp2=2.5;
            else if(textBox39.Text=="2-13/16")
                cp2=2.8125;
            else if(textBox39.Text=="3-3/4")
                cp2=3.75;
            else if(textBox39.Text=="3-1/2")
                cp2=3.5;
            else if(textBox39.Text=="3-3/4")
                cp2=3.75;
            else
                cp2=Convert.ToDouble(textBox34.Text);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            cp3=Convert.ToDouble(textBox37.Text);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if(textBox41.Text=="2-7/8")
                cp=2.875;
            else if(textBox41.Text=="3-1/2")
                cp=3.5;
            else if(textBox41.Text=="4-1/2")
                cp=4.5;
            else if(textBox41.Text=="5-1/2")
                cp=5.5;
            else
                cp=Convert.ToDouble(textBox41.Text); 
            
         }

        private void button33_Click(object sender, EventArgs e)
        {
            if(textBox42.Text=="1-1/2")
                cp2=1.5;
            else if(textBox42.Text=="2-1/16")
                cp2=2.0625;
            else if(textBox42.Text=="2-1/8")
                cp2=2.125;
            else if(textBox42.Text=="2-1/4")
                cp2=2.25;
            else if(textBox42.Text=="2-1/16")
                cp2=2.0625;
            else if(textBox42.Text=="2-1/2")
                cp2=2.5;
            else if(textBox42.Text=="2-9/16")
                cp2=2.5625;
            else if(textBox42.Text=="2-13/16")
                cp2=2.8125;
            else if(textBox42.Text=="3-5/8")
                cp2=3.625;
            else if(textBox42.Text=="3-7/8")
                cp2=3.875;
            else
                cp2=Convert.ToDouble(textBox42.Text); 
        }

        private void button32_Click(object sender, EventArgs e)
        {
            cp3=Convert.ToDouble(textBox40.Text); 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            

        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox44.Text = "0";
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox45.Enabled = true;
                textBox45.Text = "";
            }
            else
            {
                textBox45.Enabled = false;
                textBox45.Text = "0.85";
            }

        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox46.Text = "0";

        }

        private void button36_Click(object sender, EventArgs e)
        {
            textBox46.Text = Convert.ToString(cp3);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            textBox47.Text = "0";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            textBox48.Text = "0";

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                textBox48.Text = "";
                textBox48.Enabled = true;
            }
            else
            {
                textBox48.Text = "0";
                textBox48.Enabled = false;
            }

        }

        private void button42_Click(object sender, EventArgs e)
        {
            textBox49.Text = "";
            textBox50.Text = "";
            textBox51.Text = "";
            textBox52.Text = "";
        }

        private void button43_Click(object sender, EventArgs e)
        {
            textBox44.Text = "0";
            textBox46.Text = "0";
            textBox47.Text = "0";
            textBox48.Text = "0";
            textBox49.Text = "";
            textBox50.Text = "";
            textBox51.Text = "";
            textBox52.Text = "";
        }

        private void button41_Click_1(object sender, EventArgs e)
        {
            textBox44.BackColor = Color.Yellow;
            textBox46.BackColor = Color.Yellow;
            textBox47.BackColor = Color.Yellow;
            if(checkBox12.Checked==true)
            textBox48.BackColor = Color.Yellow;
        }

        private void button41_Click_2(object sender, EventArgs e)
        {
            textBox44.BackColor = Color.White;
            textBox46.BackColor = Color.White;
            textBox47.BackColor = Color.White;
            textBox48.BackColor = Color.White;
        }

        private void button41_Click_3(object sender, EventArgs e)
        {
            textBox44.Text = "";
        }

        private void button41_Click_4(object sender, EventArgs e)
        {
            textBox46.Text = "";
        }

        private void button41_Click_5(object sender, EventArgs e)
        {
            textBox47.Text = "";
        }




        private void button41_Click(object sender, EventArgs e)
        {
            double wob, sf, bf, wdc, inc,dcl;
            wob = Convert.ToDouble(textBox44.Text);
            sf = Convert.ToDouble(textBox45.Text);
            wdc = Convert.ToDouble(textBox46.Text);
            bf = Convert.ToDouble(textBox47.Text);
            inc = Convert.ToDouble(textBox48.Text);

            if (radioButton34.Checked == true)
                wob = wob * 2.20462;
            if (radioButton35.Checked == true)
                wob = wob * 2204.62262;

            bf = bf / 65.5;
            bf = 1.0 - bf;

            textBox51.Text = Convert.ToString(bf);

            dcl = wob / (sf * wdc * bf);

            inc = (22.0 / (180 * 7)) * inc;

            dcl = dcl / Math.Cos(inc);

            textBox50.Text = Convert.ToString(dcl);
            textBox49.Text = Convert.ToString(dcl * 0.3048);
            textBox52.Text = Convert.ToString(dcl / 31.0);


            




            
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                textBox54.Enabled = true;
                textBox55.Enabled = true;
                comboBox12.Enabled = true;
                comboBox13.Enabled = true;
                button44.Enabled = true;
                button45.Enabled = true;
                textBox54.Text = "";
                textBox55.Text = "";
            }
            else
            {
                textBox54.Enabled = false;
                textBox55.Enabled = false;
                comboBox12.Enabled = false;
                comboBox13.Enabled = false;
                button44.Enabled = false;
                button45.Enabled = false;
                textBox54.Text = "0";
                textBox55.Text = "0";
            }

        }

        private void button45_Click(object sender, EventArgs e)
        {
            textBox55.Text = "0";
            textBox54.Text = "0";

        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox54.Text = Convert.ToString(cp3);

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                textBox56.Enabled = true;
                textBox57.Enabled = true;
                comboBox14.Enabled = true;
                comboBox15.Enabled = true;
                button46.Enabled = true;
                button47.Enabled = true;
                textBox56.Text = "";
                textBox57.Text = "";
            }
            else
            {
                textBox56.Enabled = false;
                textBox57.Enabled = false;
                comboBox14.Enabled = false;
                comboBox15.Enabled = false;
                button46.Enabled = false;
                button47.Enabled = false;
                textBox54.Text = "0";
                textBox55.Text = "0";
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            textBox56.Text = "0";
            textBox57.Text = "0";
        }

        private void button47_Click(object sender, EventArgs e)
        {
            textBox57.Text = Convert.ToString(cp3);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            textBox53.Text = "0";
        }

        private void button56_Click(object sender, EventArgs e)
        {
            textBox66.Text = "0";
        }

        private void button48_Click(object sender, EventArgs e)
        {
            textBox58.Text="0";
            textBox59.Text = "0";

        }

        private void button49_Click(object sender, EventArgs e)
        {
            textBox59.Text = Convert.ToString(cp3);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            textBox60.Text = "0";
            textBox61.Text = "0";
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                textBox59.Enabled = true;
                textBox58.Enabled = true;
                button48.Enabled = true;
                button49.Enabled = true;
                textBox59.Text = "";
                textBox58.Text = "";
            }
            else
            {
                textBox59.Enabled = false;
                textBox58.Enabled = false;
                button48.Enabled = false;
                button49.Enabled = false;
                textBox59.Text = "0";
                textBox58.Text = "0";
            }

        }

        private void button51_Click(object sender, EventArgs e)
        {
            textBox61.Text = Convert.ToString(cp3);
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                textBox60.Enabled = true;
                textBox61.Enabled = true;
                button50.Enabled = true;
                button51.Enabled = true;
                textBox60.Text = "";
                textBox61.Text = "";
            }
            else
            {
                textBox60.Enabled = false;
                textBox61.Enabled = false;
                button50.Enabled = false;
                button51.Enabled = false;
                textBox60.Text = "0";
                textBox61.Text = "0";
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            textBox62.Text = "0";
            textBox63.Text = "0";
        }

        private void button53_Click(object sender, EventArgs e)
        {
            textBox63.Text = Convert.ToString(cp3);
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                textBox62.Enabled = true;
                textBox63.Enabled = true;
                button52.Enabled = true;
                button53.Enabled = true;
                textBox62.Text = "";
                textBox63.Text = "";
            }
            else
            {
                textBox62.Enabled = false;
                textBox63.Enabled = false;
                button52.Enabled = false;
                button53.Enabled = false;
                textBox62.Text = "0";
                textBox63.Text = "0";
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                textBox64.Enabled = true;
                textBox65.Enabled = true;
                button54.Enabled = true;
                button55.Enabled = true;
                textBox64.Text = "";
                textBox65.Text = "";
            }
            else
            {
                textBox64.Enabled = false;
                textBox65.Enabled = false;
                button54.Enabled = false;
                button55.Enabled = false;
                textBox64.Text = "0";
                textBox65.Text = "0";
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            textBox64.Text = "0";
            textBox65.Text = "0";

        }

        private void button55_Click(object sender, EventArgs e)
        {
            textBox65.Text = Convert.ToString(cp3);
        }

        double w1 = 0.0, w2 = 0.0, w3 = 0.0, w4 = 0.0, w5 = 0.0, w6 = 0.0;
        double l1 = 0.0, l2 = 0.0, l3 = 0.0, l4 = 0.0, l5 = 0.0, l6 = 0.0;
        double bf = 0.0, bw = 0.0, hl = 0.0, tw = 0.0;

        private void button57_Click_1(object sender, EventArgs e)
        {
            textBox53.BackColor = Color.Yellow;
            groupBox35.BackColor = Color.Yellow;
            groupBox36.BackColor = Color.LightGray;
            groupBox37.BackColor = Color.LightGray;
            groupBox38.BackColor = Color.LightGray;
            groupBox39.BackColor = Color.LightGray;
            groupBox40.BackColor = Color.LightGray;
        }

        private void button57_Click_2(object sender, EventArgs e)
        {
            textBox53.BackColor = Color.White;
            groupBox35.BackColor = Color.LightYellow;
            groupBox36.BackColor = Color.LightYellow;
            groupBox37.BackColor = Color.PaleGreen;
            groupBox38.BackColor = Color.PaleGreen;
            groupBox39.BackColor = Color.PaleGreen;
            groupBox40.BackColor = Color.PaleGreen;
        }
        
        private void button57_Click(object sender, EventArgs e)
        {
            

            bf = Convert.ToDouble(textBox53.Text);
            bf = bf / 65.5;
            bf = 1.0 - bf;

            if (checkBox13.Checked == true)
            {
                w1 = Convert.ToDouble(textBox54.Text);
                l1 = Convert.ToDouble(textBox55.Text);
                if (radioButton43.Checked == true)
                    l1 = l1 * 3.28084;
                tw = tw + (w1 * l1);
            }

            if (checkBox14.Checked == true)
            {
                w2 = Convert.ToDouble(textBox57.Text);
                l2 = Convert.ToDouble(textBox56.Text);
                if (radioButton41.Checked == true)
                    l2 = l2 * 3.28084;
                tw = tw + (w2 * l2);
            }

            if (checkBox15.Checked == true)
            {
                w3 = Convert.ToDouble(textBox59.Text);
                l3 = Convert.ToDouble(textBox58.Text);
                if (radioButton45.Checked == true)
                    l3 = l3 * 3.28084;
                tw = tw + (w3 * l3);
            }

            if (checkBox16.Checked == true)
            {
                w4 = Convert.ToDouble(textBox61.Text);
                l4 = Convert.ToDouble(textBox60.Text);
                if (radioButton47.Checked == true)
                    l4 = l4 * 3.28084;
                tw = tw + (w4 * l4);
            }

            if (checkBox17.Checked == true)
            {
                w5 = Convert.ToDouble(textBox63.Text);
                l5 = Convert.ToDouble(textBox62.Text);
                if (radioButton43.Checked == true)
                    l5 = l5 * 3.28084;
                tw = tw + (w5 * l5);
            }

            if (checkBox18.Checked == true)
            {
                w6 = Convert.ToDouble(textBox65.Text);
                l6 = Convert.ToDouble(textBox64.Text);
                if (radioButton43.Checked == true)
                    l6 = l6 * 3.28084;
                tw = tw + (w6 * l6);
            }

            textBox70.Text = Convert.ToString((tw * (1.0 - bf)));
            


        }

        private void button58_Click_1(object sender, EventArgs e)
        {
            textBox53.BackColor = Color.Yellow;
            textBox66.BackColor = Color.Yellow;
            groupBox35.BackColor = Color.Yellow;
            groupBox36.BackColor = Color.LightGray;
            groupBox37.BackColor = Color.LightGray;
            groupBox38.BackColor = Color.LightGray;
            groupBox39.BackColor = Color.LightGray;
            groupBox40.BackColor = Color.LightGray;
        }

        private void button58_Click_2(object sender, EventArgs e)
        {
            textBox53.BackColor = Color.White;
            textBox66.BackColor = Color.White;
            groupBox35.BackColor = Color.LightYellow;
            groupBox36.BackColor = Color.LightYellow;
            groupBox37.BackColor = Color.PaleGreen;
            groupBox38.BackColor = Color.PaleGreen;
            groupBox39.BackColor = Color.PaleGreen;
            groupBox40.BackColor = Color.PaleGreen;
        }
        
        private void button58_Click(object sender, EventArgs e)
        {
            hl = tw * bf;
            textBox69.Text = Convert.ToString(hl);
        }

        string[,] dpts=new String [20,13] { {"9.5",	"194264",	"271970",	"349676",	"388529",	"152979",	"214171",	"275363",	"305959",	"132793",	"185910",	"239027",	"265586"},
        {"13.3",	"271569",	"380197",	"488825",	"543139"	,"212150",	"297010",	"381870",	"424300"	,"183398",	"256757",	"330116",	"366795"},
{"15.5",	"322775",	"451885",	"580995",	"645550",	"250620",	"350868",	"451115",	"501239",	"215967",	"302354",	"388741",	"461934"},
{"11.85",	"230755",	"323057",	"415360",	"461511",	"182016",	"254823",	"327630",	"364033",	"158132",	"221385",	"284638",	"316264"},
{"14",	"2853589",	"399502",	"513646",	"570717",	"224182",	"313854",	"403527",	"448363",	"194363",	"272108",	"349853",	"388725"},
{"15.7",	"324118",	"453765",	"583413",	"648236",	"253851",	"355391",	"456931",	"507701",	"219738",	"307633",	"395528",	"439476"},
{"13.75",	"270034",	"378047",	"486061",	"540068",	"213258",	"298562",	"383865",	"426517",	"185390",	"259546",	"333702",	"370780"},
{"16.6",	"330558",	"462781",	"595004",   "661116",	"230165",	"364231",	"468297",	"520330",	"225771",	"316080",	"406388",	"451542"},
{"20",	"412358",	"577301",	"742244",	"824715",	"322916",	"452082",	"581248",	"645831",	"279501"	,"391302",	"503103",	"559003"},
{"22.82",	"471239",	"659734",	"848230",   "942478",	"367566",	"514593",	"661619",	"735133",	"317497",	"444496",	"571495",   "634994"},
{"16.25",	"328073",	"459302",	"590531",	"656146",   "259155",	"362817",	"466479",	"518310",	"225316",	"315442",	"405568",	"450631"},
{"19.5",	"395595",	"553833",	"712070",	"791189",	"311536",	"436150",	"560764",	"623071",	"270432",	"378605",	"486778",	"540864"},
{"25.6",	"530144",	"742201",	"954259",	"1060288",	"414690",	"580566",	"746442",	"829380",	"358731",	"502223",	"645715",	"717461"},
{"19.2",	"372181",	"521053",	"669925",	"744361",	"294261",	"411965",	"529669",	"588521",	"255954",	"358335",	"460717",	"511907"},
{"21.9",	"437116",	"611963",	"786809",	"874233",	"344780",	"482692",	"620604",	"689560",	"299533",	"419346",	"539160",	"599066"},
{"24.7",	"497222",	"696111",	"894999",	"994444",	"391285",	"547799",	"704313",	"782569",	"339534",	"475347",	"611160",	"679067"},
{"23.4",	"469013",	"656619",	"844224",	"938026",	"370298",	"518417",	"666536",	"740595",	"321861",	"450605",	"579350",	"643722"},
{"26.3",	"533890",	"747446",	"961002",	"1067780",	"420619",	"588867",	"757115",	"841239",	"365201",	"511282",	"657362",	"730403"},
{"25.2",	"489464",	"685250",	"881035",	"978928",	"387466",	"542452",	"697438",	"774932",	"337236",	"472131",	"607026",	"674473"},
{"27.7",	"534198",	"747877",	"961556",	"1068396",	"422418",	"591385",	"760352",	"844836",	"367454",	"514436",	"661418",	"734909"} };









        private void button59_Click_1(object sender, EventArgs e)
        {
            textBox53.BackColor = Color.Yellow;
            groupBox35.BackColor = Color.Yellow;
            groupBox36.BackColor = Color.LightGray;
            groupBox37.BackColor = Color.LightGray;
            groupBox38.BackColor = Color.LightGray;
            groupBox39.BackColor = Color.LightGray;
            groupBox40.BackColor = Color.LightGray;
        }
        private void button59_Click_2(object sender, EventArgs e)
        {
            textBox53.BackColor = Color.White;
            groupBox35.BackColor = Color.LightYellow;
            groupBox36.BackColor = Color.LightYellow;
            groupBox37.BackColor = Color.PaleGreen;
            groupBox38.BackColor = Color.PaleGreen;
            groupBox39.BackColor = Color.PaleGreen;
            groupBox40.BackColor = Color.PaleGreen;
        }

        
        
        
        
        private void button59_Click(object sender, EventArgs e)
        {
            int a;
            double ts=0.0;
            
            if (checkBox13.Checked == true)
            {
                if (comboBox12.SelectedIndex == 0)
                    a = 0;
                else if (comboBox12.SelectedIndex == 1)
                    a = 4;
                else if (comboBox12.SelectedIndex == 2)
                    a = 8;
                else
                    a = 0;

                if (comboBox13.SelectedIndex == 0)
                    a = a + 1;
                else if (comboBox13.SelectedIndex == 1)
                    a = a + 2;
                else if (comboBox13.SelectedIndex == 2)
                    a = a + 3;
                else if (comboBox13.SelectedIndex == 3)
                    a = a + 4;
                else
                    a = a + 1;

                w1 = Convert.ToDouble(textBox54.Text);

                int i = 0;
                for (i = 0; i < 20; i++)
                {
                    if (w1 == (Convert.ToDouble(dpts[i, 0])))
                        break;
                }

                ts = Convert.ToDouble(dpts[i, a]);

            }

            if (checkBox14.Checked == true)
            {
                if (comboBox15.SelectedIndex == 0)
                    a = 0;
                else if (comboBox15.SelectedIndex == 1)
                    a = 4;
                else if (comboBox15.SelectedIndex == 2)
                    a = 8;
                else
                    a = 0;

                if (comboBox14.SelectedIndex == 0)
                    a = a + 1;
                else if (comboBox14.SelectedIndex == 1)
                    a = a + 2;
                else if (comboBox14.SelectedIndex == 2)
                    a = a + 3;
                else if (comboBox14.SelectedIndex == 3)
                    a = a + 4;
                else
                    a = a + 1;

                w2 = Convert.ToDouble(textBox57.Text);

                int i = 0;
                for (i = 0; i < 20; i++)
                {
                    if (w2 == (Convert.ToDouble(dpts[i, 0])))
                        break;
                }

                double ts2;
                ts2 = Convert.ToDouble(dpts[i, a]);

                if (ts2 < ts)
                    ts = ts2;

            }

            textBox72.Text = Convert.ToString(ts);


            textBox68.Text = Convert.ToString((ts - hl));


                



        }

        double lp = 0.0;

        private void button60_Click_1(object sender, EventArgs e)
        {
            textBox53.BackColor = Color.Yellow;
            textBox66.BackColor = Color.Yellow;
            groupBox35.BackColor = Color.LightGray;
            groupBox36.BackColor = Color.LightGray;
            groupBox37.BackColor = Color.Yellow;
            groupBox38.BackColor = Color.LightGray;
            groupBox39.BackColor = Color.LightGray;
            groupBox40.BackColor = Color.LightGray;
        }

        private void button60_Click_2(object sender, EventArgs e)
        {
            textBox53.BackColor = Color.White;
            textBox66.BackColor = Color.White;
            groupBox35.BackColor = Color.LightYellow;
            groupBox36.BackColor = Color.LightYellow;
            groupBox37.BackColor = Color.PaleGreen;
            groupBox38.BackColor = Color.PaleGreen;
            groupBox39.BackColor = Color.PaleGreen;
            groupBox40.BackColor = Color.PaleGreen;
        }
        
        private void button60_Click(object sender, EventArgs e)
        {

            double[] w = new double[6];
            double[] l = new double[6];
            double[] fa = new double[6];
            

            bf = Convert.ToDouble(textBox53.Text);
            bf = bf / 65.5;
            bf = 1.0 - bf;

            int no=0;

            double wob = Convert.ToDouble(textBox66.Text);
            if (radioButton54.Checked == true)
                wob = wob * 2.20462;
            if (radioButton53.Checked == true)
                wob = wob * 2204.62262;

            if (checkBox15.Checked == true)
            {
                w[0] = Convert.ToDouble(textBox59.Text);
                l[0] = Convert.ToDouble(textBox58.Text);
                if (radioButton45.Checked == true)
                    l[0] = l[0] * 3.28084;
                fa[0] = w[0] * bf * l[0];
                lp = wob / (w[0] * bf);

                if (lp > l[0])
                    no = no + 1;
                


            }

            if (checkBox16.Checked == true)
            {
                w[1] = Convert.ToDouble(textBox61.Text);
                l[1] = Convert.ToDouble(textBox60.Text);
                if (radioButton47.Checked == true)
                    l[1] = l[1] * 3.28084;


                if (no == 1)
                {
                    lp = (wob - (fa[0])) / (w[1] * bf);
                    lp = lp + l[0];
                }

                if (lp > (l[1] + l[0]))
                {
                    no = no + 1;
                    fa[1] = w[1] * l[1] * bf;
                    fa[1] = fa[1] + fa[0];
                }

            }

            if (checkBox17.Checked == true)
            {
                w[2] = Convert.ToDouble(textBox63.Text);
                l[2] = Convert.ToDouble(textBox62.Text);
                if (radioButton49.Checked == true)
                    l[2] = l[2] * 3.28084;

                if (no == 2)
                {
                    lp = (wob - (fa[1])) / (w[2] * bf);
                    lp = lp + l[1];
                }

                if (lp > (l[1] + l[0] + l[2]))
                {
                    no = no + 1;
                    fa[2] = w[2] * l[2] * bf;
                    fa[2] = fa[2] + fa[1];
                }
            }

            if (checkBox18.Checked == true)
            {
                w[3] = Convert.ToDouble(textBox65.Text);
                l[3] = Convert.ToDouble(textBox64.Text);
                if (radioButton51.Checked == true)
                    l[3] = l[3] * 3.28084;

                if (no == 3)
                {
                    lp = (wob - (fa[2])) / (w[1] * bf);
                    lp = lp + l[2];
                }

                if (lp > (l[1] + l[0] + l[2] + l[3]))
                {
                    textBox67.BackColor = Color.OrangeRed;

                }
            }

            double sum = 0.0;
            for (int i = 0; i <= no ; i++)
                sum = sum + l[i];

            if (lp > sum)
                textBox67.BackColor = Color.OrangeRed;
            else
                textBox67.BackColor = Color.LightGreen;
                
            textBox67.Text = Convert.ToString(lp);



            




        }

        private void button61_Click(object sender, EventArgs e)
        {
            double[] l = new double[6];
            
            if (checkBox15.Checked == true)
              l[0] = Convert.ToDouble(textBox58.Text);
            if (checkBox16.Checked == true)
              l[1] = Convert.ToDouble(textBox60.Text);
            if (checkBox17.Checked == true)
              l[2] = Convert.ToDouble(textBox62.Text);
            if (checkBox18.Checked == true)
              l[3] = Convert.ToDouble(textBox64.Text);

            int ch = comboBox11.SelectedIndex;

            if (ch == 0)
                textBox71.Text = Convert.ToString(lp - l[0]);
            if (ch == 1)
                textBox71.Text = Convert.ToString(lp - l[0] - l[1]);
            if (ch == 2)
                textBox71.Text = Convert.ToString(lp - l[0] - l[1] - l[2]);
            if (ch == 3)
                textBox71.Text = Convert.ToString(lp - l[0] - l[1] - l[2] - l[3]);
        
        }

        double cp4 = 0.0;
        private void button83_Click(object sender, EventArgs e)
        {
            cp4 = Convert.ToDouble(textBox28.Text);
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                textBox73.Enabled = true;
                textBox74.Enabled = true;
                textBox75.Enabled = true;
                button62.Enabled = true;
                button63.Enabled = true;
                button74.Enabled = true;
            }
            else
            {
                textBox73.Enabled = false;
                textBox74.Enabled = false;
                textBox75.Enabled = false;
                button62.Enabled = false;
                button63.Enabled = false;
                button74.Enabled = false;
                textBox73.Text = "0";
                textBox74.Text = "0";
                textBox75.Text = "0";
            }


        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                textBox76.Enabled = true;
                textBox77.Enabled = true;
                textBox78.Enabled = true;
                button64.Enabled = true;
                button65.Enabled = true;
                button66.Enabled = true;
            }
            else
            {
                textBox76.Enabled = false;
                textBox77.Enabled = false;
                textBox78.Enabled = false;
                button64.Enabled = false;
                button65.Enabled = false;
                button66.Enabled = false;
                textBox76.Text = "0";
                textBox77.Text = "0";
                textBox78.Text = "0";
            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                textBox79.Enabled = true;
                textBox80.Enabled = true;
                textBox81.Enabled = true;
                button67.Enabled = true;
                button68.Enabled = true;
                button69.Enabled = true;
            }
            else
            {
                textBox79.Enabled = false;
                textBox80.Enabled = false;
                textBox81.Enabled = false;
                button67.Enabled = false;
                button68.Enabled = false;
                button69.Enabled = false;
                textBox79.Text = "0";
                textBox80.Text = "0";
                textBox81.Text = "0";
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true)
            {
                textBox82.Enabled = true;
                textBox83.Enabled = true;
                textBox84.Enabled = true;
                button70.Enabled = true;
                button71.Enabled = true;
                button72.Enabled = true;
            }
            else
            {
                textBox82.Enabled = false;
                textBox83.Enabled = false;
                textBox84.Enabled = false;
                button70.Enabled = false;
                button71.Enabled = false;
                button72.Enabled = false;
                textBox82.Text = "0";
                textBox83.Text = "0";
                textBox84.Text = "0";
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked == true)
            {
                textBox85.Enabled = true;
                textBox86.Enabled = true;
                textBox87.Enabled = true;
                button73.Enabled = true;
                button75.Enabled = true;
                button76.Enabled = true;
            }
            else
            {
                textBox85.Enabled = false;
                textBox86.Enabled = false;
                textBox87.Enabled = false;
                button73.Enabled = false;
                button75.Enabled = false;
                button76.Enabled = false;
                textBox85.Text = "0";
                textBox86.Text = "0";
                textBox87.Text = "0";
            }
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked == true)
            {
                textBox88.Enabled = true;
                textBox89.Enabled = true;
                textBox90.Enabled = true;
                button77.Enabled = true;
                button78.Enabled = true;
                button79.Enabled = true;
            }
            else
            {
                textBox88.Enabled = false;
                textBox89.Enabled = false;
                textBox90.Enabled = false;
                button77.Enabled = false;
                button78.Enabled = false;
                button79.Enabled = false;
                textBox88.Text = "0";
                textBox89.Text = "0";
                textBox90.Text = "0";
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            textBox73.Text = "0";
            textBox74.Text = "0";
            textBox75.Text = "0";
        }

        private void button64_Click(object sender, EventArgs e)
        {
            textBox76.Text = "0";
            textBox77.Text = "0";
            textBox78.Text = "0";
        }

        private void button67_Click(object sender, EventArgs e)
        {
            textBox79.Text = "0";
            textBox80.Text = "0";
            textBox81.Text = "0";
        }

        private void button70_Click(object sender, EventArgs e)
        {
            textBox82.Text = "0";
            textBox83.Text = "0";
            textBox84.Text = "0";
        }

        private void button73_Click(object sender, EventArgs e)
        {
            textBox85.Text = "0";
            textBox86.Text = "0";
            textBox87.Text = "0";
        }

        private void button77_Click(object sender, EventArgs e)
        {
            textBox88.Text = "0";
            textBox89.Text = "0";
            textBox90.Text = "0";
        }

        private void button80_Click(object sender, EventArgs e)
        {
            textBox93.Text = "0";
          
        }

        private void button81_Click(object sender, EventArgs e)
        {
            textBox91.Text = "0";
            
        }

        private void button86_Click(object sender, EventArgs e)
        {
            textBox93.Text = "0";
            textBox91.Text = "0";
            textBox85.Text = "0";
            textBox86.Text = "0";
            textBox87.Text = "0";
            textBox88.Text = "0";
            textBox89.Text = "0";
            textBox90.Text = "0";
            textBox73.Text = "0";
            textBox74.Text = "0";
            textBox75.Text = "0";
            textBox76.Text = "0";
            textBox77.Text = "0";
            textBox78.Text = "0";
            textBox79.Text = "0";
            textBox80.Text = "0";
            textBox81.Text = "0";
            textBox82.Text = "0";
            textBox83.Text = "0";
            textBox84.Text = "0";
            textBox94.Text = "";
            textBox95.Text = "";
            textBox96.Text = "";
            textBox97.Text = "";
            textBox98.Text = "";
            textBox92.Text = "";
        }

        private void button82_Click(object sender, EventArgs e)
        {
            textBox91.Text = Convert.ToString(cp4);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            textBox73.Text = Convert.ToString(cp);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            textBox74.Text = Convert.ToString(cp2);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            textBox78.Text = Convert.ToString(cp);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            textBox77.Text = Convert.ToString(cp2);
        }

        private void button69_Click(object sender, EventArgs e)
        {
            textBox81.Text = Convert.ToString(cp);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            textBox80.Text = Convert.ToString(cp2);
        }

        private void button72_Click(object sender, EventArgs e)
        {
            textBox84.Text = Convert.ToString(cp);
        }

        private void button71_Click(object sender, EventArgs e)
        {
            textBox83.Text = Convert.ToString(cp2);
        }

        private void button76_Click(object sender, EventArgs e)
        {
            textBox87.Text = Convert.ToString(cp);
        }

        private void button75_Click(object sender, EventArgs e)
        {
            textBox86.Text = Convert.ToString(cp2);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            textBox90.Text = Convert.ToString(cp);
        }

        private void button78_Click(object sender, EventArgs e)
        {
            textBox89.Text = Convert.ToString(cp2);
        }

        
        double icap=0.0;
        double ocap=0.0;
        double tcap = 0.0;
        double wd = 0.0;
        double tl=0.0;

        private void button84_Click_1(object sender, EventArgs e)
        {
            textBox93.BackColor = Color.Yellow;
            groupBox43.BackColor = Color.Yellow;
            groupBox44.BackColor = Color.LightGray;
            groupBox45.BackColor = Color.LightGray;
            groupBox46.BackColor = Color.LightGray;
            groupBox47.BackColor = Color.LightGray;
            groupBox48.BackColor = Color.LightGray;
            
        }
        private void button84_Click_2(object sender, EventArgs e)
        {
            textBox93.BackColor = Color.White;
            groupBox43.BackColor = Color.WhiteSmoke;
            groupBox44.BackColor = Color.WhiteSmoke;
            groupBox45.BackColor = Color.WhiteSmoke;
            groupBox46.BackColor = Color.WhiteSmoke;
            groupBox47.BackColor = Color.WhiteSmoke;
            groupBox48.BackColor = Color.WhiteSmoke;
        }
        
        
        private void button84_Click(object sender, EventArgs e)
        {
            wd = Convert.ToDouble(textBox93.Text);

            double id,od,ln;

            if (checkBox19.Checked == true)
            {
                id = Convert.ToDouble(textBox74.Text);
                od = Convert.ToDouble(textBox73.Text);
                ln = Convert.ToDouble(textBox75.Text);
                if (radioButton57.Checked == true)
                    ln = ln * 3.28084;
                tl = tl + ln;

                icap = icap + ((id * id / 1029.4) * ln);

                ocap = ocap + ((((wd * wd) - (od * od)) / 1029.4) * ln);

            }

            if (checkBox20.Checked == true)
            {
                id = Convert.ToDouble(textBox77.Text);
                od = Convert.ToDouble(textBox78.Text);
                ln = Convert.ToDouble(textBox76.Text);
                if (radioButton58.Checked == true)
                    ln = ln * 3.28084;
                tl = tl + ln;

                icap = icap + ((id * id / 1029.4) * ln);

                ocap = ocap + ((((wd * wd) - (od * od)) / 1029.4) * ln);

            }

            if (checkBox21.Checked == true)
            {
                id = Convert.ToDouble(textBox80.Text);
                od = Convert.ToDouble(textBox81.Text);
                ln = Convert.ToDouble(textBox79.Text);
                if (radioButton60.Checked == true)
                    ln = ln * 3.28084;
                tl = tl + ln;

                icap = icap + ((id * id / 1029.4) * ln);

                ocap = ocap + ((((wd * wd) - (od * od)) / 1029.4) * ln);

            }

            if (checkBox22.Checked == true)
            {
                id = Convert.ToDouble(textBox83.Text);
                od = Convert.ToDouble(textBox84.Text);
                ln = Convert.ToDouble(textBox82.Text);
                if (radioButton62.Checked == true)
                    ln = ln * 3.28084;
                tl = tl + ln;

                icap = icap + ((id * id / 1029.4) * ln);

                ocap = ocap + ((((wd * wd) - (od * od)) / 1029.4) * ln);

            }

            if (checkBox23.Checked == true)
            {
                id = Convert.ToDouble(textBox86.Text);
                od = Convert.ToDouble(textBox87.Text);
                ln = Convert.ToDouble(textBox85.Text);
                if (radioButton64.Checked == true)
                    ln = ln * 3.28084;
                tl = tl + ln;

                icap = icap + ((id * id / 1029.4) * ln);

                ocap = ocap + ((((wd * wd) - (od * od)) / 1029.4) * ln);

            }

            if (checkBox24.Checked == true)
            {
                id = Convert.ToDouble(textBox89.Text);
                od = Convert.ToDouble(textBox90.Text);
                ln = Convert.ToDouble(textBox88.Text);
                if (radioButton64.Checked == true)
                    ln = ln * 3.28084;
                tl = tl + ln;

                icap = icap + ((id * id / 1029.4) * ln);

                ocap = ocap + ((((wd * wd) - (od * od)) / 1029.4) * ln);

            }

            tcap = ocap + icap;

            textBox92.Text = Convert.ToString(ocap);
            textBox94.Text = Convert.ToString(icap);
            textBox95.Text = Convert.ToString(tcap);
            textBox96.Text = Convert.ToString(tcap*158.98729);
            

 


        }


        private void button85_Click_1(object sender, EventArgs e)
        {
            textBox93.BackColor = Color.Yellow;
            textBox91.BackColor = Color.Yellow;
            groupBox43.BackColor = Color.Yellow;
            groupBox44.BackColor = Color.LightGray;
            groupBox45.BackColor = Color.LightGray;
            groupBox46.BackColor = Color.LightGray;
            groupBox47.BackColor = Color.LightGray;
            groupBox48.BackColor = Color.LightGray;

        }
        private void button85_Click_2(object sender, EventArgs e)
        {
            textBox93.BackColor = Color.White;
            textBox91.BackColor = Color.White;
            groupBox43.BackColor = Color.WhiteSmoke;
            groupBox44.BackColor = Color.WhiteSmoke;
            groupBox45.BackColor = Color.WhiteSmoke;
            groupBox46.BackColor = Color.WhiteSmoke;
            groupBox47.BackColor = Color.WhiteSmoke;
            groupBox48.BackColor = Color.WhiteSmoke;
        }
        
        
        
        private void button85_Click(object sender, EventArgs e)
        {
            double pf = 0.0;
            pf = Convert.ToDouble(textBox91.Text);
            textBox97.Text = Convert.ToString(icap / pf);
            textBox98.Text = Convert.ToString(ocap / pf);


        }

        private void tabPage9_Click(object sender, EventArgs e)
        {

        }

        private void button87_Click(object sender, EventArgs e)
        {
            textBox99.Text = "0";
        }

        private void button88_Click(object sender, EventArgs e)
        {
            textBox100.Text = "0";
        }

        private void button89_Click(object sender, EventArgs e)
        {
            textBox101.Text = "0";
        }

        private void button90_Click(object sender, EventArgs e)
        {
            textBox102.Text = "0";
        }

        private void button91_Click(object sender, EventArgs e)
        {
            textBox103.Text = "0";
        }

        private void button92_Click(object sender, EventArgs e)
        {
            textBox104.Text = "0";
        }

        private void button93_Click(object sender, EventArgs e)
        {
            textBox105.Text = "0";
        }

        private void button94_Click(object sender, EventArgs e)
        {
            textBox106.Text = "0";
        }

        private void button95_Click(object sender, EventArgs e)
        {
            textBox107.Text = "0";
        }

        private void button101_Click(object sender, EventArgs e)
        {
            textBox99.Text = "0";
            textBox100.Text = "0";
            textBox101.Text = "0";
            textBox102.Text = "0";
            textBox103.Text = "0";
            textBox104.Text = "0";
            textBox105.Text = "0";
            textBox106.Text = "0";
            textBox107.Text = "0";
            textBox108.Text = "";
            textBox109.Text = "";
            textBox110.Text = "";
            textBox111.Text = "";
            textBox112.Text = "";
        }




        double m = 0.0;
        double ls = 0.0;
        double d = 0.0;
        double lcol = 0.0;
        double wdp = 0.0;
        double wdc = 0.0;
        double bf2=0.0;
        double c=0.0;
        double we = 0.0;
        double wcs = 0.0;
        double lcs = 0.0;
        double t1 = 0.0;
        double t2=0.0;
        double tcs = 0.0;
        double tdr = 0.0;
        double tcr = 0.0;



        private void button96_Click_1(object sender, EventArgs e)
        {
            textBox99.BackColor = Color.Yellow;
            textBox100.BackColor = Color.Yellow;
            textBox101.BackColor = Color.Yellow;
            textBox102.BackColor = Color.Yellow;
            textBox103.BackColor = Color.Yellow;
            textBox104.BackColor = Color.Yellow;
            textBox105.BackColor = Color.Yellow;
        }

        private void button96_Click_2(object sender, EventArgs e)
        {
            textBox99.BackColor = Color.White;
            textBox100.BackColor = Color.White;
            textBox101.BackColor = Color.White;
            textBox102.BackColor = Color.White;
            textBox103.BackColor = Color.White;
            textBox104.BackColor = Color.White;
            textBox105.BackColor = Color.White;
        }
        
        
        private void button96_Click(object sender, EventArgs e)
        {
            d = Convert.ToDouble(textBox99.Text);
            ls = Convert.ToDouble(textBox100.Text);
            m = Convert.ToDouble(textBox101.Text);
            bf2 = Convert.ToDouble(textBox102.Text);
            bf2 = bf2 / 65.5;
            bf2 = 1 - bf2;
            wdc = Convert.ToDouble(textBox103.Text);
            wdp = Convert.ToDouble(textBox104.Text);
            lcol = Convert.ToDouble(textBox105.Text);

            we = wdp * bf2;

            c = ((lcol * wdc) - (lcol * wdp))*bf2;

            t1=(((ls+d)*we*d)/10560000.00)+(((m+(c/2.0))*d)/2640000.00);
            textBox111.Text = Convert.ToString(t1);
        }

        private void button102_Click(object sender, EventArgs e)
        {
            textBox103.Text = Convert.ToString(cp3);
        }

        private void button103_Click(object sender, EventArgs e)
        {
            textBox104.Text = Convert.ToString(cp3);
        }


        private void button97_Click_1(object sender, EventArgs e)
        {
            textBox99.BackColor = Color.Yellow;
            textBox100.BackColor = Color.Yellow;
            textBox101.BackColor = Color.Yellow;
            textBox102.BackColor = Color.Yellow;
            textBox103.BackColor = Color.Yellow;
            textBox104.BackColor = Color.Yellow;
            textBox105.BackColor = Color.Yellow;
        }

        private void button97_Click_2(object sender, EventArgs e)
        {
            textBox99.BackColor = Color.White;
            textBox100.BackColor = Color.White;
            textBox101.BackColor = Color.White;
            textBox102.BackColor = Color.White;
            textBox103.BackColor = Color.White;
            textBox104.BackColor = Color.White;
            textBox105.BackColor = Color.White;
        }
        
        
        private void button97_Click(object sender, EventArgs e)
        {
            d = Convert.ToDouble(textBox99.Text);
            ls = Convert.ToDouble(textBox100.Text);
            m = Convert.ToDouble(textBox101.Text);
            bf2 = Convert.ToDouble(textBox102.Text);
            bf2 = bf2 / 65.5;
            bf2 = 1 - bf2;
            wdc = Convert.ToDouble(textBox103.Text);
            wdp = Convert.ToDouble(textBox104.Text);
            lcol = Convert.ToDouble(textBox105.Text);

            we = wdp * bf2;

            c = ((lcol * wdc) - (lcol * wdp)) * bf2;

            t2 = (((ls + d) * we * d) / 10560000.00) + (((m + (c / 2.0)) * d) / 2640000.00);
            textBox110.Text = Convert.ToString(t2);
        }



        private void button100_Click_1(object sender, EventArgs e)
        {
            textBox99.BackColor = Color.Yellow;
            textBox101.BackColor = Color.Yellow;
            textBox102.BackColor = Color.Yellow;
            textBox106.BackColor = Color.Yellow;
            textBox107.BackColor = Color.Yellow;
        }

        private void button100_Click_2(object sender, EventArgs e)
        {
            textBox99.BackColor = Color.White;
            textBox101.BackColor = Color.White;
            textBox102.BackColor = Color.White;
            textBox106.BackColor = Color.White;
            textBox107.BackColor = Color.White;
        }
        
        
        private void button100_Click(object sender, EventArgs e)
        {
            d = Convert.ToDouble(textBox99.Text);
            m = Convert.ToDouble(textBox101.Text);
            bf2 = Convert.ToDouble(textBox102.Text);
            bf2 = bf2 / 65.5;
            bf2 = 1 - bf2;
            lcs = Convert.ToDouble(textBox106.Text);
            wcs = Convert.ToDouble(textBox107.Text);

            wcs = wcs * bf2;

            tcs = (((lcs + d) * wcs * d) / 10560000.00) + ((m * d) / 2640000.00);
            tcs = tcs / 2.0;

            textBox109.Text = Convert.ToString(tcs);
        }


        private void button98_Click_1(object sender, EventArgs e)
        {
            textBox111.BackColor = Color.Yellow;
            textBox110.BackColor = Color.Yellow;
        }
        private void button98_Click_2(object sender, EventArgs e)
        {
            textBox111.BackColor = Color.PaleGreen;
            textBox110.BackColor = Color.PaleGreen;
        }
        
        
        private void button98_Click(object sender, EventArgs e)
        {
            textBox108.Text = Convert.ToString((3 * (t2 - t1)));

        }


        private void button99_Click_1(object sender, EventArgs e)
        {
            textBox111.BackColor = Color.Yellow;
            textBox110.BackColor = Color.Yellow;
        }
        private void button99_Click_2(object sender, EventArgs e)
        {
            textBox111.BackColor = Color.PaleGreen;
            textBox110.BackColor = Color.PaleGreen;
        }
        
        
        private void button99_Click(object sender, EventArgs e)
        {
            textBox112.Text = Convert.ToString((2 * (t2 - t1)));
        }

        private void button104_Click(object sender, EventArgs e)
        {
            textBox113.Text = "0";
        }

        private void button105_Click(object sender, EventArgs e)
        {
            textBox114.Text = "0";
        }

        private void button106_Click(object sender, EventArgs e)
        {
            textBox115.Text = "0";
        }

        private void button108_Click(object sender, EventArgs e)
        {
            textBox117.Text = "0";

        }

        private void button109_Click(object sender, EventArgs e)
        {
            textBox118.Text = "0";
        }

        private void button110_Click(object sender, EventArgs e)
        {
            textBox119.Text = "0";
        }

        private void radioButton88_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton88.Checked == true)
                textBox119.Enabled = true;
            else
                textBox119.Enabled = false;
        }

        private void button111_Click(object sender, EventArgs e)
        {
            textBox120.Text = "0";
        }

        private void button113_Click(object sender, EventArgs e)
        {
            textBox121.Text = "0";
        }

        private void button115_Click(object sender, EventArgs e)
        {
            textBox123.Text = "0";
        }

        private void button118_Click(object sender, EventArgs e)
        {
            textBox124.Text = "0";
        }

        private void button117_Click(object sender, EventArgs e)
        {
            textBox124.Text = Convert.ToString(cp);
        }

        private void button116_Click(object sender, EventArgs e)
        {
            textBox123.Text = Convert.ToString(cp);
        }

        private void button128_Click(object sender, EventArgs e)
        {
            textBox113.Text = "0";
            textBox114.Text = "0";
            textBox115.Text = "0";
            textBox116.Text = "0";
            textBox117.Text = "0";
            textBox118.Text = "0";
            textBox119.Text = "0";
            textBox120.Text = "0";
            textBox121.Text = "0";
            textBox122.Text = "0";
            textBox123.Text = "0";
            textBox124.Text = "0";
            textBox125.Text = "0";
            textBox126.Text = "";
            textBox127.Text = "";
            textBox128.Text = "";
            textBox129.Text = "";
            textBox130.Text = "";
            textBox131.Text = "";
            textBox132.Text = "0";
            textBox133.Text = "";
            textBox134.Text = "";
            textBox135.Text = "";
            textBox136.Text = "";
            textBox137.Text = "";
            textBox138.Text = "";

        }

        private void textBox113_TextChanged(object sender, EventArgs e)
        {
            textBox113.Text = "";
        }

        private void textBox114_TextChanged(object sender, EventArgs e)
        {
            textBox114.Text = "";
        }

        private void textBox115_TextChanged(object sender, EventArgs e)
        {
            textBox115.Text = "";
        }

        private void textBox116_TextChanged(object sender, EventArgs e)
        {
            textBox116.Text = "";
        }

        private void textBox117_TextChanged(object sender, EventArgs e)
        {
            textBox117.Text = "";
        }

        private void textBox118_TextChanged(object sender, EventArgs e)
        {
            textBox118.Text = "";
        }

        private void textBox119_TextChanged(object sender, EventArgs e)
        {
            if (radioButton88.Checked == true)
                textBox119.Text = "";
        }

        private void textBox120_TextChanged(object sender, EventArgs e)
        {
            textBox120.Text = "";
        }

        private void textBox132_TextChanged(object sender, EventArgs e)
        {
            textBox132.Text = "";
        }

        private void textBox121_TextChanged(object sender, EventArgs e)
        {
            textBox121.Text = "";
        }

        private void textBox122_TextChanged(object sender, EventArgs e)
        {
            textBox122.Text = "";
        }

        private void textBox125_TextChanged(object sender, EventArgs e)
        {
            textBox125.Text = "";
        }

        private void textBox123_TextChanged(object sender, EventArgs e)
        {
            textBox123.Text = "";
        }

        private void textBox124_TextChanged(object sender, EventArgs e)
        {
            textBox124.Text = "";
        }

        double mw = 0.0;
        double tvd = 0.0;
        double hp = 0.0;
        double apl = 0.0;
        double cpre = 0.0;
        double spr = 0.0;
        double sidpp = 0.0;
        double sicp = 0.0;
        double kmw = 0.0;
        double hi = 0.0;
        double pc = 0.0;
        double pg = 0.0;
        double dcl = 0.0;
        double dpd = 0.0;
        double dcdi = 0.0;
        double hd = 0.0;
        double icp = 0.0;
        double fcp = 0.0;
        double gmr = 0.0;
        double fpre = 0.0; 
        double id = 0.0;
        double lidc = 0.0;
        double vi = 0.0;


        private void button111_Click_1(object sender, EventArgs e)
        {
            mw = Convert.ToDouble(textBox113.Text);
            tvd = Convert.ToDouble(textBox114.Text);
            if (radioButton79.Checked == true)
                tvd = tvd * 3.28084;
            hp = mw * tvd * 0.052;
            textBox129.Text = Convert.ToString(hp);
        }

        private void button111_Click_2(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.Yellow;
            textBox114.BackColor = Color.Yellow;
        }

        private void button111_Click_3(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.White;
            textBox114.BackColor = Color.White;
        }

        private void button114_Click(object sender, EventArgs e)
        {
            mw = Convert.ToDouble(textBox113.Text);
            tvd = Convert.ToDouble(textBox114.Text);
            if (radioButton79.Checked == true)
                tvd = tvd * 3.28084;
            hp = mw * tvd * 0.052;
            textBox129.Text = Convert.ToString(hp);
            apl = Convert.ToDouble(textBox115.Text);
            if (radioButton81.Checked == true)
                apl = apl * 14.6959488;
            cpre = hp + apl;
            textBox126.Text = Convert.ToString(cpre);

        }

        private void button114_Click_2(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.Yellow;
            textBox114.BackColor = Color.Yellow;
            textBox115.BackColor = Color.Yellow;
        }

        private void button114_Click_3(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.White;
            textBox114.BackColor = Color.White;
            textBox115.BackColor = Color.White;
        }

        private void button119_Click(object sender, EventArgs e)
        {
            spr = Convert.ToDouble(textBox116.Text);
            if (radioButton83.Checked == true)
                spr = spr * 14.6959488;
            sidpp = Convert.ToDouble(textBox117.Text);
            icp = sidpp + spr;
            textBox127.Text = Convert.ToString(icp);

        }

        private void button119_Click_2(object sender, EventArgs e)
        {
            textBox116.BackColor = Color.Yellow;
            textBox117.BackColor = Color.Yellow;
        }

        private void button119_Click_3(object sender, EventArgs e)
        {
            textBox116.BackColor = Color.White;
            textBox117.BackColor = Color.White;
        }

        private void button120_Click(object sender, EventArgs e)
        {
            mw = Convert.ToDouble(textBox113.Text);
            tvd = Convert.ToDouble(textBox114.Text);
            sidpp = Convert.ToDouble(textBox117.Text);
            kmw = mw + (sidpp / (tvd * 0.052));
            spr = Convert.ToDouble(textBox116.Text);
            fcp = ((kmw / mw) * spr);
            textBox128.Text = Convert.ToString(fcp);

        }

        private void button120_Click_2(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.Yellow;
            textBox119.BackColor = Color.Yellow;
            textBox116.BackColor = Color.Yellow;
        }

        private void button120_Click_3(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.White;
            textBox119.BackColor = Color.White;
            textBox116.BackColor = Color.White;
        }

        private void button121_Click(object sender, EventArgs e)
        {
            mw = Convert.ToDouble(textBox113.Text);
            tvd = Convert.ToDouble(textBox114.Text);
            sidpp = Convert.ToDouble(textBox117.Text);
            kmw = mw + (sidpp / (tvd * 0.052));
            textBox130.Text = Convert.ToString(kmw);
            if(radioButton87.Checked==true)
             textBox119.Text = Convert.ToString(kmw);
        }

        private void button121_Click_2(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.Yellow;
            textBox114.BackColor = Color.Yellow;
            textBox117.BackColor = Color.Yellow;
        }

        private void button121_Click_3(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.White;
            textBox114.BackColor = Color.White;
            textBox117.BackColor = Color.White;
        }

        private void button122_Click(object sender, EventArgs e)
        {
            mw = Convert.ToDouble(textBox113.Text);
            tvd = Convert.ToDouble(textBox114.Text);
            sidpp = Convert.ToDouble(textBox117.Text);
            fp = sidpp + (0.052 * mw * tvd);
            textBox131.Text = Convert.ToString(fp);
        }

        private void button122_Click_2(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.Yellow;
            textBox114.BackColor = Color.Yellow;
            textBox117.BackColor = Color.Yellow;
        }

        private void button122_Click_3(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.White;
            textBox114.BackColor = Color.White;
            textBox117.BackColor = Color.White;
        }

        private void button123_Click(object sender, EventArgs e)
        {

        }

        private void button125_Click(object sender, EventArgs e)
        {
            hi = Convert.ToDouble(textBox120.Text);
            sidpp = Convert.ToDouble(textBox117.Text);
            sicp = Convert.ToDouble(textBox118.Text);
            mw = Convert.ToDouble(textBox113.Text);

            hd = mw - ((sicp - sidpp) / (hi * 0.052));
            textBox133.Text = Convert.ToString(hd);

            if ((hd > 1.0) && (hd < 3.0))
                textBox134.Text = "Gas Kick";
            if ((hd > 4.0) && (hd < 6.0))
                textBox134.Text = "Oil Kick/Combination";
            if ((hd > 7.0) && (hd < 9.0))
                textBox134.Text = "Saltwater Kick";

            
        }

        private void button125_Click_2(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.Yellow;
            textBox117.BackColor = Color.Yellow;
            textBox118.BackColor = Color.Yellow;
            textBox120.BackColor = Color.Yellow;
            
        }

        private void button125_Click_3(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.White;
            textBox117.BackColor = Color.White;
            textBox118.BackColor = Color.White;
            textBox120.BackColor = Color.White;
            


        }

        private void button126_Click(object sender, EventArgs e)
        {
            mw = Convert.ToDouble(textBox113.Text);
            pc = Convert.ToDouble(textBox132.Text);
            gmr = pc / (0.052 * mw);
            textBox137.Text = Convert.ToString(gmr);
        }

        private void button126_Click_2(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.Yellow;
            textBox132.BackColor = Color.Yellow;
        }

        private void button126_Click_3(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.White;
            textBox132.BackColor = Color.White;
            
        }

        private void radioButton87_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton87.Checked == true)
                textBox119.Text = textBox130.Text;
            else
                textBox119.Text = "0";
        }

        private void button127_Click(object sender, EventArgs e)
        {
            mw = Convert.ToDouble(textBox113.Text);
            kmw = Convert.ToDouble(textBox119.Text);
            vi = (100 * (kmw - mw)) / (35.8 - kmw);
            textBox138.Text = Convert.ToString(vi);

        }
        private void button127_Click_2(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.Yellow;
            textBox119.BackColor = Color.Yellow;
        }

        private void button127_Click_3(object sender, EventArgs e)
        {
            textBox113.BackColor = Color.White;
            textBox119.BackColor = Color.White;

        }

        private void button124_Click(object sender, EventArgs e)
        {
            hd = Convert.ToDouble(textBox122.Text);
            if (radioButton95.Checked == true)
                hd = hd * 0.3937;
            dcl = Convert.ToDouble(textBox125.Text);
            if (radioButton101.Checked == true)
                dcl = dcl * 3.28084;

            dpd = Convert.ToDouble(textBox123.Text);
            if (radioButton97.Checked == true)
                dpd = dpd * 0.3937;

            dcdi = Convert.ToDouble(textBox124.Text);
            if (radioButton99.Checked == true)
                dpd = dpd * 0.3937;

            pg = Convert.ToDouble(textBox121.Text);
            if (radioButton91.Checked == true)
                pg = pg / 42.0;
            if (radioButton93.Checked == true)
                pg = pg / 158.98729;
            if (radioButton94.Checked == true)
                pg = pg * 6.28981;

            double dcc=0.0,hidc=0.0,dpc=0.0,hidp=0.0;

            dcc = ((hd * hd) - (dcdi * dcdi)) / 1029.4;
            dcc = dcc * dcl;

            if (dcc > pg)
            {
                dcc = dcc / dcl;
                hidc = pg / dcc;
                textBox135.Text = Convert.ToString(hidc);
                textBox136.Text = Convert.ToString(hidc);
            }
            else
            {
                textBox135.Text = Convert.ToString(dcl);
                pg = pg - dcc;
                dpc = ((hd * hd) - (dpd * dpd)) / 1029.4;
                hidp = pg / dpc;
                hidp = dcl + hidp;
                textBox136.Text = Convert.ToString(hidp);
            }






        
        }

        private void button124_Click_2(object sender, EventArgs e)
        {
            textBox121.BackColor = Color.Yellow;
            textBox122.BackColor = Color.Yellow;
            textBox123.BackColor = Color.Yellow;
            textBox124.BackColor = Color.Yellow;
            textBox125.BackColor = Color.Yellow;
        }

        private void button124_Click_3(object sender, EventArgs e)
        {
            textBox121.BackColor = Color.White;
            textBox122.BackColor = Color.White;
            textBox123.BackColor = Color.White;
            textBox124.BackColor = Color.White;
            textBox125.BackColor = Color.White;
            

        }



        private void button129_Click(object sender, EventArgs e)
        {
            textBox120.Text = textBox136.Text;
            radioButton90.Checked = true;

        }

        private void button107_Click(object sender, EventArgs e)
        {
            textBox116.Text = "0";
        }

        private void button123_Click_1(object sender, EventArgs e)
        {
            
        }

        private void textBox142_TextChanged(object sender, EventArgs e)
        {
            textBox142.Text = "";
        }

        private void button130_Click(object sender, EventArgs e)
        {
            textBox141.Text = "0";
        }

        private void button123_Click_2(object sender, EventArgs e)
        {
            textBox140.Text = "0";
        }

        private void button131_Click(object sender, EventArgs e)
        {
            textBox142.Text = "0";
        }

        private void button133_Click(object sender, EventArgs e)
        {
            textBox143.Text = "0";
        }

        private void button134_Click(object sender, EventArgs e)
        {
            textBox144.Text = "0";
        }

        private void button135_Click(object sender, EventArgs e)
        {
            textBox145.Text = "0";
        }

        private void button137_Click(object sender, EventArgs e)
        {
            textBox144.Text = "0";
            textBox145.Text = "0";
            textBox143.Text = "0";
            textBox141.Text = "0";
            textBox140.Text = "0";
            textBox142.Text = "0";
            textBox146.Text = "";
            textBox147.Text = "";
            textBox148.Text = "";
            textBox149.Text = "";
        }



        
        private void button132_Click(object sender, EventArgs e)
        {
            double mw = 0.0, cstvd = 0.0, lop = 0.0, loemw = 0.0, prg = 0.0;

            textBox139.Text = textBox142.Text;
            if (radioButton109.Checked == true)
                textBox143.Text = textBox142.Text;
            mw = Convert.ToDouble(textBox141.Text);
            cstvd = Convert.ToDouble(textBox140.Text);
            if (radioButton104.Checked == true)
                cstvd = cstvd * 3.28084;
            lop = Convert.ToDouble(textBox142.Text);
            loemw = (lop / (0.052 * cstvd)) + mw;
            textBox147.Text = Convert.ToString(loemw);
            prg = lop / cstvd;
            textBox146.Text = Convert.ToString(prg);
        }

        private void button132_Click_2(object sender, EventArgs e)
        {
            textBox140.BackColor = Color.Yellow;
            textBox141.BackColor = Color.Yellow;
            textBox142.BackColor = Color.Yellow;
            
        }

        private void button132_Click_3(object sender, EventArgs e)
        {
            textBox140.BackColor = Color.White;
            textBox141.BackColor = Color.White;
            textBox142.BackColor = Color.White;
        }

        private void radioButton107_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton107.Checked == true)
            {
                textBox143.Enabled = true;
                textBox142.Text = "0";
            }
            else
            {
                textBox143.Enabled = false;
                textBox143.Text = textBox142.Text;
            }
        }

        private void button136_Click(object sender, EventArgs e)
        {
            double mw = 0.0, cstvd = 0.0, lop = 0.0, bhp = 0.0, al = 0.0, bhcp = 0.0, maasp = 0.0,eqmw=0.0,frac=0.0,fracp=0.0;
            bhp = Convert.ToDouble(textBox144.Text);
            al = Convert.ToDouble(textBox145.Text);
            bhcp = bhp + al;
            textBox149.Text = Convert.ToString(bhcp);
            mw = Convert.ToDouble(textBox141.Text);
            cstvd = Convert.ToDouble(textBox140.Text);
            eqmw = bhcp / (0.052 * cstvd);
            fracp=Convert.ToDouble(textBox143.Text);
            frac=fracp/(0.052*cstvd);
            maasp=0.052*((frac-eqmw)-mw)*cstvd;
            textBox148.Text=Convert.ToString(maasp);

        }

        private void button136_Click_2(object sender, EventArgs e)
        {
            textBox140.BackColor = Color.Yellow;
            textBox141.BackColor = Color.Yellow;
            textBox143.BackColor = Color.Yellow;
            textBox144.BackColor = Color.Yellow;
            textBox145.BackColor = Color.LightGray;

        }

        private void button136_Click_3(object sender, EventArgs e)
        {
            textBox140.BackColor = Color.White;
            textBox141.BackColor = Color.White;
            textBox143.BackColor = Color.White;
            textBox144.BackColor = Color.White;
            textBox145.BackColor = Color.White;
        }

        
        
        //Home page......
        
        private void button138_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage1);
        }

        private void button139_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage8);
        }

        private void button140_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage4);
        }

        private void button143_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage9);
        }

        private void button142_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage7);
        }

        private void button141_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage6);
        }

        private void button146_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage10);
        }

        private void button145_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage11);
        }

        private void button144_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage12);
        }

        private void button148_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage3);
        }

        private void button147_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void button149_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage13);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.glossary.oilfield.slb.com/");
        }

        private void button150_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void textBox141_TextChanged(object sender, EventArgs e)
        {
            textBox141.Text = "";
        }

        private void textBox140_TextChanged(object sender, EventArgs e)
        {
            textBox140.Text = "";
        }

        private void textBox144_TextChanged(object sender, EventArgs e)
        {
            textBox144.Text = "";
        }

        private void textBox145_TextChanged(object sender, EventArgs e)
        {
            textBox145.Text = "";
        }

        private void textBox143_TextChanged(object sender, EventArgs e)
        {
            if (radioButton107.Checked == true)
                textBox143.Text = "";
        }

        private void textBox143_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Solve_Click(object sender, EventArgs e)
        {
            double sn = 0.0, se = 0.0, tn = 0.0, te = 0.0;
            double dn = 0.0, de = 0.0, hd = 0.0, az = 0.0,az1=0.0;
            
            sn = Convert.ToDouble(textBox163.Text);
            se = Convert.ToDouble(textBox166.Text);
            tn = Convert.ToDouble(textBox168.Text);
            te = Convert.ToDouble(textBox167.Text);

            // I quadrent WE-NN /
            if ((radioButton137.Checked == true) && (radioButton147.Checked == true) && (radioButton142.Checked == true) && (radioButton145.Checked == true))
            {
                dn = tn - sn;
                de = te + se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az = Math.Atan((de/dn));
                az = ((az * 180.0 * 7.0) / 22.0);
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox175.Text = Convert.ToString(az);
            }

            // I quadrent WE-SN /
            if ((radioButton136.Checked == true) && (radioButton147.Checked == true) && (radioButton142.Checked == true) && (radioButton145.Checked == true))
            {
                dn = tn + sn;
                de = te + se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az = Math.Atan((de/dn));
                az = ((az * 180.0 * 7.0) / 22.0);
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox175.Text = Convert.ToString(az);
            }

            // I quadrent EE-NN  /
            if ((radioButton137.Checked == true) && (radioButton147.Checked == true) && (radioButton143.Checked == true) && (radioButton145.Checked == true))
            {
                dn = tn - sn;
                de = te - se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az1 = de / dn;
                az = Math.Atan(az1);
                az=((az*180.0*7.0)/22.0);
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox175.Text = Convert.ToString(az);
            }

            // I quadrent EE-SN /
            if ((radioButton136.Checked == true) && (radioButton147.Checked == true) && (radioButton143.Checked == true) && (radioButton145.Checked == true))
            {
                dn = tn + sn;
                de = te - se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az = Math.Atan((de/dn));
                az = ((az * 180.0 * 7.0) / 22.0);
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox175.Text = Convert.ToString(az);
            }


            // II quadrent NN-EW /  
            if ((radioButton137.Checked == true) && (radioButton147.Checked == true) && (radioButton143.Checked == true) && (radioButton144.Checked == true))
            {
                dn = tn - sn;
                de = te + se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az = Math.Atan(dn / de);
                az = ((az * 180.0 * 7.0) / 22.0)+270.0;
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox174.Text = Convert.ToString(az);
            }

            // II quadrent SN-WW /
            if ((radioButton136.Checked == true) && (radioButton147.Checked == true) && (radioButton142.Checked == true) && (radioButton144.Checked == true))
            {
                dn = tn + sn;
                de = te - se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az = Math.Atan(dn / de);
                az = ((az * 180.0 * 7.0) / 22.0)+270.0;
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox174.Text = Convert.ToString(az);
            }

            // II quadrent  SN-EW /
            if ((radioButton136.Checked == true) && (radioButton147.Checked == true) && (radioButton143.Checked == true) && (radioButton144.Checked == true))
            {
                dn = tn + sn;
                de = te + se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az = Math.Atan(dn / de);
                az = ((az * 180.0 * 7.0) / 22.0)+270.0;
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox174.Text = Convert.ToString(az);
            }

            // II quadrent NN-WW /
            if ((radioButton137.Checked == true) && (radioButton147.Checked == true) && (radioButton142.Checked == true) && (radioButton144.Checked == true))
            {
                dn = tn - sn;
                de = te - se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az = Math.Atan(dn / de);
                az = ((az * 180.0 * 7.0) / 22.0)+270.0;
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox174.Text = Convert.ToString(az);
            }


            // III quadrent  NS-EW /
            if ((radioButton137.Checked == true) && (radioButton146.Checked == true) && (radioButton143.Checked == true) && (radioButton144.Checked == true))
            {
                dn = tn + sn;
                de = te + se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az = Math.Atan(dn / de);
                az = ((az * 180.0 * 7.0) / 22.0);
                az = (90 - az) + 180;
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox170.Text = Convert.ToString(az);
            }

            // III quadrent SS-WW /
            if ((radioButton136.Checked == true) && (radioButton146.Checked == true) && (radioButton142.Checked == true) && (radioButton144.Checked == true))
            {
                dn = tn - sn;
                de = te - se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az = Math.Atan(dn / de);
                az = ((az * 180.0 * 7.0) / 22.0);
                az = (90 - az) + 180;
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox170.Text = Convert.ToString(az);
            }

            // III quadrent NS-WW /
            if ((radioButton137.Checked == true) && (radioButton146.Checked == true) && (radioButton142.Checked == true) && (radioButton144.Checked == true))
            {
                dn = tn + sn;
                de = te - se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az = Math.Atan(dn / de);
                az = ((az * 180.0 * 7.0) / 22.0);
                az = (90 - az) + 180;
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox170.Text = Convert.ToString(az);
            }

            // III quadrent SS-EW /
            if ((radioButton136.Checked == true) && (radioButton146.Checked == true) && (radioButton143.Checked == true) && (radioButton144.Checked == true))
            {
                dn = tn - sn;
                de = te + se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az = Math.Atan(dn / de);
                az = ((az * 180.0 * 7.0) / 22.0);
                az = (90 - az) + 180;
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox170.Text = Convert.ToString(az);
            }

            // IV quadrent NS-WE /  
            if ((radioButton137.Checked == true) && (radioButton146.Checked == true) && (radioButton142.Checked == true) && (radioButton145.Checked == true))
            {
                dn = tn + sn;
                de = te + se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az = Math.Atan(dn / de);
                az = ((az * 180.0 * 7.0) / 22.0)+90.0;
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox173.Text = Convert.ToString(az);
            }

            // IV quadrent SS-EE /
            if ((radioButton136.Checked == true) && (radioButton146.Checked == true) && (radioButton143.Checked == true) && (radioButton145.Checked == true))
            {
                dn = tn - sn;
                de = te - se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az = Math.Atan(dn / de);
                az = ((az * 180.0 * 7.0) / 22.0)+90.0;
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox173.Text = Convert.ToString(az);
            }

            // IV quadrent SS-WE /
            if ((radioButton136.Checked == true) && (radioButton146.Checked == true) && (radioButton142.Checked == true) && (radioButton145.Checked == true))
            {
                dn = tn - sn;
                de = te + se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az = Math.Atan(dn / de);
                az = ((az * 180.0 * 7.0) / 22.0)+90.0;
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox173.Text = Convert.ToString(az);
            }

            // IV quadrent NS-EE /
            if ((radioButton137.Checked == true) && (radioButton146.Checked == true) && (radioButton143.Checked == true) && (radioButton145.Checked == true))
            {
                dn = tn + sn;
                de = te - se;
                hd = Math.Sqrt((dn * dn) + (de * de));
                az = Math.Atan(dn / de);
                az = ((az * 180.0 * 7.0) / 22.0)+90.0;
                textBox172.Text = Convert.ToString(hd);
                textBox171.Text = Convert.ToString(az);
                textBox173.Text = Convert.ToString(az);
            }

            az = Math.Atan(de / dn);
            az = ((az * 180.0 * 7.0) / 22.0);
            if (az < 0)
            {
                textBox173.Text = "";
                textBox170.Text = "";
                textBox174.Text = "";
                textBox175.Text = "";

                if ((dn < 0)&&(de>0))
                {
                    az = 180 + az;
                    textBox173.Text = Convert.ToString(az);
                }

                if ((dn > 0) && (de < 0))
                {
                    de=de*(-1);
                    az = Math.Atan(dn / de);
                    az = ((az * 180.0 * 7.0) / 22.0) + 270;
                    textBox174.Text = Convert.ToString(az);
                }
                
                if ((dn < 0) && (de < 0))
                {
                    dn = dn * (-1);
                    de = de * (-1);
                    az = Math.Atan(de / dn);
                    az = ((az * 180.0 * 7.0) / 22.0)+180.0;
                    textBox170.Text = Convert.ToString(az);
                }

                textBox171.Text = Convert.ToString(az);


            }



        }

        private void button165_Click(object sender, EventArgs e)
        {
            textBox163.Text = "0";
        }

        private void button168_Click(object sender, EventArgs e)
        {
            textBox166.Text = "0";
        }

        private void button170_Click(object sender, EventArgs e)
        {
            textBox168.Text = "0";
        }

        private void button169_Click(object sender, EventArgs e)
        {
            textBox167.Text = "0";
        }

        private void button172_Click(object sender, EventArgs e)
        {
            textBox171.Text = "";
            textBox172.Text = "";
            textBox167.Text = "0";
            textBox168.Text = "0";
            textBox166.Text = "0";
            textBox163.Text = "0";
            textBox173.Text = "";
            textBox170.Text = "";
            textBox174.Text = "";
            textBox175.Text = "";
        }

        double hdcp=0.0;
        private void button171_Click(object sender, EventArgs e)
        {
            hdcp = Convert.ToDouble(textBox172.Text);
        }

        private void textBox163_TextChanged(object sender, EventArgs e)
        {
            textBox163.Text = "";
        }

        private void textBox166_TextChanged(object sender, EventArgs e)
        {
            textBox166.Text = "";
        }

        private void textBox168_TextChanged(object sender, EventArgs e)
        {
            textBox168.Text = "";
        }

        private void textBox167_TextChanged(object sender, EventArgs e)
        {
            textBox167.Text = "";
        }

        private void solve_enter1(object sender, EventArgs e)
        {
            textBox167.BackColor = Color.Yellow;
            textBox168.BackColor = Color.Yellow;
            textBox166.BackColor = Color.Yellow;
            textBox163.BackColor = Color.Yellow;
 
        }

        private void solve_enter2(object sender, EventArgs e)
        {
            textBox167.BackColor = Color.White;
            textBox168.BackColor = Color.White;
            textBox166.BackColor = Color.White;
            textBox163.BackColor = Color.White;

        }

        private void radioButton113_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton113.Checked == true)
            {
                groupBox85.Enabled = true;
                groupBox93.Enabled = true;
                groupBox94.Enabled = true;
                groupBox92.Enabled = true;
                groupBox91.Enabled = true;
                groupBox95.Enabled = true;
                groupBox96.Enabled = true;
                groupBox86.Enabled = true;
                groupBox84.Enabled = false;
                groupBox86.Enabled = false;
                groupBox87.Enabled = false;
                groupBox88.Enabled = false;
            
            }

            else
            {
                groupBox85.Enabled = false;
                groupBox93.Enabled = false;
                groupBox94.Enabled = false;
                groupBox92.Enabled = false;
                groupBox91.Enabled = false;
                groupBox95.Enabled = false;
                groupBox86.Enabled = false;
                groupBox96.Enabled = false;
                groupBox84.Enabled = true;
                groupBox86.Enabled = true;
                groupBox87.Enabled = true;
                groupBox88.Enabled = true;

            }


        }

        private void button152_Click(object sender, EventArgs e)
        {
            textBox150.Text = "0";
        }

        private void button156_Click(object sender, EventArgs e)
        {
            textBox154.Text = "0";
        }

        private void button154_Click(object sender, EventArgs e)
        {
            textBox152.Text = "0";

        }

        private void button155_Click(object sender, EventArgs e)
        {
            textBox153.Text = "0";
        }

        private void button153_Click(object sender, EventArgs e)
        {
            textBox150.Text = Convert.ToString(hdcp);
        }

        private void button157_Click(object sender, EventArgs e)
        {
            textBox151.Text = Convert.ToString(hdcp);
        }

        private void button158_Click(object sender, EventArgs e)
        {
            textBox151.Text = "0";
        }

        private void button161_Click(object sender, EventArgs e)
        {
            textBox159.Text = "0";

        }

        private void button160_Click(object sender, EventArgs e)
        {
            textBox158.Text = "0";
        }

        private void button162_Click(object sender, EventArgs e)
        {
            textBox160.Text = "0";
        }

        private void button159_Click(object sender, EventArgs e)
        {
            textBox157.Text = "0";
        }

        private void button164_Click(object sender, EventArgs e)
        {
            textBox162.Text = "0";
        }

        private void button163_Click(object sender, EventArgs e)
        {
            textBox161.Text = "0";

        }

        private void button151_Click(object sender, EventArgs e)
        {
            //S
            textBox161.Text = "0";
            textBox162.Text = "0";
            textBox157.Text = "0";
            textBox160.Text = "0";
            textBox158.Text = "0";
            textBox159.Text = "0";
            textBox151.Text = "0";
            //--S
            textBox150.Text = "0";
            textBox154.Text = "0";
            textBox152.Text = "0";
            textBox153.Text = "0";

         }

        private void textBox150_TextChanged(object sender, EventArgs e)
        {
            textBox150.Text = "";
        }

        private void textBox154_TextChanged(object sender, EventArgs e)
        {
            textBox154.Text = "";
        }

        private void textBox152_TextChanged(object sender, EventArgs e)
        {
            textBox152.Text = "";
        }

        private void textBox153_TextChanged(object sender, EventArgs e)
        {
            textBox153.Text = "";
        }

        private void textBox151_TextChanged(object sender, EventArgs e)
        {
            textBox151.Text = "";
        }

        private void textBox159_TextChanged(object sender, EventArgs e)
        {
            textBox159.Text = "";
        }

        private void textBox158_TextChanged(object sender, EventArgs e)
        {
            textBox158.Text = "";
        }

        private void textBox160_TextChanged(object sender, EventArgs e)
        {
            textBox160.Text = "";
        }

        private void textBox157_TextChanged(object sender, EventArgs e)
        {
            textBox157.Text = "";
        }

        private void textBox162_TextChanged(object sender, EventArgs e)
        {
            textBox162.Text = "";
        }

        private void textBox161_TextChanged(object sender, EventArgs e)
        {
            textBox161.Text = "";
        }

        private void button150_Click_2(object sender, EventArgs e)
        {
            if (radioButton112.Checked == true)
            {
                textBox150.BackColor = Color.Yellow;
                textBox154.BackColor = Color.Yellow;
                textBox152.BackColor = Color.Yellow;
                textBox153.BackColor = Color.Yellow;
            }
            else
            {
                textBox161.BackColor = Color.Yellow;
                textBox162.BackColor = Color.Yellow;
                textBox157.BackColor = Color.Yellow;
                textBox160.BackColor = Color.Yellow;
                textBox158.BackColor = Color.LightGray;
                textBox159.BackColor = Color.Yellow;
                textBox151.BackColor = Color.Yellow;
            }
        }

        private void button150_Click_3(object sender, EventArgs e)
        {
                textBox150.BackColor = Color.White;
                textBox154.BackColor = Color.White;
                textBox152.BackColor = Color.White;
                textBox153.BackColor = Color.White;
                textBox161.BackColor = Color.White;
                textBox162.BackColor = Color.White;
                textBox157.BackColor = Color.White;
                textBox160.BackColor = Color.White;
                textBox158.BackColor = Color.White;
                textBox159.BackColor = Color.White;
                textBox151.BackColor = Color.White;
        }



        double dd_r = 0.0;
        double dd_r2 = 0.0;
        double dd_d1 = 0.0;
        double dd_d2 = 0.0;
        double dd_d22 = 0.0;
        double dd_d3 = 0.0;
        double dd_d4 = 0.0;
        double dd_d5 = 0.0;
        double dd_v1 = 0.0;
        double dd_v2 = 0.0;
        double dd_v3 = 0.0;
        double dd_v4 = 0.0;
        double dd_v5 = 0.0;
        double dd_a = 0.0;
        double dd_b = 0.0;
        double dd_a1 = 0.0;
        double dd_a2 = 0.0;
        double dd_bur = 0.0;
        double dd_dor = 0.0;
        double dd_md1 = 0.0;
        double dd_md2 = 0.0;
        double dd_md3 = 0.0;
        double dd_md4 = 0.0;
        double dd_md5 = 0.0;
        double dd_md = 0.0;
        double dd_fi = 0.0;

        private void button150_Click_1(object sender, EventArgs e)
        {


            if (radioButton112.Checked == true)
            {

                double x0 = 0.0;

                dd_v3 = Convert.ToDouble(textBox152.Text);
                if (radioButton118.Checked == true)
                    dd_v3 = dd_v3 * 3.28084;
                dd_v1 = Convert.ToDouble(textBox153.Text);
                if (radioButton120.Checked == true)
                    dd_v1 = dd_v1 * 3.28084;
                dd_bur = Convert.ToDouble(textBox154.Text);
                dd_d22 = Convert.ToDouble(textBox150.Text);


                dd_r = (360.0 * 100.0 * 7.0) / (2.0 * 22 * dd_bur);

                if (dd_r > dd_d22)
                {
                    double a = 0.0, c = 0.0, d = 0.0, b = 0.0;
                    a = (dd_v3 - dd_v1) / (dd_r - dd_d22);
                    b = (dd_r) / (dd_v3 - dd_v1);
                    a = Math.Atan(a);
                    c = ((180 * 7) / (22)) * a;
                    d = Math.Sin(a);
                    d = d * b;
                    d = Math.Acos(d);
                    d = ((180 * 7) / (22)) * d;
                    dd_a = (c - d);
                }
                else
                {
                    double a = 0.0, c = 0.0, d = 0.0, b = 0.0;
                    a = (dd_v3 - dd_v1) / (dd_d22 - dd_r);
                    b = (dd_r) / (dd_v3 - dd_v1);
                    a = Math.Atan(a);
                    c = ((180 * 7) / (22)) * a;
                    d = Math.Sin(a);
                    d = d * b;
                    d = Math.Acos(d);
                    d = ((180 * 7) / (22)) * d;
                    dd_a = 180 - (c + d);
                }

                dd_md2 = (dd_a * 100) / dd_bur;

                x0 = (22.0 / (180.0 * 7.0)) * dd_a;  //deg to rad


                dd_v2 = dd_v1 + (dd_r * Math.Sin(x0));

                dd_d1 = dd_r * (1 - Math.Cos(x0));

                dd_md3 = (dd_v3 - dd_v1) * (Math.Cos(x0));

                dd_md1 = dd_v1;

                dd_d2 = dd_d1 + (dd_md3 * Math.Sin(x0));

                dd_md = dd_md1 + dd_md2 + dd_md3;


                if (dd_r < dd_d22)
                {
                    tabControl2.SelectTab(tabPage15);
                    textBox223.Text = Convert.ToString(dd_r);
                    textBox180.Text = Convert.ToString(dd_r);
                    textBox178.Text = Convert.ToString(dd_a);
                    textBox179.Text = Convert.ToString(dd_a);
                    textBox222.Text = Convert.ToString(dd_a);
                    textBox221.Text = Convert.ToString(dd_md2);
                    textBox220.Text = Convert.ToString(dd_v2 - dd_v1);
                    textBox224.Text = Convert.ToString(dd_d1);
                    textBox156.Text = Convert.ToString(dd_d1);
                    textBox225.Text = Convert.ToString(dd_md3);
                    textBox228.Text = Convert.ToString(dd_md);
                    textBox226.Text = Convert.ToString(dd_v3 - dd_v2);
                    textBox227.Text = Convert.ToString(dd_d22);
                    textBox155.Text = Convert.ToString(dd_d22);
                    textBox169.Text = Convert.ToString(dd_v3);
                    textBox176.Text = Convert.ToString(dd_v2);
                    textBox177.Text = Convert.ToString(dd_v1);
                }
                else
                {
                    tabControl2.SelectTab(tabPage16);
                    textBox237.Text = Convert.ToString(dd_r);
                    textBox181.Text = Convert.ToString(dd_r);
                    textBox183.Text = Convert.ToString(dd_a);
                    textBox182.Text = Convert.ToString(dd_a);
                    textBox236.Text = Convert.ToString(dd_a);
                    textBox235.Text = Convert.ToString(dd_md2);
                    textBox234.Text = Convert.ToString(dd_v2 - dd_v1);
                    textBox233.Text = Convert.ToString(dd_d22);
                    textBox188.Text = Convert.ToString(dd_d22);
                    textBox232.Text = Convert.ToString(dd_md3);
                    textBox229.Text = Convert.ToString(dd_md);
                    textBox231.Text = Convert.ToString(dd_v3 - dd_v2);
                    textBox230.Text = Convert.ToString(dd_d2);
                    textBox187.Text = Convert.ToString(dd_d2);
                    textBox184.Text = Convert.ToString(dd_v3);
                    textBox185.Text = Convert.ToString(dd_v2);
                    textBox186.Text = Convert.ToString(dd_v1);
                }
            }
            else
            {
                double x0 = 0.0, x02 = 0.0;
                dd_fi = Convert.ToDouble(textBox162.Text);

                if (dd_fi == 0)
                {
                    dd_v4 = Convert.ToDouble(textBox161.Text);
                    if (radioButton133.Checked == true)
                        dd_v4 = dd_v4 * 3.28084;
                    dd_v1 = Convert.ToDouble(textBox159.Text);
                    if (radioButton130.Checked == true)
                        dd_v1 = dd_v1 * 3.28084;
                    dd_bur = Convert.ToDouble(textBox157.Text);
                    dd_dor = Convert.ToDouble(textBox160.Text);
                    dd_d3 = Convert.ToDouble(textBox151.Text);
                    dd_v5 = Convert.ToDouble(textBox158.Text);
                    if (radioButton128.Checked == true)
                        dd_v5 = dd_v5 * 3.28084;
                }
                else
                {
                    dd_v4 = Convert.ToDouble(textBox161.Text);
                    if (radioButton133.Checked == true)
                        dd_v4 = dd_v4 * 3.28084;
                    dd_v5 = Convert.ToDouble(textBox158.Text);
                    if (radioButton128.Checked == true)
                        dd_v5 = dd_v5 * 3.28084;
                    dd_v1 = Convert.ToDouble(textBox159.Text);
                    if (radioButton130.Checked == true)
                        dd_v1 = dd_v1 * 3.28084;
                    dd_bur = Convert.ToDouble(textBox157.Text);
                    dd_dor = Convert.ToDouble(textBox160.Text);
                    dd_d4 = Convert.ToDouble(textBox151.Text);

                }


                dd_r = (360.0 * 100.0 * 7.0) / (2.0 * 22 * dd_bur);
                dd_r2 = (360.0 * 100.0 * 7.0) / (2.0 * 22 * dd_dor);

                if (((dd_r + dd_r2) > dd_d3) && (dd_fi == 0))
                {
                    double a = 0.0, c = 0.0, d = 0.0, b = 0.0;
                    a = (dd_v4 - dd_v1) / ((dd_r + dd_r2) - dd_d3);
                    b = (dd_r + dd_r2) / (dd_v4 - dd_v1);
                    a = Math.Atan(a);
                    c = ((180 * 7) / (22)) * a;
                    d = Math.Sin(a);
                    d = d * b;
                    d = Math.Acos(d);
                    d = ((180 * 7) / (22)) * d;
                    dd_a = c - d;
                }
                else if (((dd_r + dd_r2) < dd_d3) && (dd_fi == 0))
                {
                    double a = 0.0, c = 0.0, d = 0.0, b = 0.0;
                    a = (dd_v4 - dd_v1) / (dd_d3 - (dd_r + dd_r2));
                    b = (dd_r + dd_r2) / (dd_v4 - dd_v1);
                    a = Math.Atan(a);
                    c = ((180 * 7) / (22)) * a;
                    d = Math.Sin(a);
                    d = d * b;
                    d = Math.Acos(d);
                    d = ((180 * 7) / (22)) * d;
                    dd_a = 180 - (c + d);

                }
                else
                {
                    x02 = (22.0 / (180.0 * 7.0)) * dd_fi;
                    dd_d3 = dd_d4 - ((dd_v5 - dd_v4) * Math.Tan(x02));
                    double y0 = 0.0, n0 = 0.0, d0 = 0.0, a0 = 0.0, b0 = 0.0, x03 = 0.0;
                    if (dd_d3 < (dd_r + (dd_r2 * Math.Cos(x02))))
                    {
                        y0 = dd_r + (dd_r2 * Math.Cos(x02)) + ((dd_v5 - dd_v4) * Math.Tan(x02)) - dd_d4;
                        n0 = dd_r - (dd_d3 - dd_r2);
                        d0 = dd_v4 - dd_v1;
                        dd_b = Math.Atan(n0 / d0);
                        dd_b = ((180 * 7) / (22)) * dd_b;  //rad to deg
                        x03 = (22.0 / (180.0 * 7.0)) * dd_b;  //deg to rad
                        a0 = Math.Atan(y0 / (dd_v4 + ((dd_r + dd_r2) * Math.Sin(x03)) - dd_r2));
                        b0 = Math.Asin(((dd_r + dd_r2) * Math.Sin(a0)) / y0);
                        dd_a = b0 - a0;
                        dd_a = ((180 * 7) / (22)) * dd_a; // rad to deg
                    }
                    else
                    {
                        y0 = dd_v4 - dd_r - (dd_r2 * Math.Cos(x02)) - ((dd_v5 - dd_v4) * Math.Tan(x02)) - dd_d4;
                        n0 = dd_d3 - (dd_r2 + dd_r);
                        d0 = dd_v4 - dd_v1;
                        dd_b = Math.Atan(n0 / d0);
                        dd_b = ((180 * 7) / (22)) * dd_b;  //rad to deg
                        x03 = (22.0 / (180.0 * 7.0)) * dd_b;  //deg to rad
                        a0 = Math.Atan(y0 / (dd_v4 + ((dd_r + dd_r2) * Math.Sin(x03)) - dd_r2));
                        b0 = Math.Asin(((dd_r + dd_r2) * Math.Sin(a0)) / y0);
                        dd_a = b0 + a0;
                        dd_a = ((180 * 7) / (22)) * dd_a; // rad to deg
                    }

                }


                x0 = (22.0 / (180.0 * 7.0)) * dd_a;  //deg to rad
                x02 = (22.0 / (180.0 * 7.0)) * dd_fi;
                dd_md1 = dd_v1;

                //Build Up Section
                dd_md2 = (dd_a * 100) / dd_bur;
                dd_v2 = dd_v1 + (dd_r * Math.Sin(x0));
                dd_d1 = dd_r * (1 - Math.Cos(x0));

                //Tangent Section
                dd_v3 = dd_v4 - (dd_r2 * (Math.Sin(x0) - Math.Sin(x02)));
                dd_md3 = (dd_v3 - dd_v2) / (Math.Cos(x0));
                dd_d22 = dd_d1 + ((dd_v3 - dd_v2) * Math.Tan(x0));

                //Drop-Off Section
                dd_md4 = ((dd_a - dd_fi) * 100) / (dd_dor);

                dd_md = dd_md1 + dd_md2 + dd_md3 + dd_md4;

                if (dd_v5 > 0)
                    dd_md = dd_md + ((dd_v5 - dd_v4) / Math.Cos(x02));


                if (((dd_r + dd_r2) < dd_d3) && (dd_fi == 0))
                {
                    tabControl2.SelectTab(tabPage17);
                    textBox246.Text = Convert.ToString(dd_r);
                    textBox198.Text = Convert.ToString(dd_r);
                    textBox245.Text = Convert.ToString(dd_r2);
                    textBox197.Text = Convert.ToString(dd_r2);
                    textBox244.Text = Convert.ToString(dd_md2);
                    textBox243.Text = Convert.ToString(dd_v2 - dd_v1);
                    textBox242.Text = Convert.ToString(dd_d1);
                    textBox194.Text = Convert.ToString(dd_d1);
                    textBox241.Text = Convert.ToString(dd_md3);
                    textBox240.Text = Convert.ToString(dd_v3 - dd_v2);
                    textBox239.Text = Convert.ToString(dd_d22);
                    textBox195.Text = Convert.ToString(dd_d22);
                    textBox248.Text = Convert.ToString(dd_md4);
                    textBox247.Text = Convert.ToString(dd_v4 - dd_v3);
                    textBox238.Text = Convert.ToString(dd_d3);
                    textBox196.Text = Convert.ToString(dd_d3);
                    textBox249.Text = Convert.ToString(dd_v5);
                    textBox250.Text = Convert.ToString(dd_md);
                    textBox251.Text = Convert.ToString(dd_a);
                    textBox189.Text = Convert.ToString(dd_v5);
                    textBox190.Text = Convert.ToString(dd_v4);
                    textBox191.Text = Convert.ToString(dd_v3);
                    textBox192.Text = Convert.ToString(dd_v2);
                    textBox193.Text = Convert.ToString(dd_v1);
                }
                else if (((dd_r + dd_r2) > dd_d3) && (dd_fi == 0))
                {
                    tabControl2.SelectTab(tabPage18);
                    textBox265.Text = Convert.ToString(dd_r);
                    textBox208.Text = Convert.ToString(dd_r);
                    textBox264.Text = Convert.ToString(dd_r2);
                    textBox207.Text = Convert.ToString(dd_r2);
                    textBox263.Text = Convert.ToString(dd_md2);
                    textBox262.Text = Convert.ToString(dd_v2 - dd_v1);
                    textBox261.Text = Convert.ToString(dd_d1);
                    textBox204.Text = Convert.ToString(dd_d1);
                    textBox260.Text = Convert.ToString(dd_md3);
                    textBox259.Text = Convert.ToString(dd_v3 - dd_v2);
                    textBox258.Text = Convert.ToString(dd_d22);
                    textBox205.Text = Convert.ToString(dd_d22);
                    textBox257.Text = Convert.ToString(dd_md4);
                    textBox256.Text = Convert.ToString(dd_v4 - dd_v3);
                    textBox255.Text = Convert.ToString(dd_d3);
                    textBox206.Text = Convert.ToString(dd_d3);
                    textBox254.Text = Convert.ToString(dd_v5);
                    textBox253.Text = Convert.ToString(dd_md);
                    textBox252.Text = Convert.ToString(dd_a);
                    textBox199.Text = Convert.ToString(dd_v5);
                    textBox200.Text = Convert.ToString(dd_v4);
                    textBox201.Text = Convert.ToString(dd_v3);
                    textBox202.Text = Convert.ToString(dd_v2);
                    textBox203.Text = Convert.ToString(dd_v1);
                }
                else
                {
                    tabControl2.SelectTab(tabPage19);
                    textBox279.Text = Convert.ToString(dd_r);
                    textBox217.Text = Convert.ToString(dd_r);
                    textBox278.Text = Convert.ToString(dd_r2);
                    textBox218.Text = Convert.ToString(dd_r2);
                    textBox277.Text = Convert.ToString(dd_md2);
                    textBox276.Text = Convert.ToString(dd_v2 - dd_v1);
                    textBox275.Text = Convert.ToString(dd_d1);
                    textBox216.Text = Convert.ToString(dd_d1);
                    textBox274.Text = Convert.ToString(dd_md3);
                    textBox273.Text = Convert.ToString(dd_v3 - dd_v2);
                    textBox272.Text = Convert.ToString(dd_d22);
                    textBox215.Text = Convert.ToString(dd_d22);
                    textBox271.Text = Convert.ToString(dd_md4);
                    textBox270.Text = Convert.ToString(dd_v4 - dd_v3);
                    textBox280.Text = Convert.ToString(dd_d3);
                    textBox219.Text = Convert.ToString(dd_d3);
                    textBox214.Text = Convert.ToString(dd_d4);
                    textBox269.Text = Convert.ToString(dd_d4);
                    textBox268.Text = Convert.ToString(dd_v5);
                    textBox267.Text = Convert.ToString(dd_md);
                    textBox266.Text = Convert.ToString(dd_a);
                    textBox282.Text = Convert.ToString(dd_fi);
                    textBox281.Text = Convert.ToString(dd_a - dd_fi);
                    textBox213.Text = Convert.ToString(dd_v5);
                    textBox212.Text = Convert.ToString(dd_v4);
                    textBox211.Text = Convert.ToString(dd_v3);
                    textBox210.Text = Convert.ToString(dd_v2);
                    textBox209.Text = Convert.ToString(dd_v1);
                }













            }

        }

        private void radioButton116_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton116.Checked == true)
            {
                textBox283.Text = "3.14";
                textBox284.Text = "94";
                textBox285.Text = "1";
                textBox286.Text = "3.6";
                textBox287.Text = "5.19";
                textBox288.Text = "15.6";
                textBox289.Text = "1.18";
            }
            textBox283.Enabled = false;
            textBox284.Enabled = false;
            textBox285.Enabled = false;
            textBox286.Enabled = false;
            textBox287.Enabled = false;
            textBox288.Enabled = false;
            textBox289.Enabled = false;

            

        }

        private void radioButton117_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton117.Checked == true)
            {
                textBox283.Text = "3.14";
                textBox284.Text = "94";
                textBox285.Text = "1";
                textBox286.Text = "3.6";
                textBox287.Text = "6.32";
                textBox288.Text = "14.8";
                textBox289.Text = "1.33";
            }
            textBox283.Enabled = false;
            textBox284.Enabled = false;
            textBox285.Enabled = false;
            textBox286.Enabled = false;
            textBox287.Enabled = false;
            textBox288.Enabled = false;
            textBox289.Enabled = false;
        }

        private void radioButton122_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton122.Checked == true)
            {
                textBox283.Text = "3.15";
                textBox284.Text = "94";
                textBox285.Text = "1";
                textBox286.Text = "3.58";
                textBox287.Text = "4.97";
                textBox288.Text = "15.8";
                textBox289.Text = "1.14";
            }
            textBox283.Enabled = false;
            textBox284.Enabled = false;
            textBox285.Enabled = false;
            textBox286.Enabled = false;
            textBox287.Enabled = false;
            textBox288.Enabled = false;
            textBox289.Enabled = false;
        }

        private void radioButton124_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton124.Checked == true)
            {
                textBox283.Text = "3.15";
                textBox284.Text = "94";
                textBox285.Text = "1";
                textBox286.Text = "3.58";
                textBox287.Text = "4.29";
                textBox288.Text = "16.5";
                textBox289.Text = "1.05";
            }
            textBox283.Enabled = false;
            textBox284.Enabled = false;
            textBox285.Enabled = false;
            textBox286.Enabled = false;
            textBox287.Enabled = false;
            textBox288.Enabled = false;
            textBox289.Enabled = false;
        }

        private void radioButton125_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton125.Checked == true)
            {
                textBox283.Text = "3.16";
                textBox284.Text = "94";
                textBox285.Text = "1";
                textBox286.Text = "3.57";
                textBox287.Text = "4.29";
                textBox288.Text = "16.5";
                textBox289.Text = "1.05";
            }
            textBox283.Enabled = false;
            textBox284.Enabled = false;
            textBox285.Enabled = false;
            textBox286.Enabled = false;
            textBox287.Enabled = false;
            textBox288.Enabled = false;
            textBox289.Enabled = false;
        }

        private void radioButton126_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton126.Checked == true)
            {
                textBox283.Text = "";
                textBox284.Text = "";
                textBox285.Text = "";
                textBox286.Text = "";
                textBox287.Text = "";
                textBox288.Text = "";
                textBox289.Text = "";
            }
            textBox283.Enabled = true;
            textBox284.Enabled = true;
            textBox285.Enabled = true;
            textBox286.Enabled = true;
            textBox287.Enabled = true;
            textBox288.Enabled = true;
            textBox289.Enabled = true;
        }

        private void groupBox124_Enter(object sender, EventArgs e)
        {

        }

        private void button173_Click(object sender, EventArgs e)
        {
            textBox290.Text = "0";
            textBox291.Text = "0";
            textBox292.Text = "0";
        }

        private void button174_Click(object sender, EventArgs e)
        {
            textBox293.Text = "0";
        }

        private void button175_Click(object sender, EventArgs e)
        {
            textBox296.Text = "0";
            textBox295.Text = "0";
        }

        private void button176_Click(object sender, EventArgs e)
        {
            textBox294.Text = "0";
        }

        private void button177_Click(object sender, EventArgs e)
        {
            textBox297.Text = "0";
        }

        private void button178_Click(object sender, EventArgs e)
        {
            textBox298.Text = "0";
        }

        private void button179_Click(object sender, EventArgs e)
        {
            textBox299.Text = "0";
            textBox300.Text = "0";
        }

        private void button180_Click(object sender, EventArgs e)
        {
            textBox302.Text = "0";
            textBox301.Text = "0";
        }

        private void button181_Click(object sender, EventArgs e)
        {
            textBox304.Text = "0";
            textBox303.Text = "0";
        }

        private void button182_Click(object sender, EventArgs e)
        {
            textBox305.Text = "0";
        }

        private void button183_Click(object sender, EventArgs e)
        {
            textBox306.Text = "0";
        }

        private void button189_Click(object sender, EventArgs e)
        {
            textBox290.Text = "0";
            textBox291.Text = "0";
            textBox292.Text = "0";
            textBox293.Text = "0";
            textBox294.Text = "0";
            textBox295.Text = "0";
            textBox296.Text = "0";
            textBox297.Text = "0";
            textBox298.Text = "0";
            textBox299.Text = "0";
            textBox300.Text = "0";
            textBox301.Text = "0";
            textBox302.Text = "0";
            textBox303.Text = "0";
            textBox304.Text = "0";
            textBox305.Text = "0";
            textBox306.Text = "0";
            textBox307.Text = "";
            textBox308.Text = "";
            textBox309.Text = "";
            textBox310.Text = "";
            textBox311.Text = "";
            textBox312.Text = "";
            textBox313.Text = "";
            textBox314.Text = "";
            textBox315.Text = "";
            textBox316.Text = "";
            textBox317.Text = "";
            textBox318.Text = "";
        }

        private void button184_Click(object sender, EventArgs e)
        {
            textBox305.Text = Convert.ToString(cp2);
        }

        private void button185_Click(object sender, EventArgs e)
        {
            textBox306.Text = Convert.ToString(cp4);
        }

        private void button186_Click_2(object sender, EventArgs e)
        {
            textBox290.BackColor = Color.Yellow;
            textBox291.BackColor = Color.Yellow;
            textBox292.BackColor = Color.Yellow;
            textBox284.BackColor = Color.Yellow;
            textBox287.BackColor = Color.Yellow;
            textBox283.BackColor = Color.Yellow;


        }

        private void button186_Click_3(object sender, EventArgs e)
        {
            textBox290.BackColor = Color.White;
            textBox291.BackColor = Color.White;
            textBox292.BackColor = Color.White;
            textBox284.BackColor = Color.White;
            textBox287.BackColor = Color.White;
            textBox283.BackColor = Color.White;
        }

        private void button187_Click_2(object sender, EventArgs e)
        {
            textBox293.BackColor = Color.Yellow;
            textBox294.BackColor = Color.Yellow;
            textBox295.BackColor = Color.Yellow;
            textBox296.BackColor = Color.Yellow;
            textBox297.BackColor = Color.Yellow;
            textBox298.BackColor = Color.LightGray;
            textBox299.BackColor = Color.Yellow;
            textBox300.BackColor = Color.Yellow;
            textBox301.BackColor = Color.Yellow;
            textBox302.BackColor = Color.Yellow;
            textBox306.BackColor = Color.LightGray;
            
        }

        private void button187_Click_3(object sender, EventArgs e)
        {
            textBox293.BackColor = Color.White;
            textBox294.BackColor = Color.White;
            textBox295.BackColor = Color.White;
            textBox296.BackColor = Color.White;
            textBox287.BackColor = Color.White;
            textBox297.BackColor = Color.White;
            textBox298.BackColor = Color.White;
            textBox299.BackColor = Color.White;
            textBox300.BackColor = Color.White;
            textBox301.BackColor = Color.White;
            textBox302.BackColor = Color.White;
            textBox306.BackColor = Color.White;
        }

        private void button188_Click_2(object sender, EventArgs e)
        {
            textBox293.BackColor = Color.Yellow;
            textBox294.BackColor = Color.Yellow;
            textBox295.BackColor = Color.Yellow;
            textBox296.BackColor = Color.Yellow;
            textBox297.BackColor = Color.Yellow;
            textBox298.BackColor = Color.LightGray;
            textBox303.BackColor = Color.Yellow;
            textBox304.BackColor = Color.Yellow;
            textBox305.BackColor = Color.Yellow;
            textBox306.BackColor = Color.LightGray;
        }

        private void button188_Click_3(object sender, EventArgs e)
        {
            textBox293.BackColor = Color.White;
            textBox294.BackColor = Color.White;
            textBox295.BackColor = Color.White;
            textBox296.BackColor = Color.White;
            textBox297.BackColor = Color.White;
            textBox298.BackColor = Color.White;
            textBox303.BackColor = Color.White;
            textBox304.BackColor = Color.White;
            textBox305.BackColor = Color.White;
            textBox306.BackColor = Color.White;
        }
        
        
        
        
        

        private void textBox292_TextChanged(object sender, EventArgs e)
        {
            textBox292.Text = "";
        }

        private void textBox291_TextChanged(object sender, EventArgs e)
        {
            textBox291.Text = "";
        }

        private void textBox290_TextChanged(object sender, EventArgs e)
        {
            textBox290.Text = "";
        }

        private void textBox293_TextChanged(object sender, EventArgs e)
        {
            textBox293.Text = "";
        }

        private void textBox296_TextChanged(object sender, EventArgs e)
        {
            textBox296.Text = "";
        }

        private void textBox295_TextChanged(object sender, EventArgs e)
        {
            textBox295.Text = "";
        }

        private void textBox294_TextChanged(object sender, EventArgs e)
        {
            textBox294.Text = "";
        }

        private void textBox297_TextChanged(object sender, EventArgs e)
        {
            textBox297.Text = "";
        }

        private void textBox298_TextChanged(object sender, EventArgs e)
        {
            textBox298.Text = "";
        }

        private void textBox300_TextChanged(object sender, EventArgs e)
        {
            textBox300.Text = "";
        }

        private void textBox299_TextChanged(object sender, EventArgs e)
        {
            textBox299.Text = "";
        }

        private void textBox302_TextChanged(object sender, EventArgs e)
        {
            textBox302.Text = "";
        }

        private void textBox301_TextChanged(object sender, EventArgs e)
        {
            textBox301.Text = "";
        }

        private void textBox304_TextChanged(object sender, EventArgs e)
        {
            textBox304.Text = "";
        }

        private void textBox303_TextChanged(object sender, EventArgs e)
        {
            textBox303.Text = "";
        }

        private void textBox305_TextChanged(object sender, EventArgs e)
        {
            textBox305.Text = "";
        }

        private void textBox306_TextChanged(object sender, EventArgs e)
        {
            textBox306.Text = "";
        }




        private void button186_Click(object sender, EventArgs e)
        {
            double wt=0.0, wn=0.0, sg=0.0, awn=0.0, pa=0.0,wa=0.0,twr=0.0;
            double vs = 0.0, csg = 0.0,sy=0.0,sd=0.0;
            wt = Convert.ToDouble(textBox284.Text);
            wn = Convert.ToDouble(textBox287.Text);
            sg = Convert.ToDouble(textBox292.Text);
            awn = Convert.ToDouble(textBox291.Text);
            pa = Convert.ToDouble(textBox290.Text);
            pa = pa / 100.0;
            csg = Convert.ToDouble(textBox283.Text);

            //wt. of additive
            wa = pa * wt;
            textBox318.Text = Convert.ToString(wa);

            //Total water require
            twr = wn + awn;
            textBox317.Text = Convert.ToString(twr);

            //volume slurry
            vs = (wt / (csg * 8.33)) + (wa / (sg * 8.33)) + twr;
            textBox316.Text = Convert.ToString(vs);

            //Slurry Yield
            sy = vs / 7.48;
            textBox314.Text = Convert.ToString(sy);

            //slurry density
            sd = (wt + wa + (8.33 * twr)) / vs;
            textBox315.Text = Convert.ToString(sd);


        }

        
        private void button187_Click(object sender, EventArgs e)
        {
            double cstvd = 0.0, cod = 0.0, cid = 0.0, hs = 0.0, fc = 0.0, ev = 0.0, lch = 0.0, lcy = 0.0;
            double tch = 0.0, tcy = 0.0, pf = 0.0, ac1=0.0,ac2=0.0,ac3=0.0,lc=0.0,tc=0.0,mr=0.0,br=0.0;

            cstvd = Convert.ToDouble(textBox293.Text);
            if (radioButton148.Checked == true)
                cstvd = cstvd * 3.28084;
            cod = Convert.ToDouble(textBox296.Text);
            cid = Convert.ToDouble(textBox295.Text);
            hs = Convert.ToDouble(textBox294.Text);
            fc = Convert.ToDouble(textBox297.Text);
            ev = Convert.ToDouble(textBox298.Text);
            ev = ev / 100.0;
            ev = ev + 1.0;
            lch = Convert.ToDouble(textBox300.Text);
            lcy = Convert.ToDouble(textBox299.Text);
            tch = Convert.ToDouble(textBox302.Text);
            tcy = Convert.ToDouble(textBox301.Text);
            pf = Convert.ToDouble(textBox306.Text);

            //Annular capacities.
            ac1 = ((hs * hs) - (cod * cod)) / 183.35;
            ac2 = (cid * cid) / 183.35;
            ac3 = (cid * cid) / 1029.4;

            //Lead Cement
            lc = (lch * ac1 * ev) / lcy;
            textBox308.Text = Convert.ToString(lc);

            //Tail Cement
            tc = ((tch * ac1 * ev) / tcy)+((fc*ac2)/tcy);
            textBox313.Text = Convert.ToString(tc);

            //Mud required
            mr = (cstvd - fc) * ac3;
            textBox309.Text = Convert.ToString(mr);

            //Barrels Reqd.
            if (pf > 0)
            {
                br = mr / pf;
                textBox307.Text = Convert.ToString(br);
            }


        }

        
        private void button188_Click(object sender, EventArgs e)
        {
            double cstvd = 0.0, cod = 0.0, cid = 0.0, hs = 0.0, fc = 0.0, ev = 0.0,dpid=0.0,tc=0.0,mr=0.0;
            double tcy = 0.0, pf = 0.0, ac1 = 0.0, ac2 = 0.0, ac3 = 0.0,sv=0.0,cac=0.0,cha=0.0,da=0.0,ps=0.0;

            cstvd = Convert.ToDouble(textBox293.Text);
            if (radioButton148.Checked == true)
                cstvd = cstvd * 3.28084;
            cod = Convert.ToDouble(textBox296.Text);
            cid = Convert.ToDouble(textBox295.Text);
            hs = Convert.ToDouble(textBox294.Text);
            fc = Convert.ToDouble(textBox297.Text);
            ev = Convert.ToDouble(textBox298.Text);
            ev = ev / 100.0;
            ev = ev + 1.0;
            tc = Convert.ToDouble(textBox304.Text);
            tcy = Convert.ToDouble(textBox303.Text);
            pf = Convert.ToDouble(textBox306.Text);
            dpid = Convert.ToDouble(textBox305.Text);
            if (radioButton150.Checked == true)
                dpid = dpid * 0.3937;

            //Annular capacities.
            ac1 = ((hs * hs) - (cod * cod)) / 183.35;
            ac2 = (cid * cid) / 183.35;
            ac3 = (dpid * dpid) / 1029.4;

            //Slurry Vol
            sv = tc * tcy;
            textBox312.Text = Convert.ToString(sv);

            //Cement in Casing
            cac = fc * ac2;
            textBox311.Text = Convert.ToString(cac);

            //height of cement annulus
            cha = (sv - cac) / (ev * ac1);
            textBox310.Text = Convert.ToString(cha);

            //depth in annulus w/o cement
            da = cstvd - cha;

            //Mud required
            mr = (cstvd - fc) * ac3;
            textBox309.Text = Convert.ToString(mr);

            //Strokes needed
            ps = mr / pf;
            textBox307.Text = Convert.ToString(ps);





        }




        //  Adding more functionality to the previous parts

        //DrillString
        private void textBox53_Click(object sender, EventArgs e)
        {
            textBox53.Text = "";
        }

        private void textBox66_Click(object sender, EventArgs e)
        {
            textBox66.Text = "";
        }

        private void textBox48_Click(object sender, EventArgs e)
        {
            textBox48.Text = "";
        }

        private void textBox99_Click(object sender, EventArgs e)
        {
            textBox99.Text = "";
        }

        private void textBox100_Click(object sender, EventArgs e)
        {
            textBox100.Text = "";
        }

        private void textBox101_Click(object sender, EventArgs e)
        {
            textBox101.Text = "";
        }

        private void textBox102_Click(object sender, EventArgs e)
        {
            textBox102.Text = "";
        }

        private void textBox103_Click(object sender, EventArgs e)
        {
            textBox103.Text = "";
        }

        private void textBox104_Click(object sender, EventArgs e)
        {
            textBox104.Text = "";
        }

        private void textBox105_Click(object sender, EventArgs e)
        {
            textBox105.Text = "";
        }

        private void textBox106_Click(object sender, EventArgs e)
        {
            textBox106.Text = "";
        }

        private void textBox107_Click(object sender, EventArgs e)
        {
            textBox107.Text = "";
        }

        private void textBox73_Click(object sender, EventArgs e)
        {
            textBox73.Text = "";
        }

        private void textBox74_Click(object sender, EventArgs e)
        {
            textBox74.Text = "";
        }

        private void textBox75_Click(object sender, EventArgs e)
        {
            textBox75.Text = "";
        }

        private void textBox78_Click(object sender, EventArgs e)
        {
            textBox78.Text = "";
        }

        private void textBox77_Click(object sender, EventArgs e)
        {
            textBox77.Text = "";
        }

        private void textBox76_Click(object sender, EventArgs e)
        {
            textBox76.Text = "";
        }

        private void textBox81_TextChanged(object sender, EventArgs e)
        {
            textBox81.Text = "";
        }

        private void textBox80_Click(object sender, EventArgs e)
        {
            textBox80.Text = "";
        }

        private void textBox79_Click(object sender, EventArgs e)
        {
            textBox79.Text = "";
        }

        private void textBox84_Click(object sender, EventArgs e)
        {
            textBox84.Text = "";
        }

        private void textBox83_Click(object sender, EventArgs e)
        {
            textBox83.Text = "";
        }

        private void textBox82_Click(object sender, EventArgs e)
        {
            textBox82.Text = "";
        }

        private void textBox87_Click(object sender, EventArgs e)
        {
            textBox87.Text = "";
        }

        private void textBox86_Click(object sender, EventArgs e)
        {
            textBox86.Text = "";
        }

        private void textBox85_Click(object sender, EventArgs e)
        {
            textBox85.Text = "";
        }

        private void textBox90_Click(object sender, EventArgs e)
        {
            textBox90.Text = "";
        }

        private void textBox89_Click(object sender, EventArgs e)
        {
            textBox89.Text = "";
        }

        private void textBox88_Click(object sender, EventArgs e)
        {
            textBox88.Text = "";
        }

        private void textBox93_Click(object sender, EventArgs e)
        {
            textBox93.Text = "";
        }

        private void textBox91_Click(object sender, EventArgs e)
        {
            textBox91.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.Text = "";
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }



























        


    }










        


               
              
               

        }





        
    
    
    

       


