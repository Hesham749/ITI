namespace Lab6.Demo1
{
    internal class clsPerson
    {
        static public int PersonCounter { get; private set; }
        string _name = "Unknown";
        int _age;

        public clsPerson(string name, int age = 0)
        {
            Id = ++PersonCounter;
            Name = name;
            Age = age;
        }

        public int Id
        {
            get; private set;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value != "")
                    _name = value;
                else
                    Console.WriteLine("name doesn't change");
            }
        }

        virtual public int Age
        {
            get { return _age; }
            set
            {
                if (value >= 0 && value < 100)
                    _age = value;
                else
                    Console.WriteLine("Age doesn't change");
            }
        }

        virtual public void Print()
        {
            Console.Write($"Id : {Id} , name : {Name} , age : {Age}");
        }
    }
}
