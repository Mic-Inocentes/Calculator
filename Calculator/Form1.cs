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
        System.Media.SoundPlayer PressSound;

        public Form1()
        {
            InitializeComponent();
            PressSound = new System.Media.SoundPlayer(Properties.Resources.sound);
        }

        private void DisplayNumber(String num)
        {
            CalcDisplay.Text = "";
            userInput += num;
            CalcDisplay.Text += userInput;
            PressSound.Play();
        }

        private void SymbolKeypad0_Click(object sender, EventArgs e)
        {
            DisplayNumber("0");
        }

        private void SymbolKeypad1_Click(object sender, EventArgs e)
        {
            DisplayNumber("1");
        }

        private void SymbolKeypad2_Click(object sender, EventArgs e)
        {
            DisplayNumber("2");
        }

        private void SymbolKeypad3_Click(object sender, EventArgs e)
        {
            DisplayNumber("3");
        }

        private void SymbolKeypad4_Click(object sender, EventArgs e)
        {
            DisplayNumber("4");
        }

        private void SymbolKeypad5_Click(object sender, EventArgs e)
        {
            DisplayNumber("5");
        }

        private void SymbolKeypad6_Click(object sender, EventArgs e)
        {
            DisplayNumber("6");
        }

        private void SymbolKeypad7_Click(object sender, EventArgs e)
        {
            DisplayNumber("7");
        }

        private void SymbolKeypad8_Click(object sender, EventArgs e)
        {
            DisplayNumber("8");
        }

        private void SymbolKeypad9_Click(object sender, EventArgs e)
        {
            DisplayNumber("9");
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

        private void Button_Delete_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text.Substring(0, CalcDisplay.Text.Length - 1);
        }

        private void SymbolButton_Reciprocal_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(CalcDisplay.Text);
            number = 1 / number;
            CalcDisplay.Text = number + "";
        }

        private void SymbolButton_Square_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(CalcDisplay.Text);
            number = Math.Pow(number, 2);
            CalcDisplay.Text = number + "";
        }

        private void SymbolButton_SquareRoot_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(CalcDisplay.Text) >= 0)
            {
                double number = Convert.ToDouble(CalcDisplay.Text);
                number = Math.Pow(number, .5);
                CalcDisplay.Text = number + "";
            }
            else
            {
                CalcDisplay.Text = "Error";
            }
        }

        private void SymbolButton_PlusMinus_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(CalcDisplay.Text);
            number = number * -1;
            CalcDisplay.Text = number + "";
        }

        private void SymbolButton_Percent_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            if (function == '+')
            {
                result = firstNum * secondNum / 100;
                CalcDisplay.Text = result.ToString();
            }

            else if (function == '-')
            {
                result = firstNum * secondNum / 100;
                CalcDisplay.Text = result.ToString();
            }

            else if (function == '*')
            {
                result = (firstNum / firstNum) * secondNum / 100;
                CalcDisplay.Text = result.ToString();
            }

            else if (function == '/')
            {
                if (secondNum == 'O')
                {
                    CalcDisplay.Text = "Error";
                }
                else
                {
                    result = (firstNum / firstNum) * secondNum / 100;
                    CalcDisplay.Text = result.ToString();
                }
            }
        }

        private void SymbolButton_Equal_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);

            if (function == '+')
            {
                result = firstNum + secondNum;
                CalcDisplay.Text = result.ToString();
            }

            else if (function == '-')
            {
                result = firstNum - secondNum;
                CalcDisplay.Text = result.ToString();
            }

            else if (function == '*')
            {
                result = firstNum * secondNum;
                CalcDisplay.Text = result.ToString();
            }

            else if (function == '/')
            {
                if (secondNum == 'O')
                {
                    CalcDisplay.Text = "Error";
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

