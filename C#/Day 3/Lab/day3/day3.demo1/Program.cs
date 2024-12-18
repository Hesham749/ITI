using System.Diagnostics;

namespace day3.max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            int[] arr = { 9, 3, 9, 8, 3, 10, 7 };
            int maxDistance = 0;
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
            #endregion
            // 2 
            #region 2
            sp.Start();
            maxDistance = GetMaxDistance(arr);
            sp.Stop();
            Console.WriteLine(sp.Elapsed);
            sp.Reset();
            Console.WriteLine($"max distance is {maxDistance}");
            #endregion
            // 3
            maxDistance = 0;
            sp.Start();
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = arr.Length - 1; j > i; j--)
                {

                    if (arr[i] == arr[j])
                    {
                        maxDistance = (j - i > maxDistance) ? (j - i) : maxDistance;
                        // because in that case j is the largest distance possible for that number
                        break;
                    }
                    if (maxDistance >= arr.Length)
                        break;
                    //bad practice
                    //if (i == j)
                    //    break;
                }
            }
            sp.Stop();
            Console.WriteLine(sp.Elapsed);
            sp.Reset();
            Console.WriteLine($"max distance is {maxDistance}");



        }

        private static int GetMaxDistance(int[] arr)
        {
            int maxDistance = 0;
            int[] freq = new int[arr.Max() + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                if (freq[arr[i]] == 0)
                    freq[arr[i]] = i + 1;
                if (i - (freq[arr[i]] - 1) > maxDistance)
                    maxDistance = i - (freq[arr[i]] - 1);
            }

            return maxDistance;
        }
    }
}
