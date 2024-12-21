namespace lab5.demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount(1, "Ahmed");
            BankAccount acc2 = new BankAccount(2, "Hesham", 4000);
            acc1.Deposit(1000);
            acc1.Withdraw(10000);
            acc1.print();
            acc2.print();
        }
    }
}
