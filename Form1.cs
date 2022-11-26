using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hci_lab1._3
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public TextBox tb1;

        public Form1()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yes, no, cancel", "Yes, no, cancel", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                textBox1.Text = "OK";
            }

            else if (result == DialogResult.Cancel)
            {
                textBox1.Text = "Cancel";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.txt, *.doc, *.rtf, *.*)| *.txt, *.doc, *.rtf | All files(*.*) | *.*";
            saveFileDialog.ShowDialog();
            var fileName = System.IO.Path.GetFileName(saveFileDialog.FileName);
            textBox1.Text = fileName;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void abort_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Abort, retry, ignore", "Abort, retry, ignore", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (res == DialogResult.OK)
            {
                textBox1.Text = "OK";
            }

            else if (res == DialogResult.Cancel)
            {
                textBox1.Text = "Cancel";
            }
        }

        private void exit__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void customDialog_Click(object sender, EventArgs e)
        {
            var Form1 = new Form2();
            Form1.Show();
        }

        private void whichOption_Click(object sender, EventArgs e)
        {
            /* do
             {
                 try
                 {
                     Form2.instance.op1.Checked = default;
                 }

                 catch (NullReferenceException)
                 {
                     throw new NullReferenceException();
                     string lol = "Please select an option";
                     MessageBox.Show(lol);
                 }
             }
             while (!Form2.instance.op1.Checked);*/

            if (Form2.instance.op1.Checked)
            {
                textBox1.Text = "1";
            }

            else if (Form2.instance.op2.Checked)
            {
                textBox1.Text = "2";
            }

            else if (Form2.instance.op3.Checked)
            {
                textBox1.Text = "3";
            }

            else if (Form2.instance.op4.Checked)
            {
                textBox1.Text = "4";
            }
        }
    }
}
