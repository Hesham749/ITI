namespace TestClient
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
            dataGridView1 = new DataGridView();
            txtID = new TextBox();
            txtDesc = new TextBox();
            txtName = new TextBox();
            txtDuration = new TextBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(679, 225);
            dataGridView1.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Location = new Point(30, 38);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 1;
            txtID.TextChanged += textBox1_TextChanged;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(385, 38);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(150, 31);
            txtDesc.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(202, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 31);
            txtName.TabIndex = 2;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(597, 38);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(150, 31);
            txtDuration.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(320, 110);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 34);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(txtDuration);
            Controls.Add(txtName);
            Controls.Add(txtDesc);
            Controls.Add(txtID);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtID;
        private TextBox txtDesc;
        private TextBox txtName;
        private TextBox txtDuration;
        private Button btnAdd;
    }
}
