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
                q.Print();
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
            ClsColorText.ColorText($"You got {TotalGrade} out of {totalQuestionGrade}", ConsoleColor.DarkGreen);
            Console.WriteLine("=========================================================================================================");
            Name = $"{st.Name} {Name}";
        }



        public override string ToString()
        {
            return Name ?? "Practice Exam";

        }


    }

}