using ExaminationSystem.MidLayer;
using ExaminationSystem.MidLayer.Exam;
using ExaminationSystem.MidLayer.Question;
using ExaminationSystem.MidLayer.Subject;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

namespace ExaminationSystem.UI
{
    internal class Program
    {


        static void StartProgram()
        {
            Console.Write("Welcome Please enter your ID : ");
            ReadNum(out int Id, (out int x) => !int.TryParse(Console.ReadLine(), out x), "please enter only number");
            Console.WriteLine("Please type subject name");
            ClsSubjectList.Print();
            ClsSubject sub;
            sub = GetSubject();
            ClsStudent std = GetStudent(Id, sub);
            if (std == null)
            {
                Console.WriteLine("you are not register to any subject");
                return;
            }
            Console.Clear();
            Console.WriteLine($"welcome {std.Name} you are about to start {sub.Name} exam");
            Console.WriteLine("Please choose the exam type :");
            Console.WriteLine("[1]- Final Exam\n[2]- practice Exam");
            var Exam = GetExam();
            Console.Clear();
            Exam.StartExam(sub, std);
            Console.WriteLine("=====================================");

        }

        private static ClsExam<ClsSubject> GetExam()
        {
            ClsExam<ClsSubject> Exam;
            int examType;
            ReadNum(out examType, (out int x) => !int.TryParse(Console.ReadLine(), out x), "Please enter valid choice");
            Exam = (examType == 1) ? new ClsFinalExam() : new ClsPracticeExam();
            return Exam;
        }

        private static ClsStudent GetStudent(int Id, ClsSubject sub)
        {
            int i = 1;
            ClsStudent std;
            while ((std = sub.GetStudent(Id)) == null && i < ClsSubjectList.SubList.Count)
            {
                i++;
                Console.Clear();
                Console.WriteLine($"you are not register to {sub.Name} subject choose another one");
                ClsSubjectList.Print();
                sub = GetSubject();
            }

            return std;
        }

        private static ClsSubject GetSubject()
        {
            ClsSubject sub;
            while ((sub = ClsSubjectList.GetSubject(Console.ReadLine())) == null)
            {
                Console.Clear();
                Console.WriteLine("please write valid name");
                ClsSubjectList.Print();
            }

            return sub;
        }

        delegate bool myDel(out int t);
        private static void ReadNum(out int id, myDel cond, string mes = "")
        {
            while (cond.Invoke(out id))
            {
                Console.WriteLine(mes);
            }
        }

        static void Main(string[] args)
        {
            StartProgram();
            //ClsTrueFalse q1 = new("The square root of 25 is always 5", 2);
            //ClsChooseOne q2 = new("What is the value of 𝑥x in the equation 3𝑥+7=193x+7=19?", new Dictionary<int, string> { [1] = "4", [2] = "5", [3] = "6", [4] = "7" }, 1);
            //ClsChooseMultiple q3 = new("Which of the following numbers are prime", new Dictionary<int, string> { [1] = "17", [2] = "21", [3] = "23", [4] = "27", [5] = "31" }, 1, 3, 5);
            //ClsMath math = new("Math");
            //ClsEnglish english = new("English");
            //ClsSubjectList.Add(english);
            //math.Add(q1);
            //math.Add(q2);
            //math.Add(q3);
            //ClsStudent s1 = new("Hesham");
            //ClsStudent s2 = new("Karim");
            //math.AddStd(s1);
            //math.AddStd(s2);
            //ClsSubjectList.Add(math);
            //math.PrintQuestionList();
            //ClsSubjectList.Print();
            Console.ReadKey();
        }
    }
}
