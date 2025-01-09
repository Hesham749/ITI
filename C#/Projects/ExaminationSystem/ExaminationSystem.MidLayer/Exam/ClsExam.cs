using ExaminationSystem.MidLayer.Answer;
using ExaminationSystem.MidLayer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Exam
{
    public class ClsExam<T> where T : ClsSubject
    {
        public enum enExamMode
        {
            Starting = 1,
            Queued,
            Finished
        }
        //public ClsSubject Subject { get; set; }
        public ClsAnswerList StdAnswers { get; private set; } = new();
        public string Name { get; private set; }
        public enExamMode Mode { get; private set; }
        public TimeSpan Time { get; private set; }


        public void StartExam(ClsSubject sub)
        {

        }


    }
}
