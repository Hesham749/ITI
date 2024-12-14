namespace demo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"enter num{i + 1} : ");
                x = int.Parse(Console.ReadLine());
                sum += x;
            }
            Console.WriteLine($"sum = {sum}");
        }
    }
}
