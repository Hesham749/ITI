namespace Lab13.Demo1
{
    internal class Program
    {
        static void StartGame()
        {
            var p1 = new ClsPlayer(1, "Hesham", new ClsPoint(1, 4), 10);
            var p2 = new ClsPlayer(2, "Gehad", new ClsPoint(1, 4), 4);
            var p3 = new ClsPlayer(3, "Karim", new ClsPoint(1, 4), 0);
            var b1 = new ClsBall(1);
            p1.PlayerIn(b1);
            Console.WriteLine(p1);
            Console.WriteLine(b1);
            b1.MoveBall(3, 5);

        }
        static void Main(string[] args)
        {
            StartGame();
        }
    }
}
