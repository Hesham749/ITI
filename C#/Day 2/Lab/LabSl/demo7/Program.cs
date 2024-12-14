namespace demo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            do
            {
                Console.Write("please enter number :");
                sum += int.Parse(Console.ReadLine());
            } while (sum < 100);
            Console.WriteLine($"sum = {sum}");
        }


    }
}
