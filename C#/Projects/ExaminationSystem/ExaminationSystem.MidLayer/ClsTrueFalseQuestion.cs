using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    public class ClsTrueFalseQuestion : ClsQuestion
    {
        public ClsTrueFalseQuestion(int id, string body) : base(EnQuestionType.TrueFalse, "Read each statement carefully and decide whether it is True or False :", 2, body, id)
        {

        }


    }
}
