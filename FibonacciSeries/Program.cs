using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            static int Fibonacci(int n)
            {
                if (n == 0 || n == 1) return n;

                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

            for (int n = 0; n < 10; n++)
            {
                int fib = Fibonacci(n);

                Console.WriteLine($"{n + 1} Fibonacci number = {fib}");
            }

            Console.ReadLine();
        }
    }
}
