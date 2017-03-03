using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03.Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        try
        {
            var num1 = decimal.Parse(this.num1.Text);
        var num2 = decimal.Parse(this.num2.Text);
        var sum = num1 + num2;
        result.Text = sum.ToString();
        }
        catch (Exception)
        { 
            result.Text = "Error";
        }
    

