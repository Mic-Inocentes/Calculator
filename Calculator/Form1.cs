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
        string UserInput = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void SymbolKeypad0_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "0";
        }

        private void SymbolKeypad1_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "1";
        }

        private void SymbolKeypad2_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "2";
        }

        private void SymbolKeypad3_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "3";
        }

        private void SymbolKeypad4_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "4";
        }

        private void SymbolKeypad5_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "5";
        }

        private void SymbolKeypad6_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "6";
        }

        private void SymbolKeypad7_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "7";
        }

        private void SymbolKeypad8_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "8";
        }

        private void SymbolKeypad9_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += "9";
        }

        private void SymbolButton_Decimal_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text += ".";
        }

        private void SymbolButton_Plus_Click(object sender, EventArgs e)
        {
            function = '+';
        }

        private void SymbolButton_Minus_Click(object sender, EventArgs e)
        {
            function = '-';
        }

        private void SymbolButton_Times_Click(object sender, EventArgs e)
        {
            function = '*';
        }

        private void SymbolButton_Divide_Click(object sender, EventArgs e)
        {
            function = '/';
        }

        private void Button_AllClear_Click(object sender, EventArgs e)
        {
            function = 'C';
        }

        private void SymbolButton_Equal_Click(object sender, EventArgs e)
        {
            function = '=';
        }
    }
}
