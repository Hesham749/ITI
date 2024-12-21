namespace lab5.demo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsComplex x1 = new clsComplex(1, -2);
            x1.Print();
            x1.Img = 100;
            x1.Print();
        }
    }
}
