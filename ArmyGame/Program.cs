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

        int nDots = n/2;
        if (n%2 != 0)
            nDots++;

        int mDots = m/2;
        if (m%2 != 0)
            mDots++;
        
        Console.WriteLine(nDots*mDots);
    }
}
