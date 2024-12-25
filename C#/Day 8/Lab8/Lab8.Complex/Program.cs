namespace Lab8.Complex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsComplex c1 = new clsComplex(0, 1);
            clsComplex c2 = new clsComplex(3, 0);

            //c1 = null;

            if (!(c1 is null))
            {
                if (c1.Equals(c2))
                    Console.WriteLine("Equals");
                else
                    Console.WriteLine("Not equals");
            }
            else
                Console.WriteLine("Ref to null");

            clsComplex c3 = c1 + c2;
            if (!(c3 == null))
            {
                Console.WriteLine(c3);
            }
            else
                Console.WriteLine("Ref to null");
            Console.WriteLine(++c3);

            c3 += c1;
            Console.WriteLine(c3);

            c3 -= c1;
            Console.WriteLine(c3);

            c3--;
            Console.WriteLine(c3);

            c1 *= c2;
            Console.WriteLine(c1);

            c1 = c1 / c2;
            Console.WriteLine(c1); // return null

            c2 += 2;
            Console.WriteLine(c2); //5

            Console.WriteLine(2 + c2); //7

            c2 *= 2;
            Console.WriteLine(c2); //10

            double x = (double)c2;
            Console.WriteLine(x); // 10

            c2 = 40;
            Console.WriteLine(c2); // 40

            c3 -= c1;
            Console.WriteLine(c3);


        }
    }
}
