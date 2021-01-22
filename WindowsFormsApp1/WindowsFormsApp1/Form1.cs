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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton.Checked)
            {
                Form3 miventana = new Form3();
                miventana.Owner = this;
                miventana.ShowDialog();
            }
            if (radioButton2.Checked)
            {
                Form2 miventana = new Form2();
                miventana.Owner = this;
                miventana.ShowDialog();
            }
            if (radioButton3.Checked)
            {
                Form4 miventana = new Form4();
                miventana.Owner = this;
                miventana.ShowDialog();
            }
            if (radioButton4.Checked)
            {
                Form5 miventana = new Form5();
                miventana.Owner = this;
                miventana.ShowDialog();
            }
        }
    }
}
