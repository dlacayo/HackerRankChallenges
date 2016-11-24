using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '),Int32.Parse);

        if (numbers.Length != n)
        {
            Console.WriteLine("NO");
        }
        else
        {
            Array.Sort(numbers);
            bool repeatedElementsPresent = false;
            for (int i = 0; i < numbers.Length-1; i++)
                if (numbers[i] == numbers[i + 1])
                {
                    repeatedElementsPresent = true;
                    break;
                }

            Console.WriteLine(repeatedElementsPresent ? "NO" : "YES");
        }
        
    }
}