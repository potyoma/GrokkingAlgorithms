using System;
using Algorithms;
using static System.Console;

// TODO: Implement xUnit testing instead of Console.Writeline!

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            TestBinarySearch();
        }

        static void TestBinarySearch()
        {
            int[] test1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] test2 = { "ant", "beer", "cat", "moon", "wolf" };
            char[] test3 = { 'a', 'b', 'c', 'd', 'e', 'f' };

            WriteLine(
                $"Right:     {Array.IndexOf(test1, 5)}\t{Array.IndexOf(test2, "cat")}\t{Array.IndexOf(test3, 'e')}");
            WriteLine(
                $"Algorithm: {BinarySearch.Search(test1, 5)}\t{BinarySearch.Search(test2, "cat")}\t{BinarySearch.Search(test3, 'e')}");
        }
    }
}
