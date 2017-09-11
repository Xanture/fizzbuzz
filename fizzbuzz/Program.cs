using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var userInput = Convert.ToInt32(Console.ReadLine());
            if (userInput % 3 == 0 && userInput % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
                return;
            }
            if (userInput % 3 == 0)
            {
                Console.WriteLine("Fizz");
                return;
            }
            if (userInput % 5 == 0)
            {
                Console.WriteLine("Buzz");
                return;
            }
            else
            {
                Console.WriteLine(userInput);
                return;
            }
        }
    }
}
