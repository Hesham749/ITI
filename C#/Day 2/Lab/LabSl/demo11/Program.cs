namespace demo11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter character");
            char ch = char.Parse(Console.ReadLine());
            int chAsci = (int)ch;
            if (chAsci >= 65 && chAsci <= 90)
            {
                ch = (char)(chAsci + 32);
                Console.WriteLine(ch);

            }
            else if (chAsci >= 97 && chAsci <= 122)
            {
                ch = (char)(chAsci - 32);
                Console.WriteLine(ch);

            }
            else
                Console.WriteLine("invalid character");
        }
    }
}
