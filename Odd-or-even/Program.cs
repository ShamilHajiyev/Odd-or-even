using System;

namespace Odd_or_even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("\nYour number is even");
            }
            else
            {
                Console.WriteLine("\nYour number is odd");
            }
        }
    }
}
