using System;
using System.Collections.Generic;

namespace PrimeNumberSeries
{
    public static class PrimeNumbersHelpers
    {
        public static List<uint> CreatePrimeNumbersSequence(uint n)
        {
            var primeNumbers = new List<uint>();

            if (n == 0) return primeNumbers;

            var count = 0u;
            var i = 2u; // start from 2, the first prime
            while (count < n)
            {
                if (IsPrimeNumber(i))
                {
                    primeNumbers.Add(i);
                    count++;
                }
                i++;
            }

            return primeNumbers;
        }

        public static bool IsPrimeNumber(uint n)
        {
            if (n < 2) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            var boundary = (uint)Math.Floor(Math.Sqrt(n));

            for (var i = 3u; i <= boundary; i += 2u)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
