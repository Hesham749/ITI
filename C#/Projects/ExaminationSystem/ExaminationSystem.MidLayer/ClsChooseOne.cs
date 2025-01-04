using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    public class ClsChooseOne : ClsQuestion
    {
        public ClsChooseOne(int id, string body) : base(id)
        {
            QuestionType = EnQuestionType.ChooseOne;
            Mark = 2;
            Header = "Read each question carefully and select the best answer from the given options :";
            Body = body;
        }

    }
}
