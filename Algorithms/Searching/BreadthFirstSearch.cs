using System;
using System.Collections.Generic;

namespace Algorithms.Searching
{
    public static class BreadthFirstSearch
    {
        public static bool Search<T>(
            Dictionary<T, T[]> graph, T start, Func<T, bool> condition) 
            where T : IComparable<T>
        {
            var searchQueue = new Queue<T[]>();
            searchQueue.Enqueue(graph[start]);
            List<T> searched = new List<T>();

            while (searchQueue.Count > 0)
            {
                T[] item = searchQueue.Dequeue();
                foreach (T value in item)                
                {
                    if (!searched.Contains(value))
                    {
                        if (condition(value))
                        {
                            return true;
                        }
                        searchQueue.Enqueue(graph[value]);
                        searched.Add(value);
                    }
                }
            }

            return false;
        }
    }
}