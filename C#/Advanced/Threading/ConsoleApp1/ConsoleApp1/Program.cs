using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp1
{
    internal class Program
    {
      static void Mai4(string[] args)
        {
            Thread.Sleep(5000);
            Task<int> t1 = new (() => getnum(5));
            t1.Start();
            t1.Wait();
            int z = t1.Result;
            Console.WriteLine(z);
        }
      static int getnum(int i)
        {
               return i;
        }

      static  void Main5(string[] args)
        {
            Task t1 = new (method1);
            Task t2 = new (method2);
            t1.Start();
            t2.Start();
            t1.Wait();
            t2.Wait();
            Console.ReadKey();

        }
      static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(s => method1());
            ThreadPool.GetMaxThreads(out int x , out int y );
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine($"Thread main id = {Thread.CurrentThread.ManagedThreadId}:{Thread.CurrentThread.IsThreadPoolThread} : {Thread.CurrentThread.IsBackground}");
        }
      static void Main2(string[] args)
        {
            Thread t1 = new Thread(fun1);
            t1.Start();
            Thread t2 = new Thread(fun2);
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine();


        }
      static void fun1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("fun1");
                Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.White;

            }
        }
      static void fun2()
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("fun2");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.White;

                }
            }
      static void Main1(string[] args)
        {
            Console.WriteLine("main started");
            Console.WriteLine($"main started with id = {Thread.CurrentThread.ManagedThreadId}");

            Thread t1 = new Thread(method1);
            Thread t2 = new Thread(method2);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            t1.Start();
            t2.Start();
           t1.Join();
           t2.Join();
          // t1.IsBackground = true;
            Console.WriteLine("main end");
            stopwatch.Stop();
            Console.WriteLine($"The code run in time {stopwatch.Elapsed}");
        }

        static void method1()
        {
            Console.WriteLine("method1 started");
            //  Console.WriteLine($"method1 started with id = {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"Thread method1 id = {Thread.CurrentThread.ManagedThreadId}:{Thread.CurrentThread.IsThreadPoolThread} : {Thread.CurrentThread.IsBackground}");

            Thread.Sleep(5000);
            Console.WriteLine("method1 end");
        }

        static void method2()
        {
            Console.WriteLine("method2 started");
            Console.WriteLine($"method2 started with id = {Thread.CurrentThread.ManagedThreadId}");
            Thread.Sleep(5000);
            Console.WriteLine("method2 end");
        }
    }
}
