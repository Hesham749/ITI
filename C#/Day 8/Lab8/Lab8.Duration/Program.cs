namespace Lab8.Duration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsDuration d0 = new clsDuration(1, 30, 20);
            Console.WriteLine(d0);
            var d = new clsDuration(1, 10, 15);
            Console.WriteLine(d);
            var d1 = new clsDuration(3600);
            Console.WriteLine(d1);
            var d2 = new clsDuration(7800);
            Console.WriteLine(d2);
            var d3 = new clsDuration(666);
            Console.WriteLine(d3);
        }
    }
}
