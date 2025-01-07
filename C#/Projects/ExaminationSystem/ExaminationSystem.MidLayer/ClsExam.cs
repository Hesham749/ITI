using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer
{
    public enum enExamType
    {
        Final = 1,
        Practice = 2,
    }

    public class ClsExam
    {
        public enum enExamMode
        {
            Starting = 1,
            Queued,
            Finished
        }
        public ClsSubject Subject { get; set; } 
        public ClsQuestionList QL { get; set; } 
        public ClsAnswerList StdAnswers { get; private set; } = new ClsAnswerList();
        public enExamType ExamType { get; set; }
        public string Name { get; private set; }
        public enExamMode Mode { get; private set; }
        public int Time { get; private set; }


        public void StartExam()
        {

        }
                
    }
}
