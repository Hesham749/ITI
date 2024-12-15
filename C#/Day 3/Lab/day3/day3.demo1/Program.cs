using System.Diagnostics;

namespace day3.max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 3, 4, 3, 5, 7 };
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

            Console.WriteLine($"max distance is {maxDistance}");

            //2
            sp.Start();
            for (int i = 0; i < arr.Length; i++)
            {
                if (freq[arr[i]] == 0)
                    freq[arr[i]] = i + 1;
                if (i - (freq[arr[i]] - 1) > maxDistance && freq[arr[i]] != 0)
                    maxDistance = i - (freq[arr[i]] - 1);
            }
            sp.Stop();
            Console.WriteLine(sp.Elapsed);
            Console.WriteLine($"max distance is {maxDistance}");

            // 3
            sp.Start();
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = arr.Length - 1; j >= 0; j--)
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

            Console.WriteLine($"max distance is {maxDistance}");

        }
    }
}
