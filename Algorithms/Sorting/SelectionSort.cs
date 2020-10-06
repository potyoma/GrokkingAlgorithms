using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public static class SelectionSort
    {
        public static T[] Sort<T>(T[] array) where T : IComparable<T>
        {
            T[] sorted = new T[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                // Find the smallest element of the array.
                int smallest = FindSmallest(array);
                sorted[i] = array[smallest];

                // TODO: Find a way to pop the element uot of array. Or switch to List.

                array = Array
                    .FindAll(array, x => x.CompareTo(sorted[i]) != 0);
            }
            return sorted;
        }

        private static int FindSmallest<T>(T[] array) where T : IComparable<T>
        {
            // Storing the smallest element and its index.
            T smallest = array[0];
            int smallestIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(smallest) < 0)
                {
                    smallest = array[i];
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }
    }
}