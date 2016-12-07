using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

class Solution
{

    static void Main(String[] args)
    {
        string s = Console.ReadLine();
        long n = Convert.ToInt64(Console.ReadLine());

        long sLength = s.Length;

        long numberOfAs = GetNumberOfA(s);

        numberOfAs *= n/sLength;
        long remainder = n%sLength;
        numberOfAs += GetNumberOfA(s.Substring(0, (int)remainder));

        Console.WriteLine(numberOfAs);

    }

    private static int GetNumberOfA(string s)
    {
        int n = 0;
        foreach (var c in s)
            if (c == 'a')
                n++;
        return n;
    }
}
