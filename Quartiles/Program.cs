using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        string numberOfElements = Console.ReadLine();
        int n = Convert.ToInt32(numberOfElements);
        string elements = Console.ReadLine();
        string[] arr_temp = elements.Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

        if (arr.Length != n)
            return;

        Array.Sort(arr);
        int[] left;
        int[] right;

        SplitArray(arr, out left, out right);


        int firstQuartile = CalculateMedian(left);
        int secondQuartile = CalculateMedian(arr);
        int thirdQuartile = CalculateMedian(right);

        Console.WriteLine($"{firstQuartile}\n{secondQuartile}\n{thirdQuartile}");

    }

    private static void SplitArray(int[] source, out int[] left, out int[] right)
    {
        left = new int[] {};
        right = new int[] {};

        int length = source.Length;
        int half = length/2;

        left = source.Take(half).ToArray();

        if (NumberOfElementsIsEven(length))
            right = source.Skip(half).ToArray();
        else
            right = source.Skip(half + 1).ToArray();


    }


    private static int CalculateMedian(int[] arr)
    {
        int length = arr.Length;

        int median = arr[length/2];


        if (NumberOfElementsIsEven(length))
        {
            median += arr[(length/2) - 1];
            median /= 2;
        }
        return median;
    }

    private static bool NumberOfElementsIsEven(int length)
    {
        return length%2 == 0;
    }
}
