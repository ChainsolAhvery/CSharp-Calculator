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
        decimal MainValue = 0;
        bool OperatorOn = false;
        bool SecondaryDigitStart = false;
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
                MainDisplay.Text = Helpers.FormatNumber(Convert.ToDecimal(MainDisplay.Text));
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
                MainValue = 0;
                SecondaryDisplay.Clear();
            } else
            {
                MainValue = Convert.ToDecimal(MainDisplay.Text.Replace(",", ""));
                // If it's a whole number, a cast is fine and dealt with in 'else'
                if (MainValue % 1 > 0)
                {
                    MainValue = Helpers.SquareRoot(MainValue);
                }
                {
                    MainValue = Convert.ToDecimal(MainDisplay.Text.Replace(",", ""));
                    MainValue = Convert.ToDecimal(Math.Sqrt((double)MainValue));
                }
                MainDisplay.Text = Helpers.FormatNumber(MainValue);
            }
        }

        private void Squared_Click(object sender, EventArgs e)
        {
            MainValue = Convert.ToDecimal(MainDisplay.Text.Replace(",", ""));
            MainValue = Decimal.Multiply(MainValue, MainValue);
            MainDisplay.Text = Helpers.FormatNumber(MainValue);
        }

        private void Reciprocal_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text == "0")
            {
                MainDisplay.Text = "Invalid input";
                MainValue = 0;
                SecondaryDisplay.Clear();
            }
            else
            {
                MainDisplay.Text = "1 / " + MainDisplay.Text;
                MainValue = Convert.ToDecimal(new DataTable().Compute(MainDisplay.Text.Replace(",", ""), null));
                MainDisplay.Text = Helpers.FormatNumber(MainValue);
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
                MainValue = 0;
                SecondaryDisplay.Clear();
            }
            else
            {
                if (MainDisplay.Text.EndsWith("."))
                {
                    MainDisplay.Text += "0";
                }
                MainValue = Convert.ToDecimal(new DataTable().Compute(SecondaryDisplay.Text.Replace(",", "") + MainDisplay.Text.Replace(",", ""), null));
                MainDisplay.Text = Helpers.FormatNumber(MainValue);
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
            MainDisplay.Text = Helpers.FormatNumber(Convert.ToDecimal(MainDisplay.Text));
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            if (SecondaryDigitStart || MainDisplay.Text == "0" || MainDisplay.Text == "Invalid input")
            {
                MainDisplay.Clear();
                SecondaryDigitStart = false;
            }
            if (MainDisplay.Text.Substring(MainDisplay.Text.IndexOf(".") + 1).Length < 16)
            {
                Button button = (Button)sender;
                MainDisplay.Text += button.Text;
                MainDisplay.Text = Helpers.FormatNumber(Convert.ToDecimal(MainDisplay.Text));
            }
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
