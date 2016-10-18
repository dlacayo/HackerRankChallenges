using System;

public class Solution {
    static void Main(string[] args)
    {
        int[] vInt = new int[] { 1, 2, 3 };
        string[] vString = new string[] { "Hello", "World" };

        printArray<int>(vInt);
        printArray<string>(vString);
    }

    private static void printArray<T>(T[] array)
    {
        foreach (var v in array)
            Console.WriteLine(v);
    }
}