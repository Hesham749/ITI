using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    internal class ClsChooseMultiple : ClsQuestion
    {
        public ClsChooseMultiple(string body)
        {
            QuestionType = EnQuestionType.ChooseMultiple;
            Mark = 2;
            Header = "Read each question carefully and select all correct answers :";
            Body = body;
        }
    }
}
