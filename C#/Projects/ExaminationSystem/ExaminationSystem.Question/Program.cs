using ExaminationSystem.MidLayer;
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
            //ClsTrueFalse q1 = new("The square root of 25 is always 5", new Dictionary<int, string> { [2] = "False" });
            ClsTrueFalse q1 = new("The square root of 25 is always 5",2);
            //ClsChooseOne q2 = new("What is the value of 𝑥x in the equation 3𝑥+7=193x+7=19?", new Dictionary<int, string> { [1] = "4", [2] = "5", [3] = "6", [4] = "7" }, new Dictionary<int, string> { [1] = "4" });
            //ClsChooseMultiple q3 = new("Which of the following numbers are prime", new Dictionary<int, string> { [1] = "17", [2] = "21", [3] = "23", [4] = "27", [5] = "31" }, 1, 3, 5);
            ClsMath math = new("Math");
            ClsEnglish english = new("English");
            math.Add(q1);
            //math.Add(q2);
            //math.Add(q3);
            ClsStudent s1 = new("Hesham");
            ClsStudent s2 = new("Karim");
            math.AddStd(s1);
            math.AddStd(s2);
            ClsSubjectList.Add(math);
            math.PrintQuestionList();
            ClsSubjectList.Print();
            Console.ReadKey();
        }
    }
}
