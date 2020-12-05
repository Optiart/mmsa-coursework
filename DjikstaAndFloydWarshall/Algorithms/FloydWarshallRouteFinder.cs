﻿using System;
using System.Collections.Generic;

namespace DjikstaAndFloydWarshall
{
    public class FloydWarshallRouteFinder : IFastestRouteFinder
    {
        public Result Find(int[,] graph, int source, int target)
        {
            var vertexCount = graph.GetLength(0);
            var distances = new long[vertexCount, vertexCount];
            var pathes = new int[vertexCount, vertexCount];

            Initialize(graph, distances, pathes);

            for (int k = 0; k < vertexCount; k++)
            {
                for (int i = 0; i < vertexCount; i++)
                {
                    for (int j = 0; j < vertexCount; j++)
                    {
                        long calculatedDistance;
                        if (distances[i, k] == long.MaxValue || distances[k, j] == long.MaxValue)
                        {
                            calculatedDistance = long.MaxValue;
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

        private void Initialize(int[,] graph, long[,] distances, int[,] pathes)
        {
            var vertexCount = graph.GetLength(0);
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    distances[i, j] = long.MaxValue;
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
