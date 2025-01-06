using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15.Demo2
{
    internal abstract class ClsPerson
    {
        private int _id;

        static public int PersonCounter { get; private set; }
        public ClsPerson(int id, string name)
        {
            Id = ++PersonCounter;
            Id = id;
            Name = "Unknown";
            if (!SetName(name))
                Console.WriteLine($"name set to {Name}");
        }

        public int Id
        {
            get => _id;
            set
            {
                if (value > 0)
                    _id = value;
            }
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
