using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        string S = Console.ReadLine();
        int number = 0;
        try
        {
            number = Convert.ToInt32(S);
            Console.WriteLine(number);
        }
        catch (FormatException)
        {
            Console.WriteLine("Bad String");
        }
    }
}