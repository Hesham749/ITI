using ExaminationSystem.MidLayer.Question;
using ExaminationSystem.MidLayer.Subject;
using System.Net.NetworkInformation;

namespace ExaminationSystem.UI
{
    internal class Program
    {


        //static void StartExam()
        //{
        //    Console.Write("Welcome Please enter your ID : ");
        //    ReadStdId(out int Id);

        //    Console.WriteLine("Please choose the exam type :");
        //    ClsSubjectList.Print();
        //    GetExamType(out enExamType examType);
        //    Console.WriteLine();
        //    Console.WriteLine(examType);
        //    Console.WriteLine("=====================================");

        //}

        //private static enExamType GetExamType(out enExamType examType)
        //{
        //    int exType;
        //    Console.Write("Final Exam (1) / Practice Exam (2) : ");
        //    while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out exType) || exType < 1 || exType > 2)
        //    {
        //        Console.WriteLine("\nInsert Correct choice");
        //    }
        //    examType = (enExamType)exType;
        //    return examType;
        //}

        private static void ReadStdId(out int id)
        {
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("please insert only Numbers");
            }
        }

        static void Main(string[] args)
        {
            //StartExam();
            ClsTrueFalse q1 = new("Q1\n 1) True \t\t2)False ", new Dictionary<int, string> { [1] = "True" });
            ClsChooseOne q2 = new("Q2\n 1) Choose one ", new Dictionary<int, string> { [1] = "True" });
            ClsMath math = new("Math");
            //math.Add(q1);
            //math.Add(q2);
            math.PrintQuestionList();
            Console.ReadKey();
        }
    }
}
