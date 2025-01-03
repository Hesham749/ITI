namespace ExaminationSystem.Ui
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
            StartExam();
            Console.ReadKey();
        }
    }
}
