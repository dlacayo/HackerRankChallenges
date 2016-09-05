using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        string numberOfElements = Console.ReadLine();
        int n = Convert.ToInt32(numberOfElements);
        string elements = Console.ReadLine();
        string[] arr_temp = elements.Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

        if (arr.Length != n)
            return;

        Console.WriteLine(CalculateMean(arr));
        Console.WriteLine(CalculateMedian(arr));
        Console.WriteLine(CalculateMode(arr));

    }


    private static decimal CalculateMean(int[] arr)
    {
        int length = arr.Length;
        if (length == 0)
            return 0;

        decimal sum = 0;
        foreach (int i in arr)
            sum += i;
        return sum / length;
    }
    private static decimal CalculateMedian(int[] arr)
    {
        int length = arr.Length;
        if (length == 0)
            return 0;

        Array.Sort(arr);

        if (length % 2 == 0)
            return CalculateMedianForEvenArray(arr, length);
        else
            return CalculateMedianForOddArray(arr, length);
    }

    private static decimal CalculateMedianForOddArray(int[] arr, int length)
    {
        int index = Convert.ToInt32(Math.Floor((decimal)length / 2));
        return Convert.ToDecimal(arr[index]);
    }

    private static decimal CalculateMedianForEvenArray(int[] arr, int length)
    {
        int upperIndex = (length / 2);
        int lowerIndex = (length / 2) - 1;

        decimal median = (Convert.ToDecimal(arr[lowerIndex]) + Convert.ToDecimal(arr[upperIndex])) / 2;
        return median;
    }

    private static int CalculateMode(int[] arr)
    {
        int length = arr.Length;
        if (length == 0)
            return 0;

        Array.Sort(arr);

        int mode = arr.GroupBy(i => i).OrderByDescending(g => g.Count()).Select(g => g.Key).First();

        return mode;

    }
}