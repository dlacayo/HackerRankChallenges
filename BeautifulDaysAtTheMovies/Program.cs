using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        string[] stringValues = Console.ReadLine().Split(' ');
        int[] values = Array.ConvertAll(stringValues, Int32.Parse);

        int beautifulDayCount = 0;
        for (int i = values[0]; i <= values[1]; i++)
        {
            int reversedValue = Convert.ToInt32(Reverse(i.ToString()));
            if ((i - reversedValue) % values[2] == 0)
                beautifulDayCount++;
        }

        Console.WriteLine(beautifulDayCount);
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}