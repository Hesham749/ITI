namespace lab5.demo4
{
    internal class clsBankAccount
    {
        int _id;
        string _name;
        static private int IDs;
        public int Id
        {
            get { return _id; }
            set
            {
                if (value > Id)
                    _id = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value != "")
                    _name = value;
            }
        }

        public float Balance
        {
            get; private set;
        }


        public clsBankAccount(string name, float balance = 0)
        {
            IDs++;
            Balance = (balance > 0) ? balance : 0;
            _name = (name != null && name != "") ? name : "Unknown";
            Id = IDs;
        }


        public void Deposit(float amount)
        {
            if (amount > 0)
                Balance += amount;
        }

        public void Withdraw(float amount)
        {
            if (Balance > amount)
                Balance -= amount;
        }

        public void Print()
        {
            Console.WriteLine($"Acc ID : {Id,-2} , name : {Name,-6} , balance : {Balance}");
        }
    }
}
