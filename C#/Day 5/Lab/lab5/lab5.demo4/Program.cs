namespace lab5.demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsBankAccount acc1 = new clsBankAccount(1, "Ahmed");
            clsBankAccount acc2 = new clsBankAccount(2, "Hesham", 4000);
            acc1.Deposit(1000);
            acc1.Withdraw(10000);
            acc1.Print();
            acc2.Print();
        }
    }
}
