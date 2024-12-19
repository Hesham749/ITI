namespace _12ex.ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, factorial;
            char again;

            do
            {
                Console.Clear();
                factorial = 1;
                Console.WriteLine("please enter number to calculate its factorial");
                num = int.Parse(Console.ReadLine());
                for (int i = 2; i <= num; i++)
                    factorial *= i;
                Console.WriteLine($"factorial = {factorial}");
                Console.Write("press any key to continue or press 0 to exit : ");
                again = Console.ReadKey().KeyChar;
            } while (again != '0');
        }
    }
}
