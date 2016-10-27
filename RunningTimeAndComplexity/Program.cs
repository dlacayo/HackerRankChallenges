using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int numberOfTestCases = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < numberOfTestCases; i++)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }
    }

    private static string IsPrime(int number)
    {
        string prime = "Prime";
        string notPrime = "Not prime";

        if (number == 2)
            return prime;
        int squareRoot = Convert.ToInt32(Math.Sqrt(number));
        if (number == 1 || (number & 1) == 0)
            return notPrime;
        else
            for (int i = 3; i <= squareRoot; i += 2)
                if (number % i == 0)
                    return notPrime;
        return prime;
    }
}