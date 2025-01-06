namespace Lab14.RegisterationForm
{
    partial class RegistrationForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtMobile = new TextBox();
            txtAge = new TextBox();
            label5 = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 63);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 110);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 157);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 2;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 204);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 3;
            label4.Text = "Mobile";
            // 
            // txtId
            // 
            txtId.Location = new Point(79, 60);
            txtId.MaxLength = 14;
            txtId.Name = "txtId";
            txtId.Size = new Size(274, 27);
            txtId.TabIndex = 1;
            txtId.KeyPress += txtId_KeyPress;
            // 
            // txtName
            // 
            txtName.Location = new Point(79, 107);
            txtName.Name = "txtName";
            txtName.Size = new Size(274, 27);
            txtName.TabIndex = 2;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(79, 201);
            txtMobile.MaxLength = 11;
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(274, 27);
            txtMobile.TabIndex = 4;
            txtMobile.KeyPress += txtId_KeyPress;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(79, 154);
            txtAge.MaxLength = 2;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(274, 27);
            txtAge.TabIndex = 3;
            txtAge.KeyPress += txtId_KeyPress;
            txtAge.KeyPress += AgeValidation;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(158, 10);
            label5.Name = "label5";
            label5.Size = new Size(92, 30);
            label5.TabIndex = 8;
            label5.Text = "Register";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(158, 258);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 338);
            Controls.Add(btnSave);
            Controls.Add(label5);
            Controls.Add(txtAge);
            Controls.Add(txtMobile);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Registration Form";
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtMobile;
        private TextBox txtAge;
        private Label label5;
        private Button btnSave;
    }
}
