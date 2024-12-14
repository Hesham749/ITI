namespace demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degree;
            Console.Write("please enter your grade :");
            degree = int.Parse(Console.ReadLine());
            if (degree >= 90)
                Console.WriteLine("excellent");
            else if (degree >= 80)
                Console.WriteLine("very good");
            else if (degree >= 70)
                Console.WriteLine("good");
            else if (degree >= 50)
                Console.WriteLine("passed");
            else
                Console.WriteLine("failed");




        }
    }
}
