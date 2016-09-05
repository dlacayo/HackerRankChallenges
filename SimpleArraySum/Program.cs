using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int SimpleArraySum(int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
            sum += n;
        return sum;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        Console.WriteLine(SimpleArraySum(arr));
    }
}
