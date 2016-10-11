using System;
using System.Collections.Generic;
using System.IO;

class Solution
{
    static void Main(String[] args)
    {
        int numberOfSticks = Convert.ToInt32(Console.ReadLine());
        string[] s = Console.ReadLine().Split(' ');

        //Stream inputStream = Console.OpenStandardInput();
        //byte[] bytes = new byte[1536];    // 1.5kb
        //int outputLength = inputStream.Read(bytes, 0, 1536);
        //string[] s = System.Text.Encoding.UTF8.GetString(bytes).Split(' ');

        long[] sticks = Array.ConvertAll(s, Int64.Parse);

        MaximumPerimeterCalculator calculator = new MaximumPerimeterCalculator(numberOfSticks, sticks);
        Console.WriteLine(calculator.CalculateMaximumPerimeterTriangle());
    }

    class MaximumPerimeterCalculator
    {
        private int _numberOfSticks;
        private long[] _sticks;
        private string _answer;

        public MaximumPerimeterCalculator(int numberOfSticks, long[] sticks)
        {
            _numberOfSticks = numberOfSticks;
            _sticks = sticks;
            Array.Sort(sticks);
            _answer = "-1";
        }

        public string CalculateMaximumPerimeterTriangle()
        {
            for (int i = 0; i < _numberOfSticks - 2; i++)
                TestTriangle(_sticks[i], _sticks[i + 1], _sticks[i + 2]);

            return _answer;
        }

        private void TestTriangle(long i, long j, long k)
        {

            if (SticksMakeValidTriangle(i, j, k))
            {
                long perimeter = i + j + k;
                SetAnswer(i, j, k);
            }
        }

        private void SetAnswer(long s1, long s2, long s3)
        {
            _answer = $"{s1} {s2} {s3}";
        }

        private bool SticksMakeValidTriangle(long i, long j, long k)
        {
            return (i + j > k && i + k > j && j + k > i);
        }

    }


}
