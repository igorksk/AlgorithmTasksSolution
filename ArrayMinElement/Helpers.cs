namespace ArrayMinElement
{
    public class Helpers
    {
        public static int GetMinElement(int[] numbers)
        {
            int min = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }

            return min;
        }
    }
}
