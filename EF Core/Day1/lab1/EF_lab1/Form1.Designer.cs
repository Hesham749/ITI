namespace EF_lab1
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
            Dept = new ComboBox();
            label1 = new Label();
            Deptname = new Label();
            Dept_Id = new TextBox();
            Dept_Name = new TextBox();
            Add = new Button();
            Change = new Button();
            Delete = new Button();
            Emp_Name = new TextBox();
            Emp_Id = new TextBox();
            EmpName = new Label();
            label3 = new Label();
            Emp = new ComboBox();
            Delete2 = new Button();
            Change2 = new Button();
            Add2 = new Button();
            Pre = new Button();
            Next = new Button();
            label2 = new Label();
            label4 = new Label();
            txtEmpDeptID = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // Dept
            // 
            Dept.FormattingEnabled = true;
            Dept.Location = new Point(41, 177);
            Dept.Margin = new Padding(4, 5, 4, 5);
            Dept.Name = "Dept";
            Dept.Size = new Size(303, 33);
            Dept.TabIndex = 0;
            Dept.SelectedIndexChanged += Dept_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 253);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 25);
            label1.TabIndex = 1;
            label1.Text = "Dept_Id";
            // 
            // Deptname
            // 
            Deptname.AutoSize = true;
            Deptname.Location = new Point(17, 317);
            Deptname.Margin = new Padding(4, 0, 4, 0);
            Deptname.Name = "Deptname";
            Deptname.Size = new Size(105, 25);
            Deptname.TabIndex = 2;
            Deptname.Text = "Dept_Name";
            Deptname.Click += Dept_Name_Click;
            // 
            // Dept_Id
            // 
            Dept_Id.Location = new Point(124, 240);
            Dept_Id.Margin = new Padding(4, 5, 4, 5);
            Dept_Id.Name = "Dept_Id";
            Dept_Id.Size = new Size(203, 31);
            Dept_Id.TabIndex = 3;
            // 
            // Dept_Name
            // 
            Dept_Name.Location = new Point(124, 312);
            Dept_Name.Margin = new Padding(4, 5, 4, 5);
            Dept_Name.Name = "Dept_Name";
            Dept_Name.Size = new Size(203, 31);
            Dept_Name.TabIndex = 4;
            // 
            // Add
            // 
            Add.Location = new Point(9, 400);
            Add.Margin = new Padding(4, 5, 4, 5);
            Add.Name = "Add";
            Add.Size = new Size(107, 38);
            Add.TabIndex = 5;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Change
            // 
            Change.Location = new Point(146, 400);
            Change.Margin = new Padding(4, 5, 4, 5);
            Change.Name = "Change";
            Change.Size = new Size(107, 38);
            Change.TabIndex = 6;
            Change.Text = "Change";
            Change.UseVisualStyleBackColor = true;
            Change.Click += Change_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(281, 400);
            Delete.Margin = new Padding(4, 5, 4, 5);
            Delete.Name = "Delete";
            Delete.Size = new Size(107, 38);
            Delete.TabIndex = 7;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Emp_Name
            // 
            Emp_Name.Location = new Point(864, 337);
            Emp_Name.Margin = new Padding(4, 5, 4, 5);
            Emp_Name.Name = "Emp_Name";
            Emp_Name.Size = new Size(198, 31);
            Emp_Name.TabIndex = 12;
            // 
            // Emp_Id
            // 
            Emp_Id.Location = new Point(864, 267);
            Emp_Id.Margin = new Padding(4, 5, 4, 5);
            Emp_Id.Name = "Emp_Id";
            Emp_Id.Size = new Size(198, 31);
            Emp_Id.TabIndex = 11;
            // 
            // EmpName
            // 
            EmpName.AutoSize = true;
            EmpName.Location = new Point(703, 342);
            EmpName.Margin = new Padding(4, 0, 4, 0);
            EmpName.Name = "EmpName";
            EmpName.Size = new Size(102, 25);
            EmpName.TabIndex = 10;
            EmpName.Text = "Emp_Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(719, 267);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 9;
            label3.Text = "Emp_Id";
            // 
            // Emp
            // 
            Emp.FormattingEnabled = true;
            Emp.Location = new Point(794, 177);
            Emp.Margin = new Padding(4, 5, 4, 5);
            Emp.Name = "Emp";
            Emp.Size = new Size(304, 33);
            Emp.TabIndex = 8;
            Emp.SelectedIndexChanged += Emp_SelectedIndexChanged;
            // 
            // Delete2
            // 
            Delete2.BackColor = Color.LightGray;
            Delete2.Location = new Point(1019, 464);
            Delete2.Margin = new Padding(4, 5, 4, 5);
            Delete2.Name = "Delete2";
            Delete2.Size = new Size(107, 38);
            Delete2.TabIndex = 15;
            Delete2.Text = "Delete";
            Delete2.UseVisualStyleBackColor = false;
            Delete2.Click += Delete2_Click;
            // 
            // Change2
            // 
            Change2.Location = new Point(864, 464);
            Change2.Margin = new Padding(4, 5, 4, 5);
            Change2.Name = "Change2";
            Change2.Size = new Size(107, 38);
            Change2.TabIndex = 16;
            Change2.Text = "Change";
            Change2.UseVisualStyleBackColor = true;
            Change2.Click += Change2_Click;
            // 
            // Add2
            // 
            Add2.Location = new Point(731, 464);
            Add2.Margin = new Padding(4, 5, 4, 5);
            Add2.Name = "Add2";
            Add2.Size = new Size(107, 38);
            Add2.TabIndex = 17;
            Add2.Text = "Add";
            Add2.UseVisualStyleBackColor = true;
            Add2.Click += Add2_Click;
            // 
            // Pre
            // 
            Pre.Location = new Point(864, 535);
            Pre.Margin = new Padding(4, 5, 4, 5);
            Pre.Name = "Pre";
            Pre.Size = new Size(71, 38);
            Pre.TabIndex = 18;
            Pre.Text = "Pre";
            Pre.UseVisualStyleBackColor = true;
            Pre.Click += Pre_Click;
            // 
            // Next
            // 
            Next.Location = new Point(973, 535);
            Next.Margin = new Padding(4, 5, 4, 5);
            Next.Name = "Next";
            Next.Size = new Size(64, 38);
            Next.TabIndex = 19;
            Next.Text = "Next";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(115, 25);
            label2.TabIndex = 20;
            label2.Text = "Departments";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(900, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 21;
            label4.Text = "Employees";
            // 
            // txtEmpDeptID
            // 
            txtEmpDeptID.Location = new Point(864, 400);
            txtEmpDeptID.Margin = new Padding(4, 5, 4, 5);
            txtEmpDeptID.Name = "txtEmpDeptID";
            txtEmpDeptID.Size = new Size(198, 31);
            txtEmpDeptID.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(703, 405);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 22;
            label5.Text = "DeptID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1143, 750);
            Controls.Add(txtEmpDeptID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(Next);
            Controls.Add(Pre);
            Controls.Add(Add2);
            Controls.Add(Change2);
            Controls.Add(Delete2);
            Controls.Add(Emp_Name);
            Controls.Add(Emp_Id);
            Controls.Add(EmpName);
            Controls.Add(label3);
            Controls.Add(Emp);
            Controls.Add(Delete);
            Controls.Add(Change);
            Controls.Add(Add);
            Controls.Add(Dept_Name);
            Controls.Add(Dept_Id);
            Controls.Add(Deptname);
            Controls.Add(label1);
            Controls.Add(Dept);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Dept;
        private Label label1;
        private Label Deptname;
        private TextBox Dept_Id;
        private TextBox Dept_Name;
        private Button Add;
        private Button Change;
        private Button Delete;
        private TextBox Emp_Name;
        private TextBox Emp_Id;
        private Label EmpName;
        private Label label3;
        private ComboBox Emp;
        private Button Delete2;
        private Button Change2;
        private Button Add2;
        private Button Pre;
        private Button Next;
        private Label label2;
        private Label label4;
        private TextBox txtEmpDeptID;
        private Label label5;
    }
}
