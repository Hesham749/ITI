using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable dt;
        int currentRowIndex;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            dt = new DataTable("Employee");
            cmd = new SqlCommand("", sqlConnection1);
            dgv.DataSource = dt;
            DisconnectMode();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "select * from Employee";
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Clear();
            if (reader.HasRows)
                dt.Load(reader);

            currentRowIndex = 0;
            FillTextBoxes(dt.Rows[currentRowIndex]);
            reader.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            FillRow(dr);
            dt.Rows.Add(dr);
            cmd.CommandText = $"insert into employee (id , fName , lName , DeptNum , deptName)" +
               $"values({dr["id"]} , '{dr["fName"]}' , '{dr["lName"]}' , {dr["DeptNum"]} , '{dr["deptName"]}' )";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Inserted Successfully");

        }

        private void FillRow(DataRow dataRow)
        {
            dataRow["id"] = int.Parse(txtID.Text);
            dataRow["fName"] = string.IsNullOrEmpty(txtFName.Text) || string.IsNullOrWhiteSpace(txtFName.Text) ? null : txtFName.Text;
            dataRow["LName"] = string.IsNullOrEmpty(txtLName.Text) || string.IsNullOrWhiteSpace(txtLName.Text) ? null : txtLName.Text;
            dataRow["DeptNum"] = int.TryParse(txtDeptNum.Text, out int deptNum) ? (object)deptNum : DBNull.Value;
            dataRow["deptName"] = string.IsNullOrEmpty(txtDeptName.Text) || string.IsNullOrWhiteSpace(txtDeptName.Text) ? null : txtDeptName.Text;
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataRow dataRow = dt.Rows[currentRowIndex];
            int currentId = (int)dataRow["id"];
            FillRow(dataRow);
            cmd.CommandText = $"update employee set id = ${dataRow["id"]} " +
                                $", fName = '{dataRow["fName"]}'" +
                                $", LName = '{dataRow["LName"]}'" +
                                $", DeptNum = {dataRow["DeptNum"]}" +
                                $", deptName = '{dataRow["deptName"]}'" +
                                $" where id = {currentId} ;";
            cmd.ExecuteNonQuery();

            MessageBox.Show("Record Updated Successfully");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            currentRowIndex = 0;
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrWhiteSpace(txtID.Text))
                return;
            cmd.CommandText = $"select * from employee where id = {txtID.Text}";
            SqlDataReader reader = cmd.ExecuteReader();
            dt.Clear();
            if (reader.HasRows)
            {
                dt.Load(reader);
                FillTextBoxes(dt.Rows[0]);
            }
            else
                MessageBox.Show("employee not found");
            reader.Close();

        }

        private void FillTextBoxes(DataRow item)
        {
            txtID.Text = item["id"].ToString();
            txtFName.Text = item["fName"].ToString();
            txtLName.Text = item["LName"].ToString();
            txtDeptNum.Text = item["DeptNum"].ToString();
            txtDeptName.Text = item["deptName"].ToString();
        }


        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRowIndex = e.RowIndex;
            FillTextBoxes(dt.Rows[e.RowIndex]);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataRow item in dt.Rows)
            {
                cmd.CommandText = $"delete employee where id = {txtID.Text}";
                if (item[0].ToString() == txtID.Text)
                {
                    cmd.ExecuteNonQuery();
                    item.Delete();
                    MessageBox.Show("Record Deleted Successfully");
                    break;
                }

            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            sqlConnection1.Open();
            ConnectMode();
        }

        private void DisconnectMode()
        {
            btnDisplay.Enabled = btnInsert.Enabled = btnDelete.Enabled = btnFind.Enabled = btnUpdate.Enabled = btnFind.Enabled = btnDisConnect.Enabled = false;
            btnConnect.Enabled = true;
        }

        private void ConnectMode()
        {
            btnDisplay.Enabled = btnInsert.Enabled = btnDelete.Enabled = btnFind.Enabled = btnUpdate.Enabled = btnFind.Enabled = btnDisConnect.Enabled = true;
            btnConnect.Enabled = false;
        }

        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            sqlConnection1.Close();
            DisconnectMode();
        }
    }
}
