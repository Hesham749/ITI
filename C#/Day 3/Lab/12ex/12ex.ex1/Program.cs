
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
            int[,] nums = new int[20, 10];
            int current = 0;
            for (int i = 0; i < 20; i++)
            {

                for (int j = 0; j < 10; j++)
                {
                    current += num;
                    nums[i, j] = current;
                    Console.Write($"{nums[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
