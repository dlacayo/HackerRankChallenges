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

        Array.Sort(arr);

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

        decimal median = arr[length / 2];


        if (NumberOfElementsIsEven(length))
        {
            median += arr[(length / 2) - 1];
            median /= 2;
        }
        return median;

    }

    private static bool NumberOfElementsIsEven(int length)
    {
        return length % 2 == 0;
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