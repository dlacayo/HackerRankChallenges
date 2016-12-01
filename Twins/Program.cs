using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        string[] numbers = Console.ReadLine().Split(' ');
        int i = Convert.ToInt32(numbers[0]);
        int j = Convert.ToInt32(numbers[1]);

        List< int> primes = new List<int>();
        for (int k = i; k <= j; k++)
        {
            if (IsPrime(k))
                primes.Add(k);
        }

        int numberOfTwins = 0;
        for (int k = 0; k < primes.Count-1; k++)
        {
            if (Math.Abs(primes[k] - primes[k + 1]) == 2)
                numberOfTwins++;
        }

        Console.WriteLine(numberOfTwins);
    }

    private static bool IsPrime(int number)
    {
        if (number == 2)
            return true;
        int squareRoot = Convert.ToInt32(Math.Sqrt(number));
        if (number == 1 || (number & 1) == 0)
            return false;
        else
            for (int i = 3; i <= squareRoot; i += 2)
                if (number % i == 0)
                    return false;
        return true;
    }
}
