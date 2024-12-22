namespace lab5.demo3
{
    internal class clsEmp
    {
        int _id;
        string _name;
        int _age;
        float _salary;

        public clsEmp(int id, string name) : this(id, name, 0, 0)
        {

        }

        public clsEmp(int id, string name, int age) : this(id, name, age, 0)
        {
        }

        public clsEmp(int id, string name, int age, float salary)
        {
            _id = 0;
            _name = "No name";
            _salary = 3000;
            _age = 30;
            SetId(id);
            SetName(name);
            SetSalary(salary);
            SetAge(age);
        }

        public void SetId(int id)
        {
            if (id > 0)
                _id = id;
        }
        public int GetId() { return _id; }

        public void SetName(string name)
        {
            if (_name != null)
                _name = name;
        }
        public string GetName() { return _name; }

        public void SetAge(int age)
        {
            if (age > 30)
                _age = age;
        }
        public int GetAge() { return _age; }

        public void SetSalary(float salary)
        {
            if (salary > 3000)
                _salary = salary;
        }
        public float GetSalary()
        {
            return _salary;
        }

        public void Print()
        {
            Console.WriteLine($"Id : {_id} , name : {_name,-6} , age : {_age} , salary : {_salary} ");
        }
    }
}
