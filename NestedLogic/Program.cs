using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int[] returnDateParts = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
        int[] dueDateParts = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);

        DateTime returnDate = new DateTime(returnDateParts[2], returnDateParts[1], returnDateParts[0]);
        DateTime dueDate = new DateTime(dueDateParts[2], dueDateParts[1], dueDateParts[0]);

        Console.WriteLine(CalculateFine(returnDate, dueDate));
    }

    private static int CalculateFine(DateTime returnDate, DateTime dueDate)
    {
        TimeSpan diff = dueDate - returnDate;

        if (diff.TotalSeconds >= 0) // returned before or on due date
            return 0;

        if (returnDate.Year > dueDate.Year)
            return 10000;

        if (dueDate.Month != returnDate.Month)
            return 500 * (returnDate.Month - dueDate.Month);

        return Math.Abs(15 * diff.Days);
    }
}