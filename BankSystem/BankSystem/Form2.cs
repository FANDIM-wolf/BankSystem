using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BankSystem
{

    
    public partial class Form2 : Form
    {
        bool programm = true;



        Thread th;
        public Form2()
        {
            InitializeComponent();
            data_on();
        }

        //calculation
        public static double finish_pension(double ages_of_the_work, double level_of_clasification)
        {
            double sum_fp = ages_of_the_work * level_of_clasification;

            double sum_fp_result =  sum_fp * 22 / 100;

            return sum_fp_result;
        }

        //functions for threads 

        private void openss(object obj)
        {
            Application.Run(new Form3());
        }

        public void data_on()
        {
            bool programm = true;
            if (programm == true)
            {
                label1.Text = "Mikis";
                label2.Text = "Elkin";
                label3.Text = "#7865413elkin23";

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (programm == true)
            {
                label1.Text = "Mikis";
                
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(finish_pension(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
