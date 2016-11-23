using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        string[] numbersAsStrings = Console.ReadLine().Split(' ');
        long[] numbers = Array.ConvertAll(numbersAsStrings, Int64.Parse);
        Array.Sort(numbers);

        long minSum = 0;
        for (int i = 0; i < numbers.Length - 1; i++)
            minSum += numbers[i];

        long maxSum = 0;
        for (int i = 1; i < numbers.Length; i++)
            maxSum += numbers[i];

        Console.WriteLine($"{minSum} {maxSum}");
    }
}