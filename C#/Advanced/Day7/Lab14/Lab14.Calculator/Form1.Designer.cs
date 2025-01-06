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
            lblOp = new Label();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Dock = DockStyle.Top;
            txtResult.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtResult.Location = new Point(0, 0);
            txtResult.Margin = new Padding(3, 2, 3, 2);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(423, 50);
            txtResult.TabIndex = 0;
            txtResult.KeyPress += txtResult_KeyPress;
            // 
            // btn7
            // 
            btn7.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn7.Location = new Point(27, 137);
            btn7.Margin = new Padding(3, 2, 3, 2);
            btn7.Name = "btn7";
            btn7.Size = new Size(82, 46);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Btn_Click;
            btn7.KeyPress += btn_KeyPress;
            // 
            // btn5
            // 
            btn5.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn5.Location = new Point(125, 202);
            btn5.Margin = new Padding(3, 2, 3, 2);
            btn5.Name = "btn5";
            btn5.Size = new Size(82, 46);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Btn_Click;
            btn5.KeyPress += btn_KeyPress;
            // 
            // btn3
            // 
            btn3.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn3.Location = new Point(223, 267);
            btn3.Margin = new Padding(3, 2, 3, 2);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 46);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Btn_Click;
            btn3.KeyPress += btn_KeyPress;
            // 
            // btn6
            // 
            btn6.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn6.Location = new Point(223, 202);
            btn6.Margin = new Padding(3, 2, 3, 2);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 46);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Btn_Click;
            btn6.KeyPress += btn_KeyPress;
            // 
            // btn2
            // 
            btn2.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn2.Location = new Point(125, 267);
            btn2.Margin = new Padding(3, 2, 3, 2);
            btn2.Name = "btn2";
            btn2.Size = new Size(82, 46);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Btn_Click;
            btn2.KeyPress += btn_KeyPress;
            // 
            // btn1
            // 
            btn1.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn1.Location = new Point(27, 267);
            btn1.Margin = new Padding(3, 2, 3, 2);
            btn1.Name = "btn1";
            btn1.Size = new Size(82, 46);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Btn_Click;
            btn1.KeyPress += btn_KeyPress;
            // 
            // btn4
            // 
            btn4.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn4.Location = new Point(27, 202);
            btn4.Margin = new Padding(3, 2, 3, 2);
            btn4.Name = "btn4";
            btn4.Size = new Size(82, 46);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Btn_Click;
            btn4.KeyPress += btn_KeyPress;
            // 
            // btn9
            // 
            btn9.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn9.Location = new Point(223, 137);
            btn9.Margin = new Padding(3, 2, 3, 2);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 46);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Btn_Click;
            btn9.KeyPress += btn_KeyPress;
            // 
            // btn8
            // 
            btn8.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btn8.Location = new Point(125, 137);
            btn8.Margin = new Padding(3, 2, 3, 2);
            btn8.Name = "btn8";
            btn8.Size = new Size(82, 46);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Btn_Click;
            btn8.KeyPress += btn_KeyPress;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(319, 267);
            btnPlus.Margin = new Padding(3, 2, 3, 2);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(80, 46);
            btnPlus.TabIndex = 16;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += Btn_Click;
            btnPlus.KeyPress += btn_KeyPress;
            // 
            // btnSub
            // 
            btnSub.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSub.Location = new Point(319, 202);
            btnSub.Margin = new Padding(3, 2, 3, 2);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(80, 46);
            btnSub.TabIndex = 12;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += Btn_Click;
            btnSub.KeyPress += btn_KeyPress;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnMultiply.Location = new Point(319, 137);
            btnMultiply.Margin = new Padding(3, 2, 3, 2);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(80, 46);
            btnMultiply.TabIndex = 8;
            btnMultiply.Text = "X";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += Btn_Click;
            btnMultiply.KeyPress += btn_KeyPress;
            // 
            // btnEqual
            // 
            btnEqual.Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEqual.Location = new Point(221, 329);
            btnEqual.Margin = new Padding(3, 2, 3, 2);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(178, 46);
            btnEqual.TabIndex = 19;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += BtnEqual_Click;
            btnEqual.KeyPress += btn_KeyPress;
            // 
            // btnZero
            // 
            btnZero.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnZero.Location = new Point(27, 329);
            btnZero.Margin = new Padding(3, 2, 3, 2);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(82, 46);
            btnZero.TabIndex = 17;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = true;
            btnZero.Click += Btn_Click;
            btnZero.KeyPress += btn_KeyPress;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnDot.Location = new Point(124, 329);
            btnDot.Margin = new Padding(3, 2, 3, 2);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(82, 46);
            btnDot.TabIndex = 18;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += Btn_Click;
            btnDot.KeyPress += btn_KeyPress;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Tahoma", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDivide.Location = new Point(319, 77);
            btnDivide.Margin = new Padding(3, 2, 3, 2);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(80, 46);
            btnDivide.TabIndex = 4;
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += Btn_Click;
            btnDivide.KeyPress += btn_KeyPress;
            // 
            // btnMod
            // 
            btnMod.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnMod.Location = new Point(223, 77);
            btnMod.Margin = new Padding(3, 2, 3, 2);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(80, 46);
            btnMod.TabIndex = 3;
            btnMod.Text = "%";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += Btn_Click;
            btnMod.KeyPress += btn_KeyPress;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnClear.Location = new Point(27, 77);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(82, 46);
            btnClear.TabIndex = 1;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            btnClear.KeyPress += btn_KeyPress;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            btnDel.Location = new Point(125, 77);
            btnDel.Margin = new Padding(3, 2, 3, 2);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(82, 46);
            btnDel.TabIndex = 2;
            btnDel.Text = "⌫";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            btnDel.KeyPress += btn_KeyPress;
            // 
            // lblOp
            // 
            lblOp.AutoSize = true;
            lblOp.Location = new Point(399, 9);
            lblOp.Name = "lblOp";
            lblOp.Size = new Size(0, 15);
            lblOp.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 400);
            Controls.Add(lblOp);
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
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Form1";
            Opacity = 0.99D;
            Text = "Hesham Calculator";
            Shown += Form1_Shown;
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
        private Label lblOp;
    }
}
