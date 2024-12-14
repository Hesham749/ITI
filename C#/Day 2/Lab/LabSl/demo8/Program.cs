namespace demo8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                Console.Clear();
                Console.WriteLine("new\nDisplay\nexit");
                Console.Write("write n , d or e : ");
                ch = char.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 'n':
                    case 'N':
                        Console.WriteLine("new selected");
                        break;
                    case 'd':
                    case 'D':
                        Console.WriteLine("display selected");
                        break;
                    case 'e':
                    case 'E':
                        Console.WriteLine("exit selected");
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
                Console.WriteLine("\npress enter to continue");
                Console.ReadLine();
            } while (ch != 'e' && ch != 'E');
        }
    }
}
