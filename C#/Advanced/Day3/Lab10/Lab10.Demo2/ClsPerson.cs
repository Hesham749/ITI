using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10.Demo2
{
    internal abstract class ClsPerson
    {
        static public int PersonCounter { get; private set; }
        public ClsPerson(string name)
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
