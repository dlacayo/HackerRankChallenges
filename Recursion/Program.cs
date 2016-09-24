using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Factorial(number));
    }

    private static long Factorial(int number)
    {
        if (number <= 0)
            return 1;
        return number*Factorial(number - 1);
    }
}