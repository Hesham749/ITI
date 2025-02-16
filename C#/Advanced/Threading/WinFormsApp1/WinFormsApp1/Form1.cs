namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource _cts;
        public Form1()
        {
            InitializeComponent();
            _cts = new CancellationTokenSource();
        }
        public int CountPrimes(int n)
        {
            if (n <= 1) return 0;

            bool[] isPrime = new bool[n];
            for (int i = 2; i < n; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 2; i * i < n; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j < n; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (isPrime[i])
                {
                    count++;
                }
            }

            return count;
        }
        public async Task<int> CountPrimesAsync(int n, CancellationToken token)
        {
            return await Task.Run(() =>
            {
                if (n <= 1) return 0;

                bool[] isPrime = new bool[n];
                for (int i = 2; i < n; i++) isPrime[i] = true;

                for (int i = 2; i * i < n; i++)
                {
                    if (isPrime[i])
                    {
                        for (int j = i * i; j < n; j += i)
                        {
                            if (token.IsCancellationRequested) return -1;
                            isPrime[j] = false;
                        }
                    }
                }

                int count = 0;
                for (int i = 2; i < n; i++)
                {
                    if (isPrime[i])
                    {
                        if (token.IsCancellationRequested) return -1; 
                        count++;
                    }
                }

                return count;
            }, token);
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Text = "Btn Clicked ";
        }
        private async void Start_Click(object sender, EventArgs e)
            {
                
                if (_cts != null)
                {
                    _cts.Cancel(); 
                    await Task.Delay(1000); 
                }

                _cts = new CancellationTokenSource(); 
                Text = "Prime processing ...";

                try
                {
                    int x = await CountPrimesAsync(50, _cts.Token);
                    if (x == -1)
                        MessageBox.Show("Operation canceled.");
                    else
                        MessageBox.Show($"Count = {x}");
                }
                catch (OperationCanceledException)
                {
                    MessageBox.Show("Operation was canceled!");
                }
            }

        }
    }

