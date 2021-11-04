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
            CalculatorDisplay.Text = "";
            userInput += "0";
            CalculatorDisplay.Text += userInput;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "1";
            CalculatorDisplay.Text += userInput;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "2";
            CalculatorDisplay.Text += userInput;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "3";
            CalculatorDisplay.Text += userInput;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "4";
            CalculatorDisplay.Text += userInput;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "5";
            CalculatorDisplay.Text += userInput;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "6";
            CalculatorDisplay.Text += userInput;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "7";
            CalculatorDisplay.Text += userInput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "8";
            CalculatorDisplay.Text += userInput;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "9";
            CalculatorDisplay.Text += userInput;
        }

        private void decimelButton_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += ".";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            CalculatorDisplay.Text = "0";
        }

        private void devideButton_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            //plus
            if (function == '+') {
                result = firstNum + secondNum;
                CalculatorDisplay.Text = result.ToString();
            }
            //minus
            else if (function == '-') {
                result = firstNum - secondNum;
                CalculatorDisplay.Text = result.ToString();
            }
            //devide
            else if (function == '/') {
                if (secondNum == '0')
                {
                    CalculatorDisplay.Text = "ERR";
                }
                else {
                    result = firstNum / secondNum;
                    CalculatorDisplay.Text = result.ToString();
                }
                
            }
            //multiply
            else if (function == '*')
            {
                result = firstNum * secondNum;
                CalculatorDisplay.Text = result.ToString();
            }
        }
    }
}
