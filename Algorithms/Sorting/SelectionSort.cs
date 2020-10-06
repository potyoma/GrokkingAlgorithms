using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public static class SelectionSort
    {
        /// <summary>
        /// Selection sort algorithm for List.
        /// </summary>
        /// <param name="arr"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> Sort<T>(List<T> arr) where T : IComparable<T>
        {
            List<T> sorted = new List<T>();
            while (arr.Count > 0)
            {
                // Find the smallest element of the array.
                int smallest = FindSmallest(arr);
                sorted.Add(arr[smallest]);
                arr.RemoveAt(smallest);
            }
            return sorted;
        }

        public static void Sort<T>(T[] arr) where T : IComparable<T>
        {
            T[] sorted = new T[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int smallest = FindSmallest(arr, i);
                T temp = arr[i];
                arr[i] = arr[smallest];
                arr[smallest] = temp;
            }
        }

        private static int FindSmallest<T>(T[] arr, int start) where T : IComparable<T>
        {
            // Storing the smallest element and its index.
            T smallest = arr[start];
            int smallestIndex = start;

            for (int i = start+1; i < arr.Length; i++)
            {
                if (arr[i].CompareTo(smallest) < 0)
                {
                    smallest = arr[i];
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }

        private static int FindSmallest<T>(List<T> arr) where T : IComparable<T>
        {
            // Storing the smallest element and its index.
            T smallest = arr[0];
            int smallestIndex = 0;

            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i].CompareTo(smallest) < 0)
                {
                    smallest = arr[i];
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }
    }
}