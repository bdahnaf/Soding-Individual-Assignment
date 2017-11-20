using System;

namespace SodingIndividualAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 1;
            int thirdNumber = 0;
            int sum = 0;
            int i = 0;
            Console.Write("Even Fibonacci Series under four million(4000000)");
            while (thirdNumber < 4000000)
            {
                thirdNumber = firstNumber + secondNumber;
                if (thirdNumber % 2 == 0)
                {
                    Console.Write(thirdNumber + " ");
                    sum = sum + thirdNumber;
                }
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                i++;
            }
            Console.WriteLine();
            Console.WriteLine("Summation of the series=" + sum);
            Console.ReadKey();
        }
    }
}
