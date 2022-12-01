using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ecdrII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox4.Text);
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                textBox5.Text += " Ecuatia nu are radacini reale";
            }
            else
            {
                if (d == 0)
                {
                    textBox5.Text += " x1 = x2 = " + (-b / (2 * a)).ToString() + "\r\n";
                }
                else
                {
                    textBox5.Text += " x1 =  " + (-b + Math.Sqrt(d) / (2 * a)).ToString() + "\r\n";
                     textBox5.Text += " x2 =  " + (-b - Math.Sqrt(d) / (2 * a)).ToString() + "\r\n";
                }
            }

        }
    }
}
