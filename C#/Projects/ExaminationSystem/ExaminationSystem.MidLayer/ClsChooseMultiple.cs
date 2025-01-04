using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    public class ClsChooseMultiple : ClsQuestion
    {
        public ClsChooseMultiple(int id, string body) : base(id)
        {
            QuestionType = EnQuestionType.ChooseMultiple;
            Mark = 2;
            Header = "Read each question carefully and select all correct answers :";
            Body = body;
        }
    }
}
