using System;
using System.Collections.Generic;

namespace DjikstaAndFloydWarshall
{
    public class FloydWarshallRouteFinder : IFastestRouteFinder
    {
        public Result Find(List<List<int>> graph, int source, int target)
        {
            var vertexCount = graph.Count;
            var distances = new int[vertexCount, vertexCount];
            var pathes = new int[vertexCount, vertexCount];

            Initialize(graph, distances, pathes);

            for (int k = 0; k < vertexCount; k++)
            {
                for (int i = 0; i < vertexCount; i++)
                {
                    for (int j = 0; j < vertexCount; j++)
                    {
                        int calculatedDistance;
                        if (distances[i, k] == int.MaxValue || distances[k, j] == int.MaxValue)
                        {
                            calculatedDistance = int.MaxValue;
                        }
                        else
                        {
                            calculatedDistance = distances[i, k] + distances[k, j];
                        }

                        if (distances[i, j] > calculatedDistance)
                        {
                            distances[i, j] = calculatedDistance;
                            pathes[i, j] = pathes[i, k];
                        }
                    }
                }
            }

            var route = BuildRoute(pathes, source, target);

            return new Result
            {
                Distance = distances[source, target],
                Route = route
            };
        }

        private void Initialize(List<List<int>> graph, int[,] distances, int[,] pathes)
        {
            var vertexCount = graph.Count;
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    distances[i, j] = int.MaxValue;
                    pathes[i, j] = i == j ? i : -1;
                }
            }

            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    if (graph[i][j] != -1)
                    {
                        distances[i, j] = graph[i][j];
                    }

                    pathes[i, j] = j;
                }
            }
        }

        private int[] BuildRoute(int[,] pathes, int source, int target)
        {
            if (pathes[source, target] == -1)
            {
                return Array.Empty<int>();
            }

            var route = new List<int>
            {
                source
            };

            var currentNode = source;
            while (currentNode != target)
            {
                currentNode = pathes[currentNode, target];
                route.Add(currentNode);
            }

            return route.ToArray();
        }
    }
}
