
namespace demo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter number : ");
            int x = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= x; i++)
            {
                factorial *= i;
            }
            Console.WriteLine($"factorial of num {x} is {factorial}");
        }
    }
}
