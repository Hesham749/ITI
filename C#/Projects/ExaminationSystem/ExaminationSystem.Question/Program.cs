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
            ClsQuestionList QList1 = new ClsQuestionList(1);
            ClsQuestion q1 = new ClsChooseOne(1, "q1");
            ClsQuestion q2 = new ClsChooseOne(2, "q2");
            ClsQuestion q3 = new ClsChooseOne(3, "q3");
            QList1.Add(q1);
            QList1.Add(q2);
            QList1.Add(q3);
            //Console.ReadKey();
        }
    }
}
