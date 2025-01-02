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
            d1.Add(s1);
            d1.Add(s2);
            d2.Add(s3);

            d1.ShowStudents();
            // 3 Fails
            s1.IncreaseFails();
            s1.IncreaseFails();
            s1.IncreaseFails();

            d1.ShowStudents();

            d2.ShowStudents();
            //3 absents
            s3.IncreaseAbsentDays();
            s3.IncreaseAbsentDays();
            s3.IncreaseAbsentDays();

            d2.ShowStudents();

        }
    }
}
