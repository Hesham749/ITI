using ExaminationSystem.MidLayer.Answer;
using ExaminationSystem.MidLayer.Question;
using ExaminationSystem.MidLayer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem.MidLayer.Exam
{
    //delegate bool myDel();
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
            int totalQuestionGrade = 0;
            for (int i = 0; i < 4; i++)
            {
                ClsQuestion q = GetQuestion(sub);
                Console.WriteLine();
                Console.WriteLine(q);
                ClsAnswer answer = new();
                if (q.GetType() == typeof(ClsChooseMultiple))
                {
                    answer = GetAnswer(q);
                    StdAnswers.Add(q, answer);
                }
                else
                {
                    int userInput;
                    while (!int.TryParse((Console.ReadKey().KeyChar).ToString(), out userInput))
                    {
                        Console.WriteLine("insert valid choice");
                    }
                    if (userInput > 0 && userInput < q.Options.Count)
                        answer.Answer.Add(userInput, q.Options[userInput]);
                    else
                        userInput = -1;
                    answer.Mark = (answer.Answer.Count > q.CorrectAnswer.Length || !q.CorrectAnswer.Contains(userInput)) ? 0 : q.Mark;
                }
                Console.WriteLine();
                PrintAnswerResult(q, answer);
                TotalGrade += answer.Mark;
                totalQuestionGrade += q.Mark;
                Console.WriteLine("\n=========================================================================================================");
            }
            Mode = enExamMode.Finished;
            Console.WriteLine($"You got {TotalGrade} out of {totalQuestionGrade}");
        }

        private static void PrintAnswerResult(ClsQuestion q, ClsAnswer answer)
        {
            if (answer.Mark == q.Mark)
                Console.WriteLine("Great job correct answer");
            else
            {
                Console.WriteLine("oops wrong answer");
                Console.WriteLine($"correct answer is {q.GetAnswer()}");
            }
        }

        ClsAnswer GetAnswer(ClsQuestion q)
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



        private ClsQuestion GetQuestion(ClsSubject sub)
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

        public override string ToString()
        {
            return Name ?? "Practice Exam";

        }


    }

}