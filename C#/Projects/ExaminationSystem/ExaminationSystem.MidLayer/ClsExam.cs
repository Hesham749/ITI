using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    enum enExamType
    {
        Final = 1,
        Practice = 2,
    }
    public class ClsExam
    {
        public int StdID { get; set; }
        public ClsQuestionList QL { get; init; }
        public ClsAnswerList StdAnswers { get; private set; }

    }
}
