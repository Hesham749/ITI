
namespace _12ex.ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenereteTableStartFromNum(7);
        }

        private static void GenereteTableStartFromNum(int num)
        {
            int current = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    current += num;
                    Console.Write($"{current,-4}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
