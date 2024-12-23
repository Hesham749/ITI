namespace Lab6.Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsTriangle t1 = new clsTriangle(10, 5);
            Console.WriteLine($"Triangle Area is = {t1.CalcArea()}");
            if (!t1.SetDiminsion2(-2))
                Console.WriteLine($"diminsion2 is set to {t1.Diminsion2}");
        }
    }
}
