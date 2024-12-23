namespace Lab6.Demo1
{
    internal class clsEmp : clsPerson
    {
        static public int EmpCounter { get; private set; }
        double _salary = 6000;

        public clsEmp(string name, int age = 30, double salary = 6000) : base(name, age)
        {
            EmpCounter++;
            Age = 30;
            Age = age;
            Salary = salary;
        }

        public new int Age
        {
            get { return base.Age; }
            set
            {
                if (value >= 30 && value < 60)
                    base.Age = value;
                else Console.WriteLine("Age doesn't changed");
            }
        }

        public double Salary
        {
            get { return _salary; }

            set
            {
                if (value >= 6000)
                    _salary = value;
                else
                    Console.WriteLine("Salary doesn't change");
            }
        }

        public override void Print()
        {
            Console.Write("Emp Data : ");
            base.Print();
            Console.WriteLine($" , salary : {Salary}");
        }
    }
}
