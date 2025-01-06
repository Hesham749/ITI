using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Demo2
{
    internal class ClsEmp : ClsPerson, IComparer<ClsEmp> 
    {
        static public int EmpCounter { get; private set; }

        public ClsEmp(int id, string name, int age = 30, double salary = 6000) : base(id, name)
        {
            EmpCounter++;
            Age = 30;
            if (!SetAge(age))
                Console.WriteLine($"age set to {Age}");
            Salary = 6000;
            if (!SetSalary(salary))
                Console.WriteLine($"salary set to {Salary}");
        }

        public override bool SetAge(int age)
        {
            if (age < 30 || age >= 60)
                return false;
            Age = age;
            return true;
        }

        public double Salary
        {
            get; protected set;
        }

        public bool SetSalary(double salary)
        {
            if (salary <= 6000)
                return false;
            Salary = salary;
            return true;
        }

        public override string ToString()
        {
            return $"Emp Data :  Id : {Id} , name : {Name} , age : {Age} , salary : {Salary}";
        }

        public override void Print()
        {
            Console.Write("Emp Data : ");
            base.Print();
            Console.WriteLine($" , salary : {Salary}");
        }

        public int Compare(ClsEmp? x, ClsEmp? y)
        {
            return x.Name.CompareTo(y.Name);
        }
        
    }
}
