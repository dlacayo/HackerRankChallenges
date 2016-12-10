using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] A_temp = Console.ReadLine().Split(' ');
        int[] A = Array.ConvertAll(A_temp, Int32.Parse);

        int minimumDistance = -1;

        for(int i=0;i<n-1;i++)
            for (int j = i + 1; j < n; j++)
                if (A[i] == A[j])
                {
                    int distance = j - i;
                    if (minimumDistance == -1)
                        minimumDistance = distance;
                    if (j - i < minimumDistance)
                        minimumDistance = distance;
                }
        Console.WriteLine(minimumDistance);

    }
}
