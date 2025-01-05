namespace Lab14.Calculator
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
            txtResult = new TextBox();
            btn7 = new Button();
            btn5 = new Button();
            btn3 = new Button();
            btn6 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btnPlus = new Button();
            btnSub = new Button();
            btnMultiply = new Button();
            btnEqual = new Button();
            btnZero = new Button();
            btnDot = new Button();
            btnDivide = new Button();
            btnMod = new Button();
            btnClear = new Button();
            btnDel = new Button();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Dock = DockStyle.Top;
            txtResult.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(0, 0);
            txtResult.Margin = new Padding(3, 2, 3, 2);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(426, 50);
            txtResult.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn7.Location = new Point(27, 147);
            btn7.Margin = new Padding(3, 2, 3, 2);
            btn7.Name = "btn7";
            btn7.Size = new Size(82, 46);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Num_click;
            btn7.KeyPress += btn_KeyPress;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn5.Location = new Point(123, 212);
            btn5.Margin = new Padding(3, 2, 3, 2);
            btn5.Name = "btn5";
            btn5.Size = new Size(82, 46);
            btn5.TabIndex = 2;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Num_click;
            btn5.KeyPress += btn_KeyPress;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.Location = new Point(221, 277);
            btn3.Margin = new Padding(3, 2, 3, 2);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 46);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Num_click;
            btn3.KeyPress += btn_KeyPress;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn6.Location = new Point(221, 212);
            btn6.Margin = new Padding(3, 2, 3, 2);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 46);
            btn6.TabIndex = 4;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Num_click;
            btn6.KeyPress += btn_KeyPress;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.Location = new Point(123, 277);
            btn2.Margin = new Padding(3, 2, 3, 2);
            btn2.Name = "btn2";
            btn2.Size = new Size(82, 46);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Num_click;
            btn2.KeyPress += btn_KeyPress;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.Location = new Point(27, 277);
            btn1.Margin = new Padding(3, 2, 3, 2);
            btn1.Name = "btn1";
            btn1.Size = new Size(82, 46);
            btn1.TabIndex = 6;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Num_click;
            btn1.KeyPress += btn_KeyPress;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.Location = new Point(27, 212);
            btn4.Margin = new Padding(3, 2, 3, 2);
            btn4.Name = "btn4";
            btn4.Size = new Size(82, 46);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Num_click;
            btn4.KeyPress += btn_KeyPress;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn9.Location = new Point(221, 147);
            btn9.Margin = new Padding(3, 2, 3, 2);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 46);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Num_click;
            btn9.KeyPress += btn_KeyPress;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn8.Location = new Point(123, 147);
            btn8.Margin = new Padding(3, 2, 3, 2);
            btn8.Name = "btn8";
            btn8.Size = new Size(82, 46);
            btn8.TabIndex = 9;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Num_click;
            btn8.KeyPress += btn_KeyPress;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(319, 277);
            btnPlus.Margin = new Padding(3, 2, 3, 2);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(80, 46);
            btnPlus.TabIndex = 10;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += Operation_btn_clik;
            btnPlus.KeyPress += btn_KeyPress;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSub.Location = new Point(319, 212);
            btnSub.Margin = new Padding(3, 2, 3, 2);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(80, 46);
            btnSub.TabIndex = 11;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += Operation_btn_clik;
            btnSub.KeyPress += btn_KeyPress;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiply.Location = new Point(319, 147);
            btnMultiply.Margin = new Padding(3, 2, 3, 2);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(80, 46);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += Operation_btn_clik;
            btnMultiply.KeyPress += btn_KeyPress;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(221, 339);
            btnEqual.Margin = new Padding(3, 2, 3, 2);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(178, 46);
            btnEqual.TabIndex = 13;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            btnEqual.KeyPress += btn_KeyPress;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnZero.Location = new Point(27, 339);
            btnZero.Margin = new Padding(3, 2, 3, 2);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(82, 46);
            btnZero.TabIndex = 14;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += Num_click;
            btnZero.KeyPress += btn_KeyPress;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDot.Location = new Point(123, 339);
            btnDot.Margin = new Padding(3, 2, 3, 2);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(82, 46);
            btnDot.TabIndex = 15;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += Num_click;
            btnDot.KeyPress += btn_KeyPress;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(319, 87);
            btnDivide.Margin = new Padding(3, 2, 3, 2);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(80, 46);
            btnDivide.TabIndex = 16;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += Operation_btn_clik;
            btnDivide.KeyPress += btn_KeyPress;
            // 
            // btnMod
            // 
            btnMod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMod.Location = new Point(221, 87);
            btnMod.Margin = new Padding(3, 2, 3, 2);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(80, 46);
            btnMod.TabIndex = 17;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += Operation_btn_clik;
            btnMod.KeyPress += btn_KeyPress;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(27, 87);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 46);
            btnClear.TabIndex = 18;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            btnClear.KeyPress += btn_KeyPress;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDel.Location = new Point(123, 87);
            btnDel.Margin = new Padding(3, 2, 3, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(82, 46);
            btnDel.TabIndex = 19;
            btnDel.Text = "⌫";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            btnDel.KeyPress += btn_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 399);
            Controls.Add(btnDel);
            Controls.Add(btnClear);
            Controls.Add(btnMod);
            Controls.Add(btnDivide);
            Controls.Add(btnDot);
            Controls.Add(btnZero);
            Controls.Add(btnEqual);
            Controls.Add(btnMultiply);
            Controls.Add(btnSub);
            Controls.Add(btnPlus);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn6);
            Controls.Add(btn3);
            Controls.Add(btn5);
            Controls.Add(btn7);
            Controls.Add(txtResult);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button btn7;
        private Button btn5;
        private Button btn3;
        private Button btn6;
        private Button btn2;
        private Button btn1;
        private Button btn4;
        private Button btn9;
        private Button btn8;
        private Button btnPlus;
        private Button btnSub;
        private Button btnMultiply;
        private Button btnEqual;
        private Button btnZero;
        private Button btnDot;
        private Button btnDivide;
        private Button btnMod;
        private Button btnClear;
        private Button btnDel;
    }
}
