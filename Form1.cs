using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lommeregnerforms
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }
        public void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = plus.Plus(a, b);
            //MessageBox.Show($"{c}");
        }

        public void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = minus.Minus(a, b);
            //MessageBox.Show($"{c}");
        }

        public void button3_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = gange.Gange(a, b);
            //MessageBox.Show($"{c}");
        }

        public void button4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = division.Division(a, b);
        }

        public void button5_Click(object sender, EventArgs e)
        {

            
            MessageBox.Show($"{c}");
        }
    }
}
