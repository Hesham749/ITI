using System.Diagnostics;

namespace day3.max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 2, 8, 8, 8, 7 };
            int maxDistance = 0;
            int[] freq = new int[100];
            Stopwatch sp = new Stopwatch();

            //1
            sp.Start();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; arr.Length > j; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        if ((j - i) > maxDistance)
                        {
                            maxDistance = j - i;
                        }
                    }

                }
            }
            sp.Stop();
            Console.WriteLine(sp.Elapsed);
            sp.Reset();

            Console.WriteLine($"max distance is {maxDistance}");

            //2
            maxDistance = 0;
            sp.Start();
            for (int i = 0; i < arr.Length; i++)
            {
                if (freq[arr[i]] == 0)
                    freq[arr[i]] = i + 1;
                if (i - (freq[arr[i]] - 1) > maxDistance)
                    maxDistance = i - (freq[arr[i]] - 1);
            }
            sp.Stop();
            Console.WriteLine(sp.Elapsed);
            sp.Reset();
            Console.WriteLine($"max distance is {maxDistance}");

            // 3
            maxDistance = 0;
            sp.Start();
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = arr.Length - 1; j >= i; j--)
                {

                    if (arr[i] == arr[j])
                    {
                        if ((j - i) > maxDistance)
                        {
                            maxDistance = j - i;
                        }
                        // because in that case j is the largest distance possible for that number
                        break;
                    }
                }
            }
            sp.Stop();
            Console.WriteLine(sp.Elapsed);

            Console.WriteLine($"max distance is {maxDistance}");

        }
    }
}
