namespace Lab10.Demo1
{
    internal class Program
    {

        static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            int x = 5, y = 3;
            Console.WriteLine($"x = {x} , y = {y}");
            Swap(ref x, ref y);
            Console.WriteLine($"x = {x} , y = {y}");
        }
    }
}
