using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            richTextBox1.Visible = false;
            textBox1.Text = "-1,5";
            textBox2.Text = "-2,5";
            textBox3.Text = "-0,5";
            textBox4.Text = "-0,8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox1.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = true;
            double x0 = double.Parse(textBox1.Text);
            double xk = double.Parse(textBox2.Text);
            double dx = double.Parse(textBox3.Text);
            double b = double.Parse(textBox4.Text);
            double x = x0;
            while (x>=((xk+dx)/2))
            {
                double y = Math.Pow(x, 2) + Math.Tan(5 * x + (b / x));
                richTextBox1.Text += "x" + Convert.ToString(x) + ";\ny="  + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = false;
        }
    }
}