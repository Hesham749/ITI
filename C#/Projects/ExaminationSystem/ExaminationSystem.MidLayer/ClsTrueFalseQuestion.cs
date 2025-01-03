using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    internal class ClsTrueFalseQuestion : ClsQuestion
    {
        public ClsTrueFalseQuestion(string body)
        {
            QuestionType = EnQuestionType.TrueFalse;
            Mark = 2;
            Header = "Read each statement carefully and decide whether it is True or False :";
            Body = body;
        }

        public override string ToString() => $"{Body}";

    }
}
