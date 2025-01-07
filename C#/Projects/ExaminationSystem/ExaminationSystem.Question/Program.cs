using ExaminationSystem.MidLayer;

namespace ExaminationSystem.UI
{
    internal class Program
    {


        static void StartExam()
        {
            Console.Write("Welcome Please enter your ID : ");
            ReadStdId(out int Id);




            Console.WriteLine("Please choose the exam type :");
            Console.WriteLine("=====================================");
            Console.Write("Final Exam (1) / Practice Exam (2) : ");

        }

        private static void ReadStdId(out int id)
        {
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("please insert only Numbers");
            }
        }

        static void Main(string[] args)
        {
            ClsSubjectList sl = ClsSubjectList.CreateSubList();
            sl.Add(new ClsSubject("Math"));
            sl.Add(new ClsSubject("English"));
            //StartExam();
            //var dc = new Dictionary<string, string>();
            //ClsQuestionList QList1 = new ClsQuestionList();
            //var q1 = new ClsQuestion(EnQuestionType.TrueFalse, "A student can only participate in events managed by their assigned department.\n(1: True, 2: False) ", new Dictionary<int, string>() { [1] = "True" });
            //var q2 = new ClsQuestion(EnQuestionType.TrueFalse, "A student’s MBTI personality type will always stay the same throughout their life.\n1: True  2: False", new Dictionary<int, string>() { [2] = "False" });
            //var q3 = new ClsQuestion(EnQuestionType.TrueFalse, "If a student over-clocks their RAM, it will always improve performance without any risk of instability.\n1: True  2: False", new Dictionary<int, string>() { [1] = "True" });
            //var q4 = new ClsQuestion(EnQuestionType.ChooseOne, "A student wants to join an event. What should determine their eligibility?\n1: Their department  2: Their GPA  3: Their age  4: Their attendance record", new Dictionary<int, string>() { [1] = "Their department" });
            //var q5 = new ClsQuestion(EnQuestionType.ChooseOne, "Which factor can cause instability when overclocking RAM?\n1: Increasing voltage too much  2: Using a powerful cooling system  3: Running default settings  4: Keeping timings loose", new Dictionary<int, string>() { [2] = "Using a powerful cooling system" });
            //var q6 = new ClsQuestion(EnQuestionType.ChooseOne, "What is a common criticism of the MBTI personality test?\n1: It is scientifically unreliable  2: It accurately predicts job performance  3: It measures intelligence  4: It never changes over time", new Dictionary<int, string>() { [4] = "It never changes over time" });
            //QList1.Add(q1);
            //QList1.Add(q2);
            //QList1.Add(q3);
            //QList1.Add(q4);
            //QList1.Add(q5);
            //QList1.Add(q6);
            //ClsQuestionList QList2 = new ClsQuestionList();
            //QList2.Add(q3);
            //QList1.PrintQuestionList();
            //QList2.PrintQuestionList();
            Console.ReadKey();
        }
    }
}
