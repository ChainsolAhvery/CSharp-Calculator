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
        Boolean OperatorOn = false;
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

        }

        private void Dot_Click(object sender, EventArgs e)
        {

        }

        private void Equal_Click(object sender, EventArgs e)
        {

        }

        private void PlusOrMinus_Click(object sender, EventArgs e)
        {

        }

        private void Digit_Click(object sender, EventArgs e)
        {
            if (MainDisplay.Text == "0")
            {
                MainDisplay.Clear();
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
            Dummy = MainTrueValue.ToString();
            MainDisplay.Text = String.Format("{0:n0}", Decimal.Parse(Dummy));
        }
    }
}
