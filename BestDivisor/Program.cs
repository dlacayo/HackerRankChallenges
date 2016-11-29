using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());

        int bestDivisor = 1;
        int bestDivisorValue = 1;
        for (int i = 2; i <= number; i++)
        {
            int thisDivisorValue = GetDivisorValue(i);
            if (number%i == 0 && (bestDivisorValue < thisDivisorValue))
            {
                bestDivisorValue = thisDivisorValue;
                bestDivisor = i;
            }
        }
        Console.WriteLine(bestDivisor);
    }

    private static int GetDivisorValue(int i)
    {
        int sum = 0;
        string s = i.ToString();
        foreach (char c in s)
        {
            sum += Convert.ToInt32(c.ToString());
        }

        if (sum < 10)
            return sum;
        else return GetDivisorValue(sum);
    }
}
