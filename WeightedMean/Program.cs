using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        string numberOfElements = Console.ReadLine();
        int n = Convert.ToInt32(numberOfElements);

        string elements = Console.ReadLine();
        string[] arr_temp = elements.Split(' ');
        int[] elementArray = Array.ConvertAll(arr_temp, Int32.Parse);

        string weights = Console.ReadLine();
        arr_temp = weights.Split(' ');
        int[] weightArray = Array.ConvertAll(arr_temp, Int32.Parse);

        if (elementArray.Length != n || weightArray.Length != n)
            return;

        Console.WriteLine(CalculateWeightedMean(elementArray, weightArray).ToString("F1"));

    }

    private static decimal CalculateWeightedMean(int[] values, int[] weights)
    {

        if (values.Length != weights.Length)
            return -1;

        int length = values.Length;

        if (length == 0)
            return 0;

        decimal sum = 0;
        decimal weightSum = 0;
        for (int i = 0; i < length; i++)
        {
            sum += values[i] * weights[i];
            weightSum += weights[i];
        }

        return Convert.ToDecimal(sum) / Convert.ToDecimal(weightSum);
    }
}