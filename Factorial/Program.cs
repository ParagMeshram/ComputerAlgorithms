namespace Factorial
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            const int number = 25;
            Console.WriteLine(Factorial(number));
            Console.ReadKey();
        }

        private static long Factorial(long number)
        {
            if (number == 0) return 1;

            return number * Factorial(number - 1);
        }
    }
}
