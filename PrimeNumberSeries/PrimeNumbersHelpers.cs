
using System.Collections.Generic;

namespace PrimeNumberSeries
{
    public class PrimeNumbersHelpers
    {
        public static List<uint> CreatePrimeNumbersSequence(uint n)
        {
            var primeNumbers = new List<uint>();

            var count = 0u;
            var i = 0u;
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
            var result = true;

            if (n > 1)
            {
                for (var i = 2u; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
