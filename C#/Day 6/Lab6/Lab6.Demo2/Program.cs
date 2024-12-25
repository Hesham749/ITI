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
            if (!r1.SetDiminsion2(30))
                Console.WriteLine($"Rectangle Diminsion2 is set to : {r1.Diminsion2}");

            clsCircle C1 = new clsCircle(20);
            Console.WriteLine($"Circle Area is = {C1.GetArea()}");
            if (!C1.SetDiminsion1(-2))
                Console.WriteLine($"Circle R is set to : {C1.Diminsion2}");
            if (!C1.SetDiminsion2(-2))
                Console.WriteLine($"Circle R is set to : {C1.Diminsion1}");

            clsSquare s1 = new clsSquare(5);
            Console.WriteLine($"Square Area is = {s1.GetArea()}");
            if (!s1.SetDiminsion1(-2))
                Console.WriteLine($"Square Diminsion to : {s1.Diminsion2}");
            if (!s1.SetDiminsion2(-2))
                Console.WriteLine($"Square Diminsion to : {s1.Diminsion1}");
            s1.ShapeStatus();

        }
    }
}
