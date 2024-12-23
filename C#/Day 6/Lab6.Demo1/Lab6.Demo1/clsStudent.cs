namespace Lab6.Demo1
{
    internal class clsStudent : clsPerson
    {
        public int StudentCounter { get; private set; }
        public int Grade { get; protected set; }

        public clsStudent(string name, int age, int grade) : base(name, age)
        {
            grade = 1;
            SetGrade(grade);
            Age = 6;
            if (!SetAge(age))
                Console.WriteLine($"Age is set to {Age}");
        }

        public bool SetGrade(int grade)
        {
            if (grade < 1 || grade > 6)
                return false;
            Grade = grade;
            return true;
        }
        public override bool SetAge(int age)
        {
            if (age < 6 || age >= 12)
                return false;
            Age = age;
            return true;
        }
    }
}
