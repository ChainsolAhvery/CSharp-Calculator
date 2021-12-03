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

        }

        private void MemoryClear_Click(object sender, EventArgs e)
        {

        }

        private void SquareRoot_Click(object sender, EventArgs e)
        {

        }

        private void Squared_Click(object sender, EventArgs e)
        {

        }

        private void Reciprocal_Click(object sender, EventArgs e)
        {

        }

        private void Dot_Click(object sender, EventArgs e)
        {

        }

        private void Equal_Click(object sender, EventArgs e)
        {
            OperatorOn = false;
            MainTrueValue = Convert.ToDecimal(new DataTable().Compute(SecondaryDisplay.Text.Replace(",", "") + MainDisplay.Text.Replace(",", ""), null));
            Debug.WriteLine("MainTrueValue is " + MainTrueValue);
            Debug.WriteLine("MainDisplay.Text is " + MainDisplay.Text);
            MainDisplay.Text = FormatNumber(MainTrueValue);
            Debug.WriteLine("MainTrueValue is " + MainTrueValue);
            Debug.WriteLine("MainDisplay.Text is " + MainDisplay.Text);
            SecondaryDisplay.Clear();
        }

        private void PlusOrMinus_Click(object sender, EventArgs e)
        {
            MainTrueValue *= -1;
            MainDisplay.Text = FormatNumber(MainTrueValue);
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text == "0" || SecondaryDigitStart)
            {
                MainDisplay.Clear();
                SecondaryDigitStart = false;
            }
            Button button = (Button)sender;
            if (button.Text == "0")
            {
                MainTrueValue *= 10;
            } else if (MainDisplay.Text.Length > 0 && MainTrueValue > 0)
            {
                MainTrueValue *= 10;
                MainTrueValue += Decimal.Parse(button.Text);
            } else
            {
                MainTrueValue = Decimal.Parse(button.Text);
            }
            MainDisplay.Text = FormatNumber(MainTrueValue);
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
