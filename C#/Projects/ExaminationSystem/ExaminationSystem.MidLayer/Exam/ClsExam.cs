using ExaminationSystem.MidLayer.Answer;
using ExaminationSystem.MidLayer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Exam
{
    public abstract class ClsExam<T> where T : ClsSubject
    {
        public enum enExamMode
        {
            Starting = 1,
            Queued,
            Finished
        }
        public ClsAnswerList StdAnswers { get; protected set; } = new();
        public string Name { get; protected set; } = string.Empty;
        public int TotalGrade { get; set; } = 0;
        public enExamMode Mode { get; protected set; }
        public TimeSpan Time { get; protected set; }


        public virtual void StartExam(T sub, ClsStudent st)
        {
            Name += $" {sub.Name} exam";
            Mode = enExamMode.Starting;
            Console.WriteLine("================================================================================================");
            Console.WriteLine($"{Name} has started");
            Console.WriteLine("================================================================================================");

        }



    }
}
