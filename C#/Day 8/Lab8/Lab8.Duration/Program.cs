namespace Lab8.Duration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsDuration d0 = new clsDuration(1, 62, 20);
            Console.WriteLine(d0);

            var d = new clsDuration(1, 10, 15);
            Console.WriteLine(d);

            var d1 = new clsDuration(3600);
            Console.WriteLine(d1);

            var d2 = new clsDuration(7800);
            Console.WriteLine(d2);

            var d3 = new clsDuration(666);
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
