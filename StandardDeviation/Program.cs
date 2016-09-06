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

        double standardDeviation = CalculateStandardDeviation(arr);

        Console.WriteLine(standardDeviation.ToString("F1"));

    }

    private static double CalculateStandardDeviation(int[] arr)
    {
        decimal mean = CalculateMean(arr);
        int length = arr.Length;
        double sumOfSquaredDistances = 0;
        foreach (int i in arr)
            sumOfSquaredDistances += Math.Pow(Convert.ToDouble(i - mean),2);

        return Math.Sqrt(sumOfSquaredDistances/length);
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

}