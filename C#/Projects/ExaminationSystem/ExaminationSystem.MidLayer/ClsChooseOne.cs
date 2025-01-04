using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    public class ClsChooseOne : ClsQuestion
    {
        public ClsChooseOne(int id, string body) : base(EnQuestionType.ChooseOne, "Read each question carefully and select the best answer from the given options :", 2, body, id)
        {
        }

    }
}
