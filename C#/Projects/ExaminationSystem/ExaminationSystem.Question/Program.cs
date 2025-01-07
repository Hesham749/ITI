using ExaminationSystem.MidLayer;

namespace ExaminationSystem.UI
{
    internal class Program
    {
        static void StartExam()
        {
            Console.WriteLine("Welcome Please choose the exam type :");
            Console.WriteLine("=====================================");
            Console.Write("Final Exam (1) / Practice Exam (2) : ");

        }
        static void Main(string[] args)
        {
            //StartExam();
            var dc = new Dictionary<string, string>();
            ClsQuestionList QList1 = new ClsQuestionList();
            var q1 = new ClsQuestion(EnQuestionType.TrueFalse, "A student can only participate in events managed by their assigned department.\n(1: True, 2: False) ", new Dictionary<int, string>() { [1] = "True" });
            var q2 = new ClsQuestion(EnQuestionType.TrueFalse, "A student’s MBTI personality type will always stay the same throughout their life.\n1: True  2: False", new Dictionary<int, string>() { [2] = "False" });
            var q3 = new ClsQuestion(EnQuestionType.ChooseMultiple, "If a student over-clocks their RAM, it will always improve performance without any risk of instability.\n1: True  2: False", new Dictionary<int, string>() { [1] = "True" });
            QList1.Add(q1);
            QList1.Add(q2);
            ClsQuestionList QList2 = new ClsQuestionList();
            QList2.Add(q3);
            QList1.PrintQuestionList();
            QList2.PrintQuestionList();

            Console.ReadKey();
        }
    }
}
