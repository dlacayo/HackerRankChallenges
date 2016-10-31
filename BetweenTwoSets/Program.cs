using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp, Int32.Parse);
        string[] b_temp = Console.ReadLine().Split(' ');
        int[] b = Array.ConvertAll(b_temp, Int32.Parse);

        Array.Sort(a);
        Array.Sort(b);

        int rangeStart = a[n - 1];
        int rangeEnd = b[0];

        int count = 0;
        for(int i = rangeStart;i<= rangeEnd; i++)
        {
            bool numberQualifies = true;
            foreach (var ai in a)
                if (i % ai != 0)
                    numberQualifies = false;
            foreach (var bi in b)
                if (bi % i != 0)
                    numberQualifies = false;
            if(numberQualifies)
                count++;
        }
        Console.WriteLine(count);
    }
}
