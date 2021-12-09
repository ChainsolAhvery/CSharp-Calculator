using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Calculator
{

    public partial class Form1 : Form
    {
        decimal MainTrueValue = 0;
        bool OperatorOn = false;
        bool SecondaryDigitStart = false;
        // TODO: This Regex needs adjusted to preserve trailing zeros
        // From: https://stackoverflow.com/questions/16035506/format-a-number-with-commas-and-decimals-in-c-sharp-asp-net-mvc3
        string FormatNumber<T>(T number, int maxDecimals = 16)
        {
            return Regex.Replace(String.Format("{0:n" + maxDecimals + "}", number),
                                 @"[" + System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator + "]?0+$", "");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void MemoryStore_Click(object sender, EventArgs e)
        {

        }

        private void MemoryStore_Click_1(object sender, EventArgs e)
        {

        }

        private void MemoryRecall_Click(object sender, EventArgs e)
        {

        }

        private void MemoryAdd_Click(object sender, EventArgs e)
        {

        }

        private void MemorySubtract_Click(object sender, EventArgs e)
        {

        }

        private void ClearEverything_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text.Length < 2 || (MainDisplay.Text.Length == 2 && MainDisplay.Text[0] == '-'))
            {
                MainDisplay.Text = "0";
            } else
            {
                MainDisplay.Text = MainDisplay.Text.Remove(MainDisplay.Text.Length - 1);
                MainDisplay.Text = FormatNumber(Convert.ToDecimal(MainDisplay.Text));
            }
        }

        private void MemoryClear_Click(object sender, EventArgs e)
        {

        }

        private void SquareRoot_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text[0] == '-')
            {
                MainDisplay.Text = "Invalid input";
                MainTrueValue = 0;
                SecondaryDisplay.Clear();
            } else
            {
                MainTrueValue = Convert.ToDecimal(MainDisplay.Text.Replace(",", ""));
                // This is the Babylonian method which has a degree of error
                // If it's a whole number, a cast is fine and dealt with in 'else'
                if (MainTrueValue % 1 > 0)
                {
                    decimal Error = Decimal.Multiply(MainTrueValue, (decimal)10e-8);
                    decimal Result = MainTrueValue;
                    while ((Result - MainTrueValue / Result) > Error)
                    {
                        Result = (Result + MainTrueValue / Result) / 2;
                    }
                    MainTrueValue = Result;
                }
                {
                    MainTrueValue = Convert.ToDecimal(MainDisplay.Text.Replace(",", ""));
                    MainTrueValue = Convert.ToDecimal(Math.Sqrt((double)MainTrueValue));
                }
                MainDisplay.Text = FormatNumber(MainTrueValue);
            }
        }

        private void Squared_Click(object sender, EventArgs e)
        {
            MainTrueValue = Convert.ToDecimal(MainDisplay.Text.Replace(",", ""));
            MainTrueValue = Decimal.Multiply(MainTrueValue, MainTrueValue);
            MainDisplay.Text = FormatNumber(MainTrueValue);
        }

        private void Reciprocal_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text == "0")
            {
                MainDisplay.Text = "Invalid input";
                MainTrueValue = 0;
                SecondaryDisplay.Clear();
            }
            else
            {
                MainDisplay.Text = "1 / " + MainDisplay.Text;
                MainTrueValue = Convert.ToDecimal(new DataTable().Compute(MainDisplay.Text.Replace(",", ""), null));
                MainDisplay.Text = FormatNumber(MainTrueValue);
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (!MainDisplay.Text.Contains("."))
            {
                MainDisplay.Text += ".";
            }
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            OperatorOn = false;
            if (SecondaryDisplay.Text[SecondaryDisplay.TextLength - 1] == '/')
            {
                MainDisplay.Text = "Invalid input";
                MainTrueValue = 0;
                SecondaryDisplay.Clear();
            }
            else
            {
                if (MainDisplay.Text.EndsWith("."))
                {
                    MainDisplay.Text += "0";
                }
                MainTrueValue = Convert.ToDecimal(new DataTable().Compute(SecondaryDisplay.Text.Replace(",", "") + MainDisplay.Text.Replace(",", ""), null));
                MainDisplay.Text = FormatNumber(MainTrueValue);
                SecondaryDisplay.Clear();
            }
        }

        private void PlusOrMinus_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text.StartsWith("-"))
            {
                MainDisplay.Text = MainDisplay.Text.TrimStart('-');
            }
            else if (MainDisplay.Text != "0")
            {
                MainDisplay.Text = MainDisplay.Text.Insert(0, "-");
            }
            MainDisplay.Text = FormatNumber(Convert.ToDecimal(MainDisplay.Text));
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            if (SecondaryDigitStart || MainDisplay.Text == "0" || MainDisplay.Text == "Invalid input")
            {
                MainDisplay.Clear();
                SecondaryDigitStart = false;
            }
            Button button = (Button)sender;
            MainDisplay.Text += button.Text;
            MainDisplay.Text = FormatNumber(Convert.ToDecimal(MainDisplay.Text));
        }

        private void BasicOp_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (OperatorOn)
            {
                Equal_Click(sender, e);
            }
            OperatorOn = true;
            SecondaryDigitStart = true;
            SecondaryDisplay.Text = MainDisplay.Text + " " + button.Text;
        }
    }
}
