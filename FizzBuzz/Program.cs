using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main()
        {
            int n = 100;

            // Loop for 100 times
            for (int i = 1; i <= n; i++)
            {
                // Number divisible by 15(
                // divisible by both 3 & 5),
                // print 'FizzBuzz' in place
                // of the number
                if (i % 15 == 0)
                {
                    Console.Write("FizzBuzz" + " ");
                }
                
                // Number divisible by 3,
                // print 'Fizz' in place
                // of the number
                else if (i % 3 == 0)
                {
                    Console.Write("Fizz" + " ");
                }
                  
                // Number divisible by
                // 5, print 'Buzz'
                // in place of the number
                else if (i % 5 == 0)
                {
                    Console.Write("Buzz" + " ");
                }

                // Print the numbers
                else
                {
                    Console.Write(i + " ");
                }    
            }

            Console.ReadLine();
        }
    }
}
