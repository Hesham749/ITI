namespace Lab14.Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClsComplex c = new ClsComplex() { Real = 30, Img = 10 };
            Console.WriteLine(c[0]);
            Console.WriteLine(c[1]);
            c[1] = 5;
            Console.WriteLine(c[1]);
        }
    }
}
