using System;

namespace ArrayMinElement
{
    public static class Helpers
    {
        public static int GetMinElement(int[] numbers)
        {
            ArgumentNullException.ThrowIfNull(numbers);

            if (numbers.Length == 0)
                throw new ArgumentException("Array must contain at least one element.", nameof(numbers));

            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }
    }
}
