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
            s.FireStudentRegister(Remove);
        }


        void Remove(ClsStudent s)
        {
            s.FireStudentUnRegister(Remove);
            Students.Remove(s);
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