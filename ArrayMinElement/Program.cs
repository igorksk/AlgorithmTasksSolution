using System;

namespace ArrayMinElement
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                try
                {
                    Console.Write("How many numbers do you want to store in array: ");
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] numbers = new int[n];

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Enter number {0}:  ", i + 1);
                        numbers[i] = Convert.ToInt32(Console.ReadLine());
                    }

                    int min = Helpers.GetMinElement(numbers);

                    Console.WriteLine("The minimum is: {0}", min);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
