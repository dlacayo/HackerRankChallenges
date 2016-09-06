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
        int[] elementsArray = Array.ConvertAll(arr_temp, Int32.Parse);

        string frequencies = Console.ReadLine();
        arr_temp = frequencies.Split(' ');
        int[] frequenciesArray = Array.ConvertAll(arr_temp, Int32.Parse);

        if (elementsArray.Length != n || frequenciesArray.Length != n)
            return;

        int[] constructedArray = ConstructArray(elementsArray, frequenciesArray);


        Array.Sort(constructedArray);

        int[] left;
        int[] right;

        SplitArray(constructedArray, out left, out right);


        decimal firstQuartile = CalculateMedian(left);
        decimal thirdQuartile = CalculateMedian(right);

        decimal interquartileRange = thirdQuartile-firstQuartile;

        Console.WriteLine(interquartileRange.ToString("F1"));

    }

    private static int[] ConstructArray(int[] elementsArray, int[] frequenciesArray)
    {
        List<int> result = new List<int>();

        if (elementsArray.Length != frequenciesArray.Length)
            return result.ToArray();

        int length = elementsArray.Length;
        for (int i = 0; i < length; i++)
            for (int j=0;j<frequenciesArray[i];j++)
                result.Add(elementsArray[i]);

        return result.ToArray();
    }

    private static void SplitArray(int[] source, out int[] left, out int[] right)
    {
        left = new int[] { };
        right = new int[] { };

        int length = source.Length;
        int half = length / 2;

        left = source.Take(half).ToArray();

        if (NumberOfElementsIsEven(length))
            right = source.Skip(half).ToArray();
        else
            right = source.Skip(half + 1).ToArray();


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
}
