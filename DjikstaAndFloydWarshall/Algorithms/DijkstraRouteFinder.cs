using System.Collections.Generic;

namespace DjikstaAndFloydWarshall
{
    public class DijkstraRouteFinder : IFastestRouteFinder
    {
        public Result Find(int[,] graph, int source, int target)
        {
            var vertexCount = graph.GetLength(0);
            var distances = new int[vertexCount];
            var visited = new bool[vertexCount];

            var minPQ = new SimpleMinimumPriorityQueue();
            minPQ.UpdatePriority((source, 0));
            var previousVertecies = new int[vertexCount];

            for (int i = 0; i < previousVertecies.Length; i++)
            {
                previousVertecies[i] = -1;
            }

            for (int i = 0; i < distances.Length; i++)
            {
                distances[i] = i == source ? 0 : int.MaxValue;
            }

            while (!minPQ.IsEmpty)
            {
                var (index, _) = minPQ.ExtractMin();
                visited[index] = true;

                if (index == target)
                {
                    break;
                }

                for (int vertex = 0; vertex < vertexCount; vertex++)
                {
                    if (graph[index, vertex] != -1 && !visited[vertex])
                    {
                        var newDistance = distances[index] + graph[index, vertex];
                        if (newDistance < distances[vertex])
                        {
                            distances[vertex] = newDistance;
                            previousVertecies[vertex] = index;
                        }

                        minPQ.UpdatePriority((vertex, distances[vertex]));
                    }
                }
            }

            var route = BuildRoute(previousVertecies, source, target);

            return new Result
            {
                Distance = distances[target],
                Route = route
            };
        }

        private int[] BuildRoute(int[] previousVertecies, int source, int target)
        {
            var node = target;
            var route = new List<int>();
            if (previousVertecies[target] != -1 || node == source)
            {
                while (node != -1)
                {
                    route.Insert(0, node);
                    node = previousVertecies[node];
                }
            }

            return route.ToArray();
        }
    }
}
