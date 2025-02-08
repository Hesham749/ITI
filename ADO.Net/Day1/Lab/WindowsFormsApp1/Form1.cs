using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable dt;
        int currentRowIndex;
        public Form1()
        {
            InitializeComponent();
            dt = new DataTable("Employee");
            sqlDataAdapter1.Fill(dt);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DataView viewAll = dt.DefaultView;
            viewAll.RowFilter = "";
            dgv.DataSource = dt.DefaultView;
            currentRowIndex = 0;
            FillTextBoxes(dt.Rows[currentRowIndex]);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow dataRow = dt.NewRow();
            FillRow(dataRow);
            dt.Rows.Add(dataRow);
            sqlDataAdapter1.Update(dt);
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
            FillRow(dt.Rows[currentRowIndex]);

            sqlDataAdapter1.Update(dt);
            MessageBox.Show("Record Updated Successfully");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int rowCounter = 0;
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrWhiteSpace(txtID.Text))
                return;
            foreach (DataRow item in dt.Rows)
            {
                if (item[0].ToString() == txtID.Text)
                {
                    currentRowIndex = rowCounter;
                    FillTextBoxes(item);
                    break;
                }
                rowCounter++;
            }
            DataView view = dt.DefaultView;
            view.RowFilter = $"id = {txtID.Text}";
            dgv.DataSource = dt.DefaultView;

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
                if (item[0].ToString() == txtID.Text)
                {
                    item.Delete();
                    sqlDataAdapter1.Update(dt);
                    MessageBox.Show("Record Deleted Successfully");
                    break;
                }

            }
        }


    }
}
