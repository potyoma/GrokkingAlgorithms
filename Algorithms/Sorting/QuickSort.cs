using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public static class QuickSort
    {
        /// <summary>
        /// The method sorts given array with Quick Sort algorithm.
        /// </summary>
        /// <param name="array">Array to sort.</param>
        /// <param name="start">First index (0).</param>
        /// <param name="end">Last index(array.Length - 1).</param>
        /// <typeparam name="T">T must extend IComparable.</typeparam>
        public static void Sort<T>(
            T[] array, int start, int end) where T : IComparable<T>
        {
            // Array < 2 (start == end) is a base case.
            if (start < end)
            {
                // Selecting subarrays.
                int partitionIndex = Partition(array, start, end);

                Sort(array, start, partitionIndex - 1);
                Sort(array, partitionIndex + 1, end);
            }
        }

        private static int Partition<T>(
            T[] array, int start, int end) where T : IComparable<T>
        {
            // Select a pivot point.
            T pivot = array[end];
            int startIndex = start - 1;

            // Split array in 2. Left <= pivot, right > pivot.
            for (int i = start; i < end; i++)
            {
                if (array[i].CompareTo(pivot) <= 0)
                {
                    startIndex++;

                    T temp = array[startIndex];
                    array[startIndex] = array[i];
                    array[i] = temp;
                }
            }

            T temp1 = array[startIndex+1];
            array[startIndex+1] = array[end];
            array[end] = temp1;
            
            return startIndex + 1;
        }
    }
}