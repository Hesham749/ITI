namespace lab5.demo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsComplex x1 = new clsComplex();
            x1.Print();
            x1.Img = 100;
            x1.Print();
            clsComplex x2 = new clsComplex(1, -1);
            x2.Print();
            x2.SetComplex(5);
            x2.Print();
            Console.WriteLine(clsComplex.Counter);
        }
    }
}
