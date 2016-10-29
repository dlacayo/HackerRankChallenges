using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

class Solution
{


    static void Main(String[] args)
    {
        List<string> firstNames = new List<string>();

        int N = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < N; a0++)
        {
            string[] tokens_firstName = Console.ReadLine().Split(' ');
            string firstName = tokens_firstName[0];
            string emailID = tokens_firstName[1];

            if (Regex.Match(emailID, @"@gmail.com$").Success)
                firstNames.Add(firstName);
        }

        firstNames.Sort();

        foreach (var p in firstNames)
            Console.WriteLine(p);

    }
}
