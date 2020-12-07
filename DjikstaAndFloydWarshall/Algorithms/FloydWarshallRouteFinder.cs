using System;
using System.Collections.Generic;

namespace DjikstaAndFloydWarshall
{
    public class FloydWarshallRouteFinder : IFastestRouteFinder
    {
        private const long inf = long.MaxValue;

        public Result Find(int[,] graph, int s, int t)
        {
            var vertexCount = graph.GetLength(0);
            var d = new long[vertexCount, vertexCount];
            var pathes = new int[vertexCount, vertexCount];

            Initialize(graph, d, pathes);

            for (int k = 0; k < vertexCount; k++)
            {
                for (int i = 0; i < vertexCount; i++)
                {
                    for (int j = 0; j < vertexCount; j++)
                    {
                        long calculatedDistance;
                        if (d[i, k] == inf || d[k, j] == inf)
                        {
                            calculatedDistance = inf;
                        }
                        else
                        {
                            calculatedDistance = d[i, k] + d[k, j];
                        }

                        if (d[i, j] > calculatedDistance)
                        {
                            d[i, j] = calculatedDistance;
                            pathes[i, j] = pathes[i, k];
                        }
                    }
                }
            }

            var route = BuildRoute(pathes, s, t);

            return new Result
            {
                Distance = d[s, t],
                Route = route
            };
        }

        private void Initialize(int[,] graph, long[,] distances, int[,] pathes)
        {
            var vertexCount = graph.GetLength(0);
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    distances[i, j] = inf;
                    pathes[i, j] = i == j ? i : -1;
                }
            }

            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    if (graph[i, j] != -1)
                    {
                        distances[i, j] = graph[i, j];
                    }

                    pathes[i, j] = j;
                }
            }
        }

        private int[] BuildRoute(int[,] pathes, int s, int t)
        {
            if (pathes[s, t] == -1)
            {
                return Array.Empty<int>();
            }

            var route = new List<int>
            {
                s
            };

            var node = s;
            while (node != t)
            {
                node = pathes[node, t];
                route.Add(node);
            }

            return route.ToArray();
        }
    }
}
