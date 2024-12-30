namespace Lab8.Duration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClsDuration d0 = new ClsDuration(1, 62, 20);
            Console.WriteLine(d0);

            var d = new ClsDuration(1, 10, 15);
            Console.WriteLine(d);

            var d1 = new ClsDuration(3600);
            Console.WriteLine(d1);

            var d2 = new ClsDuration(7800);
            Console.WriteLine(d2);

            var d3 = new ClsDuration(666);
            Console.WriteLine(d3);

            d3 = d1 + 7800;
            Console.WriteLine(d3);

            d3 = 666 + d3;
            Console.WriteLine(d3);

            d3 = d1++;
            Console.WriteLine(d3);

            d3 = --d2;
            Console.WriteLine(d3);

            Console.WriteLine(d1 - d2);

            if (d1 > d2)
                Console.WriteLine($"{d1} > {d2}");

            if (d1 <= d2)
                Console.WriteLine($"{d1} <= {d2}");
        }
    }
}
