namespace _ex12.ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char again, op;
            string fMoney, sMoney, totalMoney;
            do
            {
                Console.Clear();
                Console.Write("Enter First amount: £");
                fMoney = Console.ReadLine();
                Console.Write("Enter second amount: £");
                sMoney = Console.ReadLine();
                Console.Write("Enter the operation (+ , - , *) : ");
                op = Console.ReadKey().KeyChar;
                Console.WriteLine();
                calc(fMoney, sMoney, op, out totalMoney);
                if (totalMoney != "")
                    Console.WriteLine($"Total is .£{totalMoney}");
                else
                    Console.WriteLine("You inserted wrong input");
                Console.Write("Do you want to continue (y/n)? ");
                again = Console.ReadKey().KeyChar;
            } while (again == 'y' || again == 'Y');
        }

        static void calc(string fMoney, string sMoney, char op, out string totaMoney)
        {
            switch (op)
            {
                case '+':
                    totaMoney = AddMoney(fMoney, sMoney);
                    break;
                case '-':
                    totaMoney = SubtractMoney(fMoney, sMoney);
                    break;
                case '*':
                    totaMoney = MultiplyMoney(fMoney, sMoney);
                    break;
                default:
                    totaMoney = "";
                    break;
            }
        }

        static void GetTotalInPence(string oldMoney, out int totalPence)
        {
            string[] sOldMoney = oldMoney.Split('.');
            totalPence = (int.Parse(sOldMoney[2]) + (int.Parse(sOldMoney[1]) * 12) + (int.Parse(sOldMoney[0]) * 12 * 20));
        }

        static string PenceToMoney(int totalPence)
        {
            string total = "";
            total += (totalPence / (20 * 12)).ToString() + '.';
            totalPence %= (20 * 12);
            total += (totalPence / 12).ToString() + '.';
            totalPence %= 12;
            total += totalPence.ToString();
            return total;
        }

        static string AddMoney(string m1, string m2)
        {
            int m1Total, m2Total, total;
            GetTotalInPence(m1, out m1Total);
            GetTotalInPence(m2, out m2Total);
            total = m1Total + m2Total;
            return PenceToMoney(total);
        }

        static string SubtractMoney(string m1, string m2)
        {
            int m1Total, m2Total, total;
            GetTotalInPence(m1, out m1Total);
            GetTotalInPence(m2, out m2Total);
            total = m1Total - m2Total;
            return PenceToMoney(total);
        }

        static string MultiplyMoney(string m1, string m2)
        {
            int m1Total, m2Total, total;
            GetTotalInPence(m1, out m1Total);
            GetTotalInPence(m2, out m2Total);
            total = m1Total * m2Total;
            return PenceToMoney(total);
        }
    }
}
