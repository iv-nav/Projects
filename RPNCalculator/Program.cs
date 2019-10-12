using System;

namespace RPNCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double result = RPN.Calculate(Console.ReadLine());
                Console.WriteLine(result.ToString());
            }

        }
    }
}
