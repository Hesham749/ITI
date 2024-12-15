using System.Diagnostics;

namespace day3.million
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            // 1
            int num = 1000000;
            int counter = 0;
            string temp = "";
            sw.Start();
            for (int i = 0; i <= num; i++)
            {
                temp = i.ToString();
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] == '1')
                        counter++;
                }
            }
            Console.WriteLine(counter);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            //2
            sw.Start();

            counter = 2;
            int remainder, mod;
            for (int i = 11; i <= num; i++)
            {
                remainder = i;
                while (remainder > 0)
                {
                    mod = remainder % 10;
                    if (mod == 1)
                    {
                        counter++;
                    }
                    remainder = remainder / 10;
                }

            }
            Console.WriteLine(counter);
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            //3
            //sw.Start();
            //counter = 0;
            //for (int i = 1; i <= num; i *= 10)
            //{
            //    int divider = i * 10;
            //    counter += (num / divider) * i + Math.Min(Math.Max(num % divider - i + 1, 0), i);
            //}
            //Console.WriteLine(counter);
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed);
        }
    }
}

