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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            if (radioButton1.Checked)
                listBox.Items.Add(radioButton1.Text);
            if (radioButton2.Checked)
                listBox.Items.Add(radioButton2.Text);
            if (radioButton3.Checked)
                listBox.Items.Add(radioButton3.Text);
            if (checkBox1.Checked)
                listBox.Items.Add(checkBox1.Text);
            if (checkBox2.Checked)
                listBox.Items.Add(checkBox2.Text);
            if (checkBox3.Checked)
                listBox.Items.Add(checkBox3.Text);
            listBox.Items.Add(trackBar1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
