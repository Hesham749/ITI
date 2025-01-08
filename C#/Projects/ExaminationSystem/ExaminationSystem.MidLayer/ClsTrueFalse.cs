using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    public class ClsTrueFalse :ClsQuestion
    {

        public ClsTrueFalse( string body, Dictionary<int, string> answer) : base( body, answer)
        {
            Header = "Answer the following True or False questions (Enter 1 for True, 2 for False):";
            Mark = 2;
        }
    }
}
