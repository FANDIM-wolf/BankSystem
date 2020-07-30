using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static double Sum(double a, double b , double c)
        {
            
            return  a*b*c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = Convert.ToString(Sum(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text) , Convert.ToDouble(textBox3.Text)));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
