using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    static void Main(String[] args)
    {
        int size = Convert.ToInt32(Console.ReadLine());

        if(size <1)
            return;

        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] values = Array.ConvertAll(arr_temp, Int32.Parse);

        double positiveCount = 0;
        double negativeCount = 0;
        double zeroCount = 0;

        ProcessArray(values, out positiveCount, out negativeCount, out zeroCount);

        Console.WriteLine($"{positiveCount:F6}\n{negativeCount:F6}\n{zeroCount:F6}");
    }

    private static void ProcessArray(int[] values, out double positiveCount, out double negativeCount, out double zeroCount)
    {
        int size = values.Length;

        zeroCount = positiveCount = negativeCount = 0;

        foreach (int value in values)
        {
            if (value == 0)
                zeroCount++;
            else if (value > 0)
                positiveCount++;
            else
                negativeCount++;
        }

        zeroCount /= size;
        positiveCount /= size;
        negativeCount /= size;
    }
}