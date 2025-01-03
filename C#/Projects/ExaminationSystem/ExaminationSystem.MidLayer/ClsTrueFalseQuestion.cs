using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    internal class ClsTrueFalseQuestion : ClsQuestion
    {
        public ClsTrueFalseQuestion()
        {
            QuestionType = EnQuestionType.TrueFalse;
        }


        public override string ToString()
        {
            return $"";
        }
    }
}
