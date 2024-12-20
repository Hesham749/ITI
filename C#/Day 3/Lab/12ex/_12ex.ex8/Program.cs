namespace _12ex.ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char again;
            string first, second, total;
            do
            {
                Console.Clear();
                Console.Write("Enter First amount: £");
                first = Console.ReadLine();
                Console.Write("Enter second amount: £");
                second = Console.ReadLine();
                string[] fSplit = first.Split('.');
                string[] sSplit = second.Split('.');
                string[] sTotal = new string[3];
                #region DiffMethod
                //int sum;
                //for (int i = 2; i >= 0; i--)
                //{
                //    sum = int.Parse(fSplit[i]) + int.Parse(sSplit[i]);
                //    if (i == 2)
                //    {
                //        if (sum > 11)
                //        {
                //            fSplit[1] = (int.Parse(fSplit[1]) + (sum / 12)).ToString();
                //            sum %= 12;
                //        }
                //    }
                //    else if (i == 1)
                //    {
                //        if (sum > 19)
                //        {
                //            fSplit[0] = (int.Parse(fSplit[0]) + (sum / 20)).ToString();
                //            sum %= 20;
                //        }
                //    }
                //    sTotal[i] = sum.ToString();
                //}
                //total = string.Join('.', sTotal);
                #endregion
                total = AddMoney(first, second);
                Console.WriteLine($"Total is £{total}");
                Console.Write("Do you want to continue (y/n)? ");
                again = Console.ReadKey().KeyChar;
            } while (again == 'y' || again == 'Y');
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
    }
}
