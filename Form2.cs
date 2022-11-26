using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace hci_lab1._3
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public TextBox tb2;
        public RadioButton op1;
        public RadioButton op2;
        public RadioButton op3;
        public RadioButton op4;

        public Form2()
        {
            InitializeComponent();
            instance = this;
            tb2 = textBox2;
            op1 = opt1;
            op2 = opt2;
            op3 = opt3;
            op4 = opt4;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ok_Click(object sender, EventArgs e)
        {
            Form1.instance.tb1.Text = textBox2.Text;
            this.Close();
        }

        private void cancel__Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
