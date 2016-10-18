using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);

        BubbleSort(a,n);
    }

    private static void BubbleSort(int[] a, int n)
    {
        int totalSwapCount = 0;
        
        for (int i = 0; i < n; i++)
        {
            // Track number of elements swapped during a single array traversal
            int numberOfSwaps = 0;

            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    int swapVar = a[j+1];
                    a[j + 1] = a[j];
                    a[j] = swapVar;
                    numberOfSwaps++;
                }
            }

            totalSwapCount += numberOfSwaps;

            // If no elements were swapped during a traversal, array is sorted
            if (numberOfSwaps == 0)
            {
                break;
            }
        }

        PrintResults(totalSwapCount, a[0], a[n - 1]);
    }

    private static void PrintResults(int totalSwapCount, int firstElement, int lastElement)
    {
        Console.WriteLine($"Array is sorted in {totalSwapCount} swaps.");
        Console.WriteLine($"First Element: {firstElement}");
        Console.WriteLine($"Last Element: {lastElement}");
    }
}
