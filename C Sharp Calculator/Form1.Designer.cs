
namespace C_Sharp_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MemoryStore = new System.Windows.Forms.Button();
            this.MemoryRecall = new System.Windows.Forms.Button();
            this.MemoryAdd = new System.Windows.Forms.Button();
            this.MemorySubtract = new System.Windows.Forms.Button();
            this.MemoryClear = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ClearEverything = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Reciprocal = new System.Windows.Forms.Button();
            this.Squared = new System.Windows.Forms.Button();
            this.SquareRoot = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.PlusOrMinus = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.SecondaryDisplay = new System.Windows.Forms.TextBox();
            this.MainDisplay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MemoryStore
            // 
            this.MemoryStore.Location = new System.Drawing.Point(13, 71);
            this.MemoryStore.Name = "MemoryStore";
            this.MemoryStore.Size = new System.Drawing.Size(56, 39);
            this.MemoryStore.TabIndex = 0;
            this.MemoryStore.Text = "MS";
            this.MemoryStore.UseVisualStyleBackColor = true;
            this.MemoryStore.Click += new System.EventHandler(this.MemoryStore_Click_1);
            // 
            // MemoryRecall
            // 
            this.MemoryRecall.Location = new System.Drawing.Point(75, 71);
            this.MemoryRecall.Name = "MemoryRecall";
            this.MemoryRecall.Size = new System.Drawing.Size(56, 39);
            this.MemoryRecall.TabIndex = 1;
            this.MemoryRecall.Text = "MR";
            this.MemoryRecall.UseVisualStyleBackColor = true;
            this.MemoryRecall.Click += new System.EventHandler(this.MemoryRecall_Click);
            // 
            // MemoryAdd
            // 
            this.MemoryAdd.Location = new System.Drawing.Point(137, 71);
            this.MemoryAdd.Name = "MemoryAdd";
            this.MemoryAdd.Size = new System.Drawing.Size(56, 39);
            this.MemoryAdd.TabIndex = 2;
            this.MemoryAdd.Text = "M+";
            this.MemoryAdd.UseVisualStyleBackColor = true;
            this.MemoryAdd.Click += new System.EventHandler(this.MemoryAdd_Click);
            // 
            // MemorySubtract
            // 
            this.MemorySubtract.Location = new System.Drawing.Point(199, 71);
            this.MemorySubtract.Name = "MemorySubtract";
            this.MemorySubtract.Size = new System.Drawing.Size(56, 39);
            this.MemorySubtract.TabIndex = 3;
            this.MemorySubtract.Text = "M-";
            this.MemorySubtract.UseVisualStyleBackColor = true;
            this.MemorySubtract.Click += new System.EventHandler(this.MemorySubtract_Click);
            // 
            // MemoryClear
            // 
            this.MemoryClear.Location = new System.Drawing.Point(199, 116);
            this.MemoryClear.Name = "MemoryClear";
            this.MemoryClear.Size = new System.Drawing.Size(56, 39);
            this.MemoryClear.TabIndex = 7;
            this.MemoryClear.Text = "MC";
            this.MemoryClear.UseVisualStyleBackColor = true;
            this.MemoryClear.Click += new System.EventHandler(this.MemoryClear_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(137, 116);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(56, 39);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Del";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(75, 116);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(56, 39);
            this.Clear.TabIndex = 5;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ClearEverything
            // 
            this.ClearEverything.Location = new System.Drawing.Point(13, 116);
            this.ClearEverything.Name = "ClearEverything";
            this.ClearEverything.Size = new System.Drawing.Size(56, 39);
            this.ClearEverything.TabIndex = 4;
            this.ClearEverything.Text = "CE";
            this.ClearEverything.UseVisualStyleBackColor = true;
            this.ClearEverything.Click += new System.EventHandler(this.ClearEverything_Click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(199, 161);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(56, 39);
            this.Divide.TabIndex = 11;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Reciprocal
            // 
            this.Reciprocal.Location = new System.Drawing.Point(137, 161);
            this.Reciprocal.Name = "Reciprocal";
            this.Reciprocal.Size = new System.Drawing.Size(56, 39);
            this.Reciprocal.TabIndex = 10;
            this.Reciprocal.Text = "1/x";
            this.Reciprocal.UseVisualStyleBackColor = true;
            this.Reciprocal.Click += new System.EventHandler(this.Reciprocal_Click);
            // 
            // Squared
            // 
            this.Squared.Location = new System.Drawing.Point(75, 161);
            this.Squared.Name = "Squared";
            this.Squared.Size = new System.Drawing.Size(56, 39);
            this.Squared.TabIndex = 9;
            this.Squared.Text = "x²";
            this.Squared.UseVisualStyleBackColor = true;
            this.Squared.Click += new System.EventHandler(this.Squared_Click);
            // 
            // SquareRoot
            // 
            this.SquareRoot.Location = new System.Drawing.Point(13, 161);
            this.SquareRoot.Name = "SquareRoot";
            this.SquareRoot.Size = new System.Drawing.Size(56, 39);
            this.SquareRoot.TabIndex = 8;
            this.SquareRoot.Text = "√x";
            this.SquareRoot.UseVisualStyleBackColor = true;
            this.SquareRoot.Click += new System.EventHandler(this.SquareRoot_Click);
            // 
            // Multiply
            // 
            this.Multiply.Location = new System.Drawing.Point(199, 206);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(56, 39);
            this.Multiply.TabIndex = 15;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(137, 206);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(56, 39);
            this.Nine.TabIndex = 14;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(75, 206);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(56, 39);
            this.Eight.TabIndex = 13;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(13, 206);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(56, 39);
            this.Seven.TabIndex = 12;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Digit_Click);
            // 
            // PlusOrMinus
            // 
            this.PlusOrMinus.Location = new System.Drawing.Point(199, 340);
            this.PlusOrMinus.Name = "PlusOrMinus";
            this.PlusOrMinus.Size = new System.Drawing.Size(56, 39);
            this.PlusOrMinus.TabIndex = 27;
            this.PlusOrMinus.Text = "+/-";
            this.PlusOrMinus.UseVisualStyleBackColor = true;
            this.PlusOrMinus.Click += new System.EventHandler(this.PlusOrMinus_Click);
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(137, 340);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(56, 39);
            this.Equal.TabIndex = 26;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Dot
            // 
            this.Dot.Location = new System.Drawing.Point(75, 340);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(56, 39);
            this.Dot.TabIndex = 25;
            this.Dot.Text = ".";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.Dot_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(13, 340);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(56, 39);
            this.Zero.TabIndex = 24;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(199, 295);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(56, 39);
            this.Add.TabIndex = 23;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(137, 295);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(56, 39);
            this.Three.TabIndex = 22;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(75, 295);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(56, 39);
            this.Two.TabIndex = 21;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Digit_Click);
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(13, 295);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(56, 39);
            this.One.TabIndex = 20;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Subtract
            // 
            this.Subtract.Location = new System.Drawing.Point(199, 251);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(56, 39);
            this.Subtract.TabIndex = 19;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(137, 251);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(56, 39);
            this.Six.TabIndex = 18;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(75, 251);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(56, 39);
            this.Five.TabIndex = 17;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Digit_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(13, 251);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(56, 39);
            this.Four.TabIndex = 16;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Digit_Click);
            // 
            // SecondaryDisplay
            // 
            this.SecondaryDisplay.Location = new System.Drawing.Point(13, 13);
            this.SecondaryDisplay.Name = "SecondaryDisplay";
            this.SecondaryDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SecondaryDisplay.Size = new System.Drawing.Size(241, 23);
            this.SecondaryDisplay.TabIndex = 32;
            this.SecondaryDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainDisplay
            // 
            this.MainDisplay.Location = new System.Drawing.Point(13, 42);
            this.MainDisplay.Name = "MainDisplay";
            this.MainDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainDisplay.Size = new System.Drawing.Size(241, 23);
            this.MainDisplay.TabIndex = 33;
            this.MainDisplay.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 390);
            this.Controls.Add(this.MainDisplay);
            this.Controls.Add(this.SecondaryDisplay);
            this.Controls.Add(this.PlusOrMinus);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Reciprocal);
            this.Controls.Add(this.Squared);
            this.Controls.Add(this.SquareRoot);
            this.Controls.Add(this.MemoryClear);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ClearEverything);
            this.Controls.Add(this.MemorySubtract);
            this.Controls.Add(this.MemoryAdd);
            this.Controls.Add(this.MemoryRecall);
            this.Controls.Add(this.MemoryStore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MemoryStore;
        private System.Windows.Forms.Button MemoryRecall;
        private System.Windows.Forms.Button MemoryAdd;
        private System.Windows.Forms.Button MemorySubtract;
        private System.Windows.Forms.Button MemoryClear;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button ClearEverything;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Reciprocal;
        private System.Windows.Forms.Button Squared;
        private System.Windows.Forms.Button SquareRoot;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button PlusOrMinus;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.TextBox SecondaryDisplay;
        private System.Windows.Forms.TextBox MainDisplay;
    }
}

