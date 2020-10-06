using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class BinarySearch
    {
        /// <summary>
        /// The method returns index of given item in array. Returns -1 if not found.
        /// </summary>
        /// <param name="array">Array to search.</param>
        /// <param name="item">Object needed to find.</param>
        /// <typeparam name="T">Any type that extends IComparable.</typeparam>
        /// <returns>Integer containing index of item in array.</returns>
        public static int Search<T>(T[] array, T item) where T : IComparable<T>
        {
            // Edges of search area.
            int low = 0;  
            int high = array.Length - 1;

            while (low <= high)   // Runs until there is more than one element.
            {
                // Checking the element in the middle
                int mid = (low + high) / 2;
                T guess = array[mid];
                // Item found.
                if (guess.CompareTo(item) == 0)
                {
                    return mid;
                }
                // Item is more than middle element.
                if (guess.CompareTo(item) > 0)
                {
                    high = mid - 1;
                }
                // Item is less than middle element.
                else
                {
                    low = mid + 1;
                }
            }
            // Item is not in array.
            return -1;
        }
    }
}
