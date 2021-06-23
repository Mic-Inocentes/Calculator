using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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

        private void SymbolKeypad0_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "0";
            CalcDisplay.Text += userInput;
        }

        private void SymbolKeypad1_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "1";
            CalcDisplay.Text += userInput;
        }

        private void SymbolKeypad2_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "2";
            CalcDisplay.Text += userInput;
        }

        private void SymbolKeypad3_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "3";
            CalcDisplay.Text += userInput;
        }

        private void SymbolKeypad4_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "4";
            CalcDisplay.Text += userInput;
        }

        private void SymbolKeypad5_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "5";
            CalcDisplay.Text += userInput;
        }

        private void SymbolKeypad6_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "6";
            CalcDisplay.Text += userInput;
        }

        private void SymbolKeypad7_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "7";
            CalcDisplay.Text += userInput;
        }

        private void SymbolKeypad8_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "8";
            CalcDisplay.Text += userInput;
        }

        private void SymbolKeypad9_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += "9";
            CalcDisplay.Text += userInput;
        }

        private void SymbolButton_Decimal_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = "";
            userInput += ".";
            CalcDisplay.Text += userInput;
        }

        private void SymbolButton_Plus_Click(object sender, EventArgs e)
        {
            function = '+';
            first = userInput;
            userInput = "";
        }

        private void SymbolButton_Minus_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void SymbolButton_Times_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void SymbolButton_Divide_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void Button_AllClear_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            CalcDisplay.Text = "0";
        }

        private void SymbolButton_Equal_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            if(function == '+')
            {
                result = firstNum + secondNum;
                CalcDisplay.Text = result.ToString();
            }

            else if(function == '-')
            {
                result = firstNum - secondNum;
                CalcDisplay.Text = result.ToString();
            }

            else if(function == '*')
            {
                result = firstNum * secondNum;
                CalcDisplay.Text = result.ToString();
            }

            else if(function == '/')
            {
                if (secondNum == 'O')
                {
                    CalcDisplay.Text = "Math ERROR";
                }
                else
                {
                    result = firstNum / secondNum;
                    CalcDisplay.Text = result.ToString();
                }
            }
        }
    }
}
