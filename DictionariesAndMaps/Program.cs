using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int numberOfEntries = Convert.ToInt32(Console.ReadLine());

        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        for (int i = 0; i < numberOfEntries; i++)
        {
            string[] d = Console.ReadLine().Split(' ');
            phoneBook.Add(d[0],d[1]);
        }

        string key = Console.ReadLine();
        while (!string.IsNullOrEmpty(key))
        {
            string value = "";

            if (phoneBook.TryGetValue(key, out value))
                Console.WriteLine($"{key}={value}");
            else
                Console.WriteLine("Not found");

            key = Console.ReadLine();
        }

    }
}