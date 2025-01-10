using ExaminationSystem.MidLayer.Answer;
using ExaminationSystem.MidLayer.Question;
using ExaminationSystem.MidLayer.Subject;
using ExaminationSystem;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        public int StdGrade { get; set; } = 0;
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
            ClsColorText.ColorText("================================================================================================", ConsoleColor.Cyan);
            Console.WriteLine($"                                {Name} has started");
            ClsColorText.ColorText("================================================================================================", ConsoleColor.Cyan);

        }


        protected void PrintAnswerResult(ClsQuestion q, ClsAnswer answer)
        {
            if (answer.Mark == q.Mark)
                ClsColorText.ColorText("Great job correct answer", ConsoleColor.DarkGreen);

            else
            {
                ClsColorText.ColorText("oops wrong answer", ConsoleColor.Red);
                ClsColorText.ColorText($"correct answer is {q.GetAnswer()}", ConsoleColor.Yellow);
            }
        }

        protected ClsAnswer GetAnswer(ClsQuestion q)
        {
            ClsAnswer answer = new();
            bool wrongAnswer = false;
            char c = ' ';
            int y;
            do   //this
            {
                if (c == 13)
                {
                    wrongAnswer = true;
                    break;
                }
                int.TryParse((c = Console.ReadKey().KeyChar).ToString(), out y);

                if (y < q.Options.Count && y >= 1 && !answer.Answer.ContainsKey(y))
                    answer.Answer.Add(y, q.Options[y]);
                if (answer.Answer.Count > q.CorrectAnswer.Length || !q.CorrectAnswer.Contains(y))  // this
                    wrongAnswer = true;
            } while (y == 0 || c != 13);

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
