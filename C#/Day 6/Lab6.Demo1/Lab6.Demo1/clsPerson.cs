namespace Lab6.Demo1
{
    internal class clsPerson
    {
        static public int PersonCounter { get; private set; }

        public clsPerson(string name, int age = 0)
        {
            Id = ++PersonCounter;
            Name = name;
            Age = 0;
            if (!SetAge(age))
                Console.WriteLine($"Age set to {Age}");
        }

        public int Id
        {
            get; private set;
        }
        public string Name
        {
            get;
            protected set;
        }

        public bool SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name) || name == "")
                return false;
            Name = name;
            return true;
        }

        public int Age { get; protected set; }

        public bool SetAge(int age)
        {
            if (age < 0 || age > 100)
                return false;
            Age = age;
            return true;
        }

        virtual public void Print()
        {
            Console.Write($"Id : {Id} , name : {Name} , age : {Age}");
        }
    }
}
