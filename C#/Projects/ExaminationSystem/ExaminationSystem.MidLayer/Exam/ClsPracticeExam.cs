using ExaminationSystem.MidLayer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Exam
{
    public class ClsPracticeExam : ClsExam<ClsSubject>
    {

        public ClsPracticeExam()
        {
            Name = "Practice";
            Time = TimeSpan.FromHours(.5);
        }

        public override void StartExam(ClsSubject sub, ClsStudent st)
        {
            base.StartExam(sub, st);
            for (int i = 0; i < 1; i++)
            {
                Random random = new();
                int x = random.Next(0, sub.QuestionList.Count);
                Console.WriteLine($"{sub.QuestionList[x]}");
                Console.ReadLine();
            }

        }

        public override string ToString()
        {
            return Name ?? "Practice Exam";

        }


    }

}