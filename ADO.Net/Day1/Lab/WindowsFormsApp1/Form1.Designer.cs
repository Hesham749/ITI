namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtDeptNum = new System.Windows.Forms.TextBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT        Employee.*\r\nFROM            Employee";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = "INSERT INTO [Employee] ([ID], [FName], [LName], [DeptNum], [DeptName]) VALUES (@I" +
    "D, @FName, @LName, @DeptNum, @DeptName);\r\nSELECT ID, FName, LName, DeptNum, Dept" +
    "Name FROM Employee WHERE (ID = @ID)";
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 0, "ID"),
            new System.Data.SqlClient.SqlParameter("@FName", System.Data.SqlDbType.NChar, 0, "FName"),
            new System.Data.SqlClient.SqlParameter("@LName", System.Data.SqlDbType.NChar, 0, "LName"),
            new System.Data.SqlClient.SqlParameter("@DeptNum", System.Data.SqlDbType.Int, 0, "DeptNum"),
            new System.Data.SqlClient.SqlParameter("@DeptName", System.Data.SqlDbType.NChar, 0, "DeptName")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@ID", System.Data.SqlDbType.Int, 0, "ID"),
            new System.Data.SqlClient.SqlParameter("@FName", System.Data.SqlDbType.NChar, 0, "FName"),
            new System.Data.SqlClient.SqlParameter("@LName", System.Data.SqlDbType.NChar, 0, "LName"),
            new System.Data.SqlClient.SqlParameter("@DeptNum", System.Data.SqlDbType.Int, 0, "DeptNum"),
            new System.Data.SqlClient.SqlParameter("@DeptName", System.Data.SqlDbType.NChar, 0, "DeptName"),
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DeptNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DeptNum", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DeptNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DeptNum", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DeptName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DeptName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DeptName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DeptName", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_ID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "ID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_FName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "FName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_FName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_LName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "LName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_LName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DeptNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DeptNum", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DeptNum", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DeptNum", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_DeptName", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "DeptName", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_DeptName", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DeptName", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Employee", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("ID", "ID"),
                        new System.Data.Common.DataColumnMapping("FName", "FName"),
                        new System.Data.Common.DataColumnMapping("LName", "LName"),
                        new System.Data.Common.DataColumnMapping("DeptNum", "DeptNum"),
                        new System.Data.Common.DataColumnMapping("DeptName", "DeptName")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.;Initial Catalog=ITI;Integrated Security=True;TrustServerCertificate" +
    "=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(800, 175);
            this.dgv.TabIndex = 1;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(68, 304);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(178, 304);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(54, 251);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 4;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(173, 251);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 5;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(298, 251);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 6;
            // 
            // txtDeptNum
            // 
            this.txtDeptNum.Location = new System.Drawing.Point(419, 251);
            this.txtDeptNum.Name = "txtDeptNum";
            this.txtDeptNum.Size = new System.Drawing.Size(100, 20);
            this.txtDeptNum.TabIndex = 7;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(540, 251);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(100, 20);
            this.txtDeptName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Department Num";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Department Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(288, 304);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(398, 304);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.txtDeptNum);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtDeptNum;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnFind;
    }
}

