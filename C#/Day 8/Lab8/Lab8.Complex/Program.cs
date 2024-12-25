namespace Lab8.Complex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsComplex c1 = new clsComplex();
            clsComplex c2 = new clsComplex();
            c1 = null;
            if (!(c1 is null))
            {
                if (c1.Equals(c2))
                    Console.WriteLine("Equals");
                else
                    Console.WriteLine("Not equals");
            }
            else
                Console.WriteLine("Ref to null");

        }
    }
}
