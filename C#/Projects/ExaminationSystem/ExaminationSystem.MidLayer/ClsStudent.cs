using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    public class ClsStudent
    {
        static int _stdCounter;
        public string Name { get; set; }
        public int StudentID { get; private set; }

        public ClsStudent(string name)
        {
            Name = name;
            StudentID = ++_stdCounter;
        }
    }
}
