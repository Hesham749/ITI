namespace demo12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter number : ");
            int x = int.Parse(Console.ReadLine());
            int xrev = 0, mod;

            while (x != 0)
            {
                mod = (x % 10);
                xrev *= 10;
                xrev += mod;
                x = x / 10;
            }
            Console.WriteLine(xrev);
        }
    }
}
