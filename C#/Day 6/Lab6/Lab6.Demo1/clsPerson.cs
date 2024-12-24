namespace Lab6.Demo1
{
    internal abstract class clsPerson
    {
        static public int PersonCounter { get; private set; }
        public clsPerson(string name)
        {
            Id = ++PersonCounter;
            Name = "Unknown";
            if (!SetName(name))
                Console.WriteLine($"name set to {Name}");
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

        public abstract bool SetAge(int age);


        virtual public void Print()
        {
            Console.Write($"Id : {Id} , name : {Name} , age : {Age}");
        }
    }
}
