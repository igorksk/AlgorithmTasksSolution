using System;
using System.Linq;

namespace PrimeNumberSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("{0} first prime numbers", n);
            
            var primeNumbers = PrimeNumbersHelpers.CreatePrimeNumbersSequence(n);

            if (primeNumbers.Count != 0)
            {
                foreach (var number in primeNumbers)
                {
                    Console.Write(number);
                    if (number != primeNumbers.Last())
                    {
                        Console.Write(", ");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
