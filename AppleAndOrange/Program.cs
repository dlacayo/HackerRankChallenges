using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);
        int t = Convert.ToInt32(tokens_s[1]);
        string[] tokens_a = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(tokens_a[0]);
        int b = Convert.ToInt32(tokens_a[1]);
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] apple_temp = Console.ReadLine().Split(' ');
        int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
        string[] orange_temp = Console.ReadLine().Split(' ');
        int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);

        CalculateApplesAndOranges(s,t,a,b,m,n,apple,orange);
    }

    private static void CalculateApplesAndOranges(int s, int t, int a, int b, int m, int n, int[] apple, int[] orange)
    {
        int appleRangeStart = a + (s - a);
        int appleRangeEnd = a + (t - a);
        int orangeRangeStart = b - (b - s);
        int orangeRangeEnd = b - (b - t);

        int appleHitCount = 0;
        for (int i = 0; i < m; i++)
        {
            int appleHitCoordinate = a + apple[i];
            if (appleRangeStart <= appleHitCoordinate && appleHitCoordinate <= appleRangeEnd)
                appleHitCount++;
        }

        int orangeHitCount = 0;

        for (int i = 0; i < n; i++)
        {
            int orangeHitCoordinate = b + orange[i];
            if (orangeRangeStart <= orangeHitCoordinate && orangeHitCoordinate <= orangeRangeEnd)
                orangeHitCount++;
        }

        Console.WriteLine($"{appleHitCount}\n{orangeHitCount}");
    }
}
