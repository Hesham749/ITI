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
            ClsQuestionList QList1 = new ClsQuestionList();

            var q1 = new ClsQuestion(EnQuestionType.TrueFalse, "hesham", 1);
            var q2 = new ClsQuestion(EnQuestionType.TrueFalse, "Gehad", 2);
            var q3 = new ClsQuestion(EnQuestionType.ChooseMultiple, "Ali", 1, 3);
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
