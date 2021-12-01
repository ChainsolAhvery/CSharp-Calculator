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
        string Dummy = "";
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

        private void Divide_Click(object sender, EventArgs e)
        {

        }

        private void Multiply_Click(object sender, EventArgs e)
        {

        }

        private void Subtract_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Entered Add_Click");
            if (OperatorOn)
            {
                Equal_Click(sender, e);
            }
            OperatorOn = true;
            SecondaryDigitStart = true;
            SecondaryDisplay.Text = MainDisplay.Text + " + ";
            Debug.WriteLine("MainTrueValue is " + MainTrueValue + ": MainDisplay is " + MainDisplay.Text);
            Debug.WriteLine("SecondaryDisplay is " + SecondaryDisplay.Text);
            Debug.WriteLine("Exited Add_Click");
        }

        private void Dot_Click(object sender, EventArgs e)
        {

        }

        private void Equal_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Entered Equal_Click");
            OperatorOn = false;
            MainTrueValue = (decimal)Convert.ToDouble(new DataTable().Compute((SecondaryDisplay.Text.Replace(",", "") + MainDisplay.Text.Replace(",", "")), null));
            MainDisplay.Text = String.Format("{0:n0}", Decimal.Parse(MainTrueValue.ToString()));
            SecondaryDisplay.Clear();
            Debug.WriteLine("MainTrueValue is " + MainTrueValue + ": MainDisplay is " + MainDisplay.Text);
            Debug.WriteLine("SecondaryDisplay is " + SecondaryDisplay.Text);
            Debug.WriteLine("Exited Equal_Click");
        }

        private void PlusOrMinus_Click(object sender, EventArgs e)
        {

        }

        private void Digit_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Entered Digit_Click");
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
            MainDisplay.Text = String.Format("{0:n0}", Decimal.Parse(MainTrueValue.ToString()));
            Debug.WriteLine("MainTrueValue is " + MainTrueValue + ": MainDisplay is " + MainDisplay.Text);
            Debug.WriteLine("SecondaryDisplay is " + SecondaryDisplay.Text);
            Debug.WriteLine("Exited Digit_Click");
        }
    }
}
