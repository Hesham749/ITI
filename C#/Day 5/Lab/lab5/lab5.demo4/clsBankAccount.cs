namespace lab5.demo4
{
    internal class clsBankAccount
    {
        int _id;
        string _name;

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
                if (value != null)
                    _name = value;
            }
        }

        public float Balance
        {
            get; private set;
        }

        private clsBankAccount()
        {
            _name = "No name";
            Balance = 1000;
        }


        public clsBankAccount(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }

        public clsBankAccount(int id, string name, float balance) : this(id, name)
        {
            Balance = balance;
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
