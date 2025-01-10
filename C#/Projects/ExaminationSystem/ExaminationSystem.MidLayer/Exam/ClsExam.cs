using ExaminationSystem.MidLayer.Answer;
using ExaminationSystem.MidLayer.Question;
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

        protected ClsExam()
        {
            Mode = enExamMode.Queued;
        }
        public virtual void StartExam(T sub, ClsStudent st)
        {
            Name += $" {sub.Name} exam";
            Mode = enExamMode.Starting;
            Console.WriteLine("================================================================================================");
            Console.WriteLine($"{Name} has started");
            Console.WriteLine("================================================================================================");

        }


        protected static void PrintAnswerResult(ClsQuestion q, ClsAnswer answer)
        {
            if (answer.Mark == q.Mark)
                Console.WriteLine("Great job correct answer");
            else
            {
                Console.WriteLine("oops wrong answer");
                Console.WriteLine($"correct answer is {q.GetAnswer()}");
            }
        }

        protected ClsAnswer GetAnswer(ClsQuestion q)
        {
            ClsAnswer answer = new();
            bool wrongAnswer = false;
            char c;
            int y;
            while (int.TryParse((c = Console.ReadKey().KeyChar).ToString(), out y) || c != 13)
            {
                if (y < q.Options.Count && y >= 1)
                {
                    answer.Answer.Add(y, q.Options[y]);
                    if (answer.Answer.Count > q.CorrectAnswer.Length || !q.CorrectAnswer.Contains(y))
                        wrongAnswer = true;
                }
            }

            answer.Mark = (wrongAnswer) ? 0 : q.Mark;
            return answer;
        }

        protected ClsQuestion GetQuestion(ClsSubject sub)
        {
            ClsQuestion q;
            do
            {
                Random random = new();
                int x = random.Next(0, sub.QuestionList.Count);
                q = sub.QuestionList[x];
            } while (StdAnswers.AnswerList.ContainsKey(q));
            return q;
        }


    }
}
