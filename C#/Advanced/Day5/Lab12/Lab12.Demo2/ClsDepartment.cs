namespace Lab12.Demo2
{
    internal class ClsDepartment
    {
        public string DeptName { get; set; }
        public int DeptId { get; set; }
        List<ClsStudent> Students = new List<ClsStudent>();
        public void Add(ClsStudent s)
        {
            Students.Add(s);
            s.AbsentAndHandler += Remove;
            s.FialHandler += Remove;
        }

        public void Remove(object b, EventArgs e)
        {
            if (b.GetType() == typeof(ClsStudent))
            {
                ClsStudent student = (ClsStudent)b;
                student.FialHandler -= Remove;
                student.AbsentAndHandler -= Remove;
                Students.Remove(student);
            }
        }

        public void ShowStudents()
        {
            Console.WriteLine($"Department[{DeptId}] students : ");
            Console.WriteLine($"{(Students.Count > 0 ? "======================================================" : "")}");
            foreach (var st in Students)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine($"{(Students.Count > 0 ? "======================================================" : "")}");
        }
    }
}