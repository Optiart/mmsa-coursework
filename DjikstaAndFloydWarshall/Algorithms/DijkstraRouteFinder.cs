using System.Collections.Generic;

namespace DjikstaAndFloydWarshall
{
    public class DijkstraRouteFinder : IFastestRouteFinder
    {
        public Result Find(int[,] graph, int s, int t)
        {
            const long inf = long.MaxValue;
            var vertexCount = graph.GetLength(0);
            var d = new long[vertexCount];
            var visited = new bool[vertexCount];

            var minPQ = new SimpleMinimumPriorityQueue();
            minPQ.UpdatePriority((s, 0));
            var prev = new int[vertexCount];

            for (int i = 0; i < prev.Length; i++)
            {
                prev[i] = -1;
            }

            for (int i = 0; i < d.Length; i++)
            {
                d[i] = i == s ? 0 : inf;
            }

            while (!minPQ.IsEmpty)
            {
                var (index, _) = minPQ.ExtractMin();
                visited[index] = true;

                if (index == t)
                {
                    break;
                }

                for (int v = 0; v < vertexCount; v++)
                {
                    if (graph[index, v] != -1 && !visited[v])
                    {
                        var newDistance = d[index] + graph[index, v];
                        if (newDistance < d[v])
                        {
                            d[v] = newDistance;
                            prev[v] = index;
                        }

                        minPQ.UpdatePriority((v, d[v]));
                    }
                }
            }

            var route = BuildRoute(prev, s, t);

            return new Result
            {
                Distance = d[t],
                Route = route
            };
        }

        private int[] BuildRoute(int[] prev, int s, int t)
        {
            var node = t;
            var route = new List<int>();
            if (prev[t] != -1 || node == s)
            {
                while (node != -1)
                {
                    route.Insert(0, node);
                    node = prev[node];
                }
            }

            return route.ToArray();
        }
    }
}
