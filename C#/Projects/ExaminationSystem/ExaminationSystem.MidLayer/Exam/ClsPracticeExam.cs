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
            Time = TimeSpan.FromSeconds(15);
        }

        public override void StartExam(ClsSubject sub, ClsStudent st)
        {
            base.StartExam(sub, st);
            var ql = GetQuestionList(sub, 4);
            foreach (var q in ql)
            {
                if (Mode == enExamMode.Finished)
                    break;
                Console.WriteLine();
                q.Print();
                ClsAnswer answer = new();
                if (q.GetType() == typeof(ClsChooseMultiple))
                {
                    answer = GetUserAnswer(q);
                    StdAnswers.Add(q, answer);
                }
                else
                {
                    int userInput;
                    while (!int.TryParse((Console.ReadKey().KeyChar).ToString(), out userInput))
                    {
                        if (Mode == enExamMode.Finished)
                            break;
                        Console.WriteLine("\ninsert valid choice");
                    }
                    if (Mode == enExamMode.Finished)
                        break;
                    if (userInput > 0 && userInput < q.Options.Count)
                        answer.Answer.Add(userInput, q.Options[userInput]);
                    else
                        userInput = -1;
                    answer.Mark = (answer.Answer.Count > q.CorrectAnswer.Length || !q.CorrectAnswer.Contains(userInput)) ? 0 : q.Mark;
                }
                Console.WriteLine();
                PrintAnswerResult(q, answer);
                StdGrade += answer.Mark;
                Console.WriteLine("\n=========================================================================================================");
            }
            Mode = enExamMode.Finished;
            ClsColorText.ColorText($"                                    You got {StdGrade} out of {TotalGrade}", ConsoleColor.DarkGreen);
            Console.WriteLine("=========================================================================================================");
            Name = $"{st.Name} {Name}";
        }

        public override string ToString()
        {
            return Name ?? "Practice Exam";

        }


    }

}