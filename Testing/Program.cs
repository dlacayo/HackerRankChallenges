using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    class TestCase
    {

        public TestCase(int classSize, int minimumAttendance, int[] arrivalTimes)
        {
            Console.WriteLine($"{classSize} {minimumAttendance}");
            foreach (var v in arrivalTimes)
                Console.Write($"{v} ");
            Console.WriteLine("");

        }
    }
    static void Main(string[] args)
    {
        int numberOfTestCases = 5;
        Console.WriteLine(numberOfTestCases);
        TestCase fullAttendanceRequired_classCanceled = new TestCase(5, 5, new int[] { -1, -1, -1, 0, 1 });
        TestCase JustOneAbsenceAttendance_classNotCanceled = new TestCase(6, 5, new int[] { -1, -1, -1, -1, 0, 1 });
        TestCase justOneEarly_classNotCanceled = new TestCase(7, 2, new int[] { -1, 0, 1, 1, 1, 1, 1 });
        TestCase justOneEarly_classCanceled = new TestCase(7, 3, new int[] { -1, 0, 1, 1, 1, 1, 1 });
        TestCase justOneLate_classCanceled = new TestCase(7, 7, new int[] { -1, 0, 0, 0, 0, 0, 1 });
    }
}

