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
            d2.Add(s1);
            d1.Add(s2);
            d2.Add(s2);
            d2.Add(s3);
            d1.Add(s3);

            d1.ShowStudents();
            d2.ShowStudents();
            // 3 Fails
            s1.IncreaseFails();
            s1.IncreaseFails();
            s1.IncreaseFails();
            //this will remove s1 from the d1 , d2


            s2.IncreaseAbsentDays(d2);
            s2.IncreaseAbsentDays(d2);
            s2.IncreaseAbsentDays(d2);

            //s2.FailHandler.Invoke(s2, null);  //this will remove s2  no security
            Console.WriteLine();
            Console.WriteLine();



            //3 absents
            s3.IncreaseAbsentDays();
            s3.IncreaseAbsentDays();
            s3.IncreaseAbsentDays();

            d1.ShowStudents();

            d2.ShowStudents();




        }
    }
}
