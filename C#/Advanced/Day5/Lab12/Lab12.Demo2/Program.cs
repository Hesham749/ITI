namespace Lab12.Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClsDepartment d1 = new ClsDepartment() { DeptId = 1, DeptName = "dept1" };
            ClsDepartment d2 = new ClsDepartment() { DeptId = 2, DeptName = "dept2" };
            ClsStudent s1 = new ClsStudent() { Id = 1, Name = "ezzat" };
            ClsStudent s2 = new ClsStudent() { Id = 2, Name = "Hesham" };
            ClsStudent s3 = new ClsStudent() { Id = 3, Name = "Lotfy" };
            ClsStudent s4 = new ClsStudent() { Id = 4, Name = "Karim" };
            d1.Add(s1);
            d1.Add(s3);
            d1.Add(s3);
            d2.Add(s4);
            d1.ShowStudents();
            s1.IncreaseAbsentDays();
            s1.IncreaseAbsentDays();
            s1.IncreaseAbsentDays();
            d1.ShowStudents();
            s1.IncreaseAbsentDays();
        }

    }
}
