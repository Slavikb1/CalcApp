using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcApp
{
    public partial class Form1 : Form
    {
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "9";
        }

        private void decimelButton_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += ".";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            function = 'C';
        }

        private void devideButton_Click(object sender, EventArgs e)
        {
            function = '/';
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = '*';
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            function = '=';
        }
    }
}
