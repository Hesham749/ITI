namespace _12ex.ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number up to six digits");
            int num = 0;
            char digit;
            for (int i = 0; i < 6; i++)
            {
                digit = Console.ReadKey().KeyChar;
                if (!Char.IsDigit(digit))
                {
                    i--;
                    continue;
                }
                if (digit == 13)
                    break;
                num *= 10;
                num += (digit - 48);
            }
            Console.WriteLine();
            Console.WriteLine(num);
        }
    }
}
