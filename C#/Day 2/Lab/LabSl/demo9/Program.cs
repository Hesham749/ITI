namespace demo9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0 || x == 0)
                Console.WriteLine("number is even");
            else if (x % 2 != 0)
                Console.WriteLine("number id odd");
            else
                Console.WriteLine("invalid number");
        }
    }
}
