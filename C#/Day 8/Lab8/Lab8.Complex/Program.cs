namespace Lab8.Complex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsComplex c1 = new clsComplex(1, 4);
            clsComplex c2 = new clsComplex(1, 4);
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
            if (!(c3 is null))
            {
                Console.WriteLine(c3);
            }
            else
                Console.WriteLine("Ref to null");
            Console.WriteLine(++c3);

            c3 += c1;
            Console.WriteLine(c3);
        }
    }
}
