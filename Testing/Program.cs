using System;
using System.Collections.Generic;
using Algorithms.Searching;
using Algorithms.Sorting;
using static System.Console;

// TODO: Implement xUnit testing instead of Console.Writeline!

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            // TestBinarySearch();
            // TestSelectionSort();
            // TestQuickSort();
            // TestBreadthFirstSearch();
            TestDijkstrasAlgorithm();
        }

        static void TestBinarySearch()
        {
            int[] test1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] test2 = { "ant", "beer", "cat", "moon", "wolf" };
            char[] test3 = { 'a', 'b', 'c', 'd', 'e', 'f' };

            WriteLine(
                $"Right:     {Array.IndexOf(test1, 5)}\t{Array.IndexOf(test2, "cat")}\t{Array.IndexOf(test3, 'e')}");
            WriteLine(
                $"Algorithm: {BinarySearch.Find(test1, 5)}\t{BinarySearch.Find(test2, "cat")}\t{BinarySearch.Find(test3, 'e')}");
        }

        static void TestSelectionSort()
        {
            List<int> test1 = new List<int>() { 12, 40, 5, 6, 1, 0, 100, 2 };
            List<int> sorted = SelectionSort.Sort(test1);

            int[] test2 = { 12, 40, 5, 6, 1, 0, 100, 2 };

            SelectionSort.Sort(test2);

            PrintArrayOrList(sorted);
            PrintArrayOrList(test2);
        }

        static void TestQuickSort()
        {
            int[] test1 = { 72, 12, 6, 33, 81, 97, 37, 59, 52, 1, 20 };
            char[] test2 = { 'z', 'y', 'a', 'b', 'q', 'k', 'l' };

            QuickSort.Sort(test1, 0, test1.Length - 1);
            QuickSort.Sort(test2, 0, test2.Length - 1);

            PrintArrayOrList(test1);
            PrintArrayOrList(test2);
        }

        static void TestBreadthFirstSearch()
        {
            var test1 = new Dictionary<string, string[]>()
            {
                { "you", new string[] { "alice", "bob", "claire" } },
                { "bob", new string[] { "anuj", "peggy" } },
                { "alice", new string[] { "peggy" } },
                { "claire", new string[] { "thom", "jonny" } },
                { "anuj", new string[0] },
                { "peggy", new string[0] },
                { "thom", new string[0] },
                { "jonny", new string[0] }
            };
            
            bool result = BreadthFirstSearch
                .Find(test1, "you", PersonIsSeller);
            Write($"{result}\n");
        }

        static void TestDijkstrasAlgorithm()
        {
            var test1 = new Dictionary<string, Dictionary<string, int>>()
            {
                { "start", new Dictionary<string, int>() 
                            { 
                                { "a", 6 },
                                { "b", 2 }
                            } },
                { "a", new Dictionary<string, int>() 
                            { 
                                { "finish", 1 }
                            } },
                { "b", new Dictionary<string, int>()
                            { 
                                { "a", 3 },
                                { "finish", 5}
                            } },
                { "finish", new Dictionary<string, int>() }
            };
        }

        static void PrintArrayOrList<T>(IEnumerable<T> arr)
        {
            foreach (T item in arr)
            {
                Write($"{item}  ");
            }
            WriteLine();
        }

        static bool PersonIsSeller(string name)
        {
            return name[name.Length - 1] == 'm';
        }
    }
}
