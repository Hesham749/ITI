namespace Lab6.Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsTriangle t1 = new clsTriangle(10, 5);
            Console.WriteLine($"Triangle Area is = {t1.GetArea()}");
            if (!t1.SetDiminsion2(-2))
                Console.WriteLine($"Triangle diminsion2 is set to {t1.Diminsion2}");
            clsRectangle r1 = new clsRectangle(30, 50);
            Console.WriteLine($"Rectangle Area is = {r1.GetArea()}");
            r1.SetDiminsion2(30);
            Console.WriteLine($"Rectangle Diminsion2 is set to : {r1.Diminsion2}");
            clsCircle c1 = new clsCircle(20);
            Console.WriteLine($"Circle Area is = {c1.GetArea()}");
            c1.SetDiminsion(-1);
            Console.WriteLine($"Circle Diminsion2 is set to : {c1.Diminsion2}");
            clsSquare s1 = new clsSquare(40);
            Console.WriteLine($"Square Area is = {s1.GetArea()}");
            s1.SetDiminsion(-1);
            Console.WriteLine($"Square Diminsion2 is set to : {s1.Diminsion1}");

        }
    }
}
