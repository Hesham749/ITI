namespace Lab13.Demo1
{
    internal class Program
    {
        static void StartGame()
        {
            var p1 = new ClsPlayer(1, "Hesham", new ClsPoint(1, 4), 10);
            var p2 = new ClsPlayer(2, "Gehad", new ClsPoint(-10, 4), 4);
            var p3 = new ClsPlayer(3, "Karim", new ClsPoint(1, -4), 6);
            var p4 = new ClsPlayer(4, "Mariam", new ClsPoint(20, -10), 0);
            var p5 = new ClsPlayer(5, "Ezzat", new ClsPoint(10, -30), 0);
            var b1 = new ClsBall(1);
            p1.PlayerIn(b1);
            p2.PlayerIn(b1);
            p3.PlayerIn(b1);
            p4.PlayerIn(b1);
            Console.WriteLine("=======================================================");
            Console.WriteLine(b1);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);
            Console.WriteLine("=======================================================");
            Console.WriteLine("=======================================================");
            b1.MoveBall(3, 5);
            Console.WriteLine(b1);
            Console.WriteLine("=======================================================");
            p3.PlayerOut(b1);
            p5.PlayerIn(b1);
            Console.WriteLine("=======================================================");
            b1.MoveBall(2, 0);
            Console.WriteLine(b1);
            Console.WriteLine("=======================================================");


        }
        static void Main(string[] args)
        {
            StartGame();
        }
    }
}
