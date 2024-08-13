using System.Diagnostics;

namespace RecursionLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(FibonacciRecursion(i));
            }

            Console.WriteLine("\n");

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(FibonacciCycle(i));
            }

            Console.WriteLine("\n");

            //#3
            Stopwatch stopWatch = new Stopwatch();

            stopWatch.Start();
            Console.WriteLine(FibonacciRecursion(5));
            stopWatch.Stop();
            Console.WriteLine($"RunTime of 5th element recursion figuring is {stopWatch.Elapsed}");
            stopWatch.Reset();

            stopWatch.Start();
            Console.WriteLine(FibonacciCycle(5));
            stopWatch.Stop();
            Console.WriteLine($"RunTime of 5th element cycle figuring is {stopWatch.Elapsed}");
            stopWatch.Reset();

            stopWatch.Start();
            Console.WriteLine(FibonacciRecursion(10));
            stopWatch.Stop();
            Console.WriteLine($"RunTime of 10th element recursion figuring is {stopWatch.Elapsed}");
            stopWatch.Reset();

            stopWatch.Start();
            Console.WriteLine(FibonacciCycle(10));
            stopWatch.Stop();
            Console.WriteLine($"RunTime of 10th element cycle figuring is {stopWatch.Elapsed}");
            stopWatch.Reset();

            stopWatch.Start();
            Console.WriteLine(FibonacciRecursion(20));
            stopWatch.Stop();
            Console.WriteLine($"RunTime of 20th element recursion figuring is {stopWatch.Elapsed}");
            stopWatch.Reset();

            stopWatch.Start();
            Console.WriteLine(FibonacciCycle(20));
            stopWatch.Stop();
            Console.WriteLine($"RunTime of 20th element cycle figuring is {stopWatch.Elapsed}");
            stopWatch.Reset();
        }

        //#1
        static int FibonacciRecursion(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return FibonacciRecursion(n-1) + FibonacciRecursion(n-2);
        }

        //#2
        static int FibonacciCycle(int n)
        {
            if (n == 1) return 1;

            var x0 = 0;
            var x1 = 1;
            var x = 0;

            for (var i = 0; i < (n - 1); i++)
            {
                x = x0 + x1;

                if (i % 2 == 0)
                {
                    x0 = x;
                }
                else
                {
                    x1 = x;
                }
            }

            return x;
        }
    }
}
