using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void FillRow(DataRow dataRow)
        {
            dataRow["id"] = int.Parse(txtID.Text);
            dataRow["fName"] = txtFName.Text;
            dataRow["LName"] = txtLName.Text;
            dataRow["DeptNum"] = int.Parse(txtDeptNum.Text);
            dataRow["deptName"] = txtDeptName.Text;
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FillRow(dt.Rows[currentRowIndex]);

            sqlDataAdapter1.Update(dt);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int rowCounter = 0;
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
    }
}
