namespace Lab6.Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            strComplex x1 = new strComplex();
            x1.Print();
            x1.Img = 100;
            x1.Print();
            strComplex x2 = new strComplex(1, -1);
            x2.Print();
            x2.SetComplex(5);
            x2.Print();
        }
    }
}
