using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {

        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text += " / ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox2.Text += " * ";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox2.Text += " + ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox2.Text += " - ";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string operacio = textBox2.Text;

            string[] op = operacio.Split(' ');

            float operat = 0;
            string funcio = null;

            for(int i = 0; i < op.Length; i++)
            {
                textBox3.Text += op[i];
                if (i % 2 == 0)
                {
                    if (i == 0)
                        operat = Int32.Parse(op[i]);
                    else
                    { 
                        if (funcio.Equals("/"))
                            operat = operat / Int32.Parse(op[i]);
                        if (funcio.Equals("*"))
                            operat = operat * Int32.Parse(op[i]);
                        if (funcio.Equals("+"))
                            operat = operat + Int32.Parse(op[i]);
                        if (funcio.Equals("-"))
                            operat = operat - Int32.Parse(op[i]);
                    }
                }
                else
                    funcio = op[i];
            }

           textBox3.Text = operat.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
