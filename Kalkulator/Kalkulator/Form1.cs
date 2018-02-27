using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Kalkulator : Form
    {
        int hereket = 0;
        double saxlananlar;
        public Kalkulator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == string.Empty))
            {
                hereket = 1;
                saxlananlar = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else
            {
                return;
            }
            
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == string.Empty))
            {
                hereket = 2;
                saxlananlar = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else
            {
                return;
            }
        }
        private void vurma_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == string.Empty))
            {
                hereket = 3;
                saxlananlar = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else
            {
                return;
            }
        }
        private void bolme_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == string.Empty))
            {
                hereket = 4;
                saxlananlar = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
            }
            else
            {
                return;
            }
        }

        private void beraber_Click(object sender, EventArgs e)
        {
            if (hereket == 1)
            {
                double cavab = saxlananlar + Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(cavab);
                
            }
            else if (hereket == 2)
            {
                double cavab = saxlananlar - Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(cavab);
               
            }
            else if (hereket == 3)
            {
                double cavab = saxlananlar * Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(cavab);
               
            }
            else if (hereket == 4)
            {
                double sonsuzluq = double.Parse(textBox1.Text);
                if ( sonsuzluq ==0.0 )
                {
                    textBox1.Text = "Sifra bolmek olmaz";
                }
                else
                {
                    double cavab = saxlananlar / Convert.ToDouble(textBox1.Text);
                    textBox1.Text = Convert.ToString(cavab);
                }
                
              
            }
        }

        private void hamisiniSilen_Click(object sender, EventArgs e)
        {
            hereket = 0;
            textBox1.Text = "";
        }
        bool heYox = true;
        private void buttonVergul_Click(object sender, EventArgs e)
        {
            if (heYox==true)
            {
                if ((textBox1.Text == string.Empty))
                {
                    textBox1.Text = "";


                }
                else
                {
                    textBox1.Text += ",";
                    heYox = false;
                }
            } 
        }

        private void button10_Click(object sender, EventArgs e)
        {

            int length = textBox1.Text.Length - 1; 
            string butunReqem = textBox1.Text;
            textBox1.Clear();
            for (int i=0; i<length; i++)
            {
                textBox1.Text = textBox1.Text + butunReqem[i];
            }
            
        }

    
    }
}
