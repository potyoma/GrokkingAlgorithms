using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public static class QuickSort
    {
        public static void Sort<T>(
            T[] array, int start, int end) where T : IComparable<T>
        {
            if (start < end)
            {
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