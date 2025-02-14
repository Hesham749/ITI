using EF_lab1.Models;
using CompanyEFContext = EF_lab1.Models.TestScafoldContext;

namespace EF_lab1
{
    public partial class Form1 : Form
    {
        CompanyEFContext adoContext = new CompanyEFContext();
        public Form1()
        {
            InitializeComponent();
            LoadDeptIds();
            LoadEmpIds();
        }
        // =========================================== Dept =============================================
        private void LoadDeptIds()
        {

            var deptIds = adoContext.Departments
                                    .Select(d => new { d.DeptName, d.DeptID })
                                    .Distinct()
                                    .ToList();
            Dept.DataSource = deptIds;
            Dept.DisplayMember = "DeptName";
            Dept.ValueMember = "DeptId";

        }
        private void Dept_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Dept.SelectedItem != null)
            {
                var selectedDept = (dynamic)Dept.SelectedItem;
                var selectedDept2 = Dept.SelectedItem;
                Dept_Name.Text = selectedDept.DeptName.ToString();
                Dept_Id.Text = selectedDept.DeptID.ToString();


            }
        }

        private void Dept_Name_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string deptName = Dept_Name.Text;
            if (!string.IsNullOrEmpty(deptName))
            {
                Department newDept = new Department()
                {
                    DeptName = deptName,
                };
                adoContext.Departments.Add(newDept);
                adoContext.SaveChanges();
                Dept.SelectedItem = newDept;
                LoadDeptIds();

            }
            else
            {
                MessageBox.Show("Please enter a valid department name.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var selectdept = (dynamic)Dept.SelectedItem;
            if (Dept.SelectedItem != null)
            {
                int deptid = selectdept.DeptID;
                var deptToDelete = adoContext.Departments.FirstOrDefault(d => d.DeptID == deptid);
                adoContext.Departments.Remove(deptToDelete);
                adoContext.SaveChanges();
                LoadDeptIds();
            }
            else
            {
                MessageBox.Show("Please select a department to delete.");
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            var selectdept = (dynamic)Dept.SelectedItem;
            if (Dept.SelectedItem != null)
            {
                int deptid = selectdept.DeptID;
                var deptToupdate = adoContext.Departments.FirstOrDefault(d => d.DeptID == deptid);
                string newDeptName = Dept_Name.Text;
                if (!string.IsNullOrEmpty(newDeptName))
                {

                    deptToupdate.DeptName = newDeptName;
                    adoContext.SaveChanges();
                    LoadDeptIds();
                }
                else
                {
                    MessageBox.Show("Please enter a valid department name.");
                }
            }
            else
            {
                MessageBox.Show("Please select a department to Update.");
            }


        }
        // =========================================== EMP =============================================
        private void LoadEmpIds()
        {
            var EmpIds = adoContext.Employees
                                    .Select(e => new { e.EmpName, e.EmpID, e.DeptID })
                                    .Distinct()
                                    .ToList();
            Emp.DataSource = EmpIds;
            Emp.DisplayMember = "EmpName";
            Emp.ValueMember = "EmpID";

        }
        private void Emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Emp.SelectedItem != null)
            {
                var selectedEmp = (dynamic)Emp.SelectedItem;
                Emp_Name.Text = selectedEmp.EmpName.ToString();
                Emp_Id.Text = selectedEmp.EmpID.ToString();
                txtEmpDeptID.Text = selectedEmp.DeptID?.ToString() ?? "";
            }

        }

        private void Add2_Click(object sender, EventArgs e)
        {
            string empName = Emp_Name.Text;
            string DeptID = txtEmpDeptID.Text;
            if (!string.IsNullOrEmpty(empName))
            {
                Employee newemp = new Employee()
                {
                    EmpName = empName,
                    DeptID = int.TryParse(DeptID, out int x) ? x : null
                };
                adoContext.Employees.Add(newemp);
                adoContext.SaveChanges();
                Dept.SelectedItem = newemp;
                LoadEmpIds();
                MessageBox.Show("Employee Added Successfully");
            }
            else
            {
                MessageBox.Show("Please enter a valid Emp name.");
            }

        }

        private void Change2_Click(object sender, EventArgs e)
        {
            var selectemp = (dynamic)Emp.SelectedItem;
            if (Emp.SelectedItem != null)
            {
                int empid = selectemp.EmpID;
                var empToupdate = adoContext.Employees.FirstOrDefault(e => e.EmpID == empid);
                string newEmpName = Emp_Name.Text;
                int? newEmpDeptID = int.TryParse(txtEmpDeptID.Text, out int y) ? y : null;
                if (!string.IsNullOrEmpty(newEmpName))
                {

                    empToupdate.EmpName = newEmpName;
                    empToupdate.DeptID = newEmpDeptID;
                    adoContext.SaveChanges();
                    LoadEmpIds();
                    MessageBox.Show("Employee Changed Successfully");
                }
                else
                {
                    MessageBox.Show("Please enter a valid Emp name.");
                }
            }
            else
            {
                MessageBox.Show("Please select a emp to Update.");
            }

        }

        private void Delete2_Click(object sender, EventArgs e)
        {
            var selectemp = (dynamic)Emp.SelectedItem;
            if (Emp.SelectedItem != null)
            {
                int empid = selectemp.EmpID;
                var empToDelete = adoContext.Employees.FirstOrDefault(e => e.EmpID == empid);
                adoContext.Employees.Remove(empToDelete);
                adoContext.SaveChanges();
                LoadEmpIds();
            }
            else
            {
                MessageBox.Show("Please select a Emp to delete.");
            }

        }

        private void Pre_Click(object sender, EventArgs e)
        {
            if (Emp.SelectedIndex > 0)
            {
                Emp.SelectedIndex -= 1;
            }
            else
            {
                MessageBox.Show("There is no previous item.");
            }

        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (Emp.SelectedIndex < Emp.Items.Count - 1)
            {
                Emp.SelectedIndex += 1;
            }
            else
            {
                MessageBox.Show("There is no next item.");
            }

        }
    }
}
