using System;
using System.Numerics;
using System.Collections.Generic;

namespace Algorithms.Searching
{
    // TODO: finish algo. Page 181.
    public static class DijkstrasAlgorithm
    {
        public static int Find(Dictionary<string, Dictionary<string, int>> graph)
        {
            var inf = Convert.ToInt32(Double.PositiveInfinity);
            var costs = new Dictionary<string, int>();
            foreach (var item in graph["start"])
            {
                costs.Add(item.Key, item.Value);
            }
            if (!costs.ContainsKey("finish"))
            {
                costs.Add("finish", inf);
            }

            var parents = new Dictionary<string, string>();
            foreach (var item in graph["start"])
            {
                parents.Add(item.Key, "start");
            }
            if (parents.ContainsKey("finish"))
            {
                parents["finish"] = null;
            }

            var processed = new List<string>();
        }
    }
}