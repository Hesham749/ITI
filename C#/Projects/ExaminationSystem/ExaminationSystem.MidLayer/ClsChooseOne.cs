using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    internal class ClsChooseOne : ClsQuestion
    {
        public ClsChooseOne(string body)
        {
            QuestionType = EnQuestionType.ChooseOne;
            Mark = 2;
            Header = "Read each question carefully and select the best answer from the given options :";
            Body = body;
        }

    }
}
