using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main()
        {
            static long Fibonacci(int n)
            {
                ArgumentOutOfRangeException.ThrowIfNegative(n);

                if (n == 0) return 0;

                long a = 0, b = 1;
                for (int i = 1; i < n; i++)
                {
                    long tmp = b;
                    b += a;
                    a = tmp;
                }

                return b;
            }

            for (int n = 0; n < 10; n++)
            {
                long fib = Fibonacci(n);

                Console.WriteLine($"{n + 1} Fibonacci number = {fib}");
            }

            Console.ReadLine();
        }
    }
}
