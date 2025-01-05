namespace Lab14.Paint
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
            btnChooseColor = new Button();
            colorDialog1 = new ColorDialog();
            SuspendLayout();
            // 
            // btnChooseColor
            // 
            btnChooseColor.Location = new Point(1, 1);
            btnChooseColor.Name = "btnChooseColor";
            btnChooseColor.Size = new Size(149, 29);
            btnChooseColor.TabIndex = 0;
            btnChooseColor.Text = "Choose Color";
            btnChooseColor.UseVisualStyleBackColor = true;
            btnChooseColor.Click += btnChooseColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1217, 605);
            Controls.Add(btnChooseColor);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MouseDown += Form1_MouseDown;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
        }

        #endregion

        private Button btnChooseColor;
        private ColorDialog colorDialog1;
    }
}
