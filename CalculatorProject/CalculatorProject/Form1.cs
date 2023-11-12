using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject
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

        private void btn_AC_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            CalculatorDisplay.Text = "0";
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            //Addition
            if (function == '+')
            {
                result = firstNum + secondNum;
                CalculatorDisplay.Text = result.ToString();
            }
            //Subtraction
            else if (function == '-')
            {
                result = firstNum - secondNum;
                CalculatorDisplay.Text = result.ToString();
            }
            //Division
            else if (function == '/')
            {
                if (secondNum == '0') 
                {
                    CalculatorDisplay.Text = "Syntax Error";
                }
                else
                {
                    result = firstNum / secondNum;
                    CalculatorDisplay.Text = result.ToString();
                }
            }
            //Multiplication
            else if (function == '*')
            {
                result = firstNum * secondNum;
                CalculatorDisplay.Text = result.ToString();
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text = "";
            userInput += "1";
            CalculatorDisplay.Text += userInput;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "";
            userInput += "2";
            CalculatorDisplay.Text += userInput;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "";
            userInput += "3";
            CalculatorDisplay.Text += userInput;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "";
            userInput += "4";
            CalculatorDisplay.Text += userInput;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "";
            userInput += "5";
            CalculatorDisplay.Text += userInput;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "";
            userInput += "6";
            CalculatorDisplay.Text += userInput;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "";
            userInput += "7";
            CalculatorDisplay.Text += userInput;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "";
            userInput += "8";
            CalculatorDisplay.Text += userInput;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "";
            userInput += "9";
            CalculatorDisplay.Text += userInput;
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

       

        private void btn_Addition_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void btn_Subtraction_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "";
            userInput = "0";
            CalculatorDisplay.Text = userInput;
        }

        private void btn_Dot_Click(object sender, EventArgs e)
        {
            CalculatorDisplay.Text += "";
            userInput = ".";
            CalculatorDisplay.Text += userInput;
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
