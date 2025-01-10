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
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("============================================");
            Console.WriteLine("           Welcome to Examination System     ");
            Console.WriteLine("============================================");
            Console.ResetColor();

            Console.Write("\nPlease enter your ID: ");
            ReadNum(out int Id, (out int x) => !int.TryParse(Console.ReadLine(), out x), "Please enter a valid number.");

            Console.WriteLine("\nAvailable Subjects:");
            ClsSubjectList.Print();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPlease type the subject name:");
            Console.ResetColor();
            ClsSubject sub = GetSubject();

            ClsStudent std = GetStudent(Id, sub);
            if (std == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nYou are not registered in any subject.");
                Console.ResetColor();
                return;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nWelcome {std.Name}! You are about to start the {sub.Name} exam.");
            Console.ResetColor();

            Console.WriteLine("\nPlease choose the exam type:");
            ClsColorText.ColorText("[1] - Final Exam\n[2] - Practice Exam", ConsoleColor.Yellow);
            ClsExam<ClsSubject> Exam = GetExam();

            Console.Clear();
            ClsColorText.ColorText($"Starting your {Exam.GetType().Name.Replace("Cls", "").Replace("Exam", "").ToLower()} exam...", ConsoleColor.Blue);
            Exam.StartExam(sub, std);
        }

        private static ClsExam<ClsSubject> GetExam()
        {
            ClsExam<ClsSubject> Exam;
            int examType;
            ReadNum(out examType, (out int x) => !int.TryParse(Console.ReadLine(), out x), "Please enter a valid choice.");
            Exam = (examType == 1) ? new ClsFinalExam() : new ClsPracticeExam();
            return Exam;
        }

        private static ClsStudent GetStudent(int Id, ClsSubject sub)
        {
            int attempts = 1;
            ClsStudent std;
            while ((std = sub.GetStudent(Id)) == null && attempts < ClsSubjectList.SubList.Count)
            {
                attempts++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nYou are not registered in {sub.Name}. Please choose another subject.");
                Console.ResetColor();

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
                ClsColorText.ColorText("\nInvalid subject name. Please try again.", ConsoleColor.Red);
                ClsSubjectList.Print();
            }
            return sub;
        }

        delegate bool myDel(out int t);
        private static void ReadNum(out int id, myDel cond, string message = "")
        {
            while (cond.Invoke(out id))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
            }
        }

        static void Main(string[] args)
        {
            StartProgram();

            // Uncomment these lines for testing purposes
            //ClsTrueFalse q1 = new("The square root of 25 is always 5", 2);
            //ClsChooseOne q2 = new("What is the value of x in the equation 3x+7=19?", new Dictionary<int, string> { [1] = "4", [2] = "5", [3] = "6", [4] = "7" }, 1);
            //ClsChooseMultiple q3 = new("Which of the following numbers are prime?", new Dictionary<int, string> { [1] = "17", [2] = "21", [3] = "23", [4] = "27", [5] = "31" }, 1, 3, 5);
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
            ClsColorText.ColorText("\nThank you for using the Examination System. Goodbye!", ConsoleColor.Cyan);
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
