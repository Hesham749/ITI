namespace _12ex.ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOFXBesideCenter = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    if (j >= (20 - numberOFXBesideCenter) && j <= (20 + numberOFXBesideCenter))
                        Console.Write("X");
                    else
                        Console.Write(" ");
                }
                numberOFXBesideCenter ++;
                Console.WriteLine();
            }
        }
    }
}
