namespace lab5.demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsBankAccount acc1 = new clsBankAccount("Ahmed");
            clsBankAccount acc2 = new clsBankAccount("Hesham", 10000);
            clsBankAccount acc3 = new clsBankAccount("Ezzat", -100);
            acc1.Withdraw(10000);
            //acc1.Deposit(1000);
            acc1.Print();
            acc2.Print();
            acc3.Print();
        }
    }
}
