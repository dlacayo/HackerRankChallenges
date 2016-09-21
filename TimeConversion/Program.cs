using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string time = Console.ReadLine();
        Console.WriteLine(ConvertTimeToMilitary(time));
    }

    private static string ConvertTimeToMilitary(string time)
    {
        string lowerCaseString = time.ToLower();
        int hourFraction = Convert.ToInt32(time.Substring(0, 2));
        bool isItAmTime = (lowerCaseString[8] == 'a');
        if (isItAmTime)
            hourFraction = hourFraction == 12 ? 0: hourFraction;
        else
            hourFraction = hourFraction != 12 ? hourFraction + 12 : hourFraction;
        return $"{hourFraction:00}" + time.Substring(2, 6);
    }
}
