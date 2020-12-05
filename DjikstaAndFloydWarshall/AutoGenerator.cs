using System;
using System.Collections.Generic;
using System.Linq;

namespace DjikstaAndFloydWarshall
{
    public static class AutoGenerator
    {
        private static Random _random = new Random();

        public static List<City> GenerateCitiesForDemo()
        {
            var cities = new List<City>
            {
                new City(0, "Київ"),
                new City(1, "Житомир"),
                new City(2, "Львів"),
                new City(3, "Хмельницький"),
                new City(4, "Вінниця"),
                new City(5, "Тернопіль"),
                new City(6, "Рівне"),
                new City(7, "Івано-Франківськ")
            };

            cities[0].Connections.Add(new Connection(cities[1], 140)); // Житомир
            cities[0].Connections.Add(new Connection(cities[4], 267)); // Вінниця
            cities[1].Connections.Add(new Connection(cities[6], 222)); // Рівне
            cities[1].Connections.Add(new Connection(cities[4], 129)); // Вінниця
            cities[1].Connections.Add(new Connection(cities[3], 183)); // Хмельницький
            cities[3].Connections.Add(new Connection(cities[5], 111)); // Тернопіль
            cities[3].Connections.Add(new Connection(cities[6], 194)); // Рівне
            cities[4].Connections.Add(new Connection(cities[3], 119)); // Хмельницький
            cities[5].Connections.Add(new Connection(cities[2], 127)); // Львів
            cities[5].Connections.Add(new Connection(cities[7], 144)); // Івано-Франківськ
            cities[6].Connections.Add(new Connection(cities[5], 153)); // Тернопіль
            cities[6].Connections.Add(new Connection(cities[2], 210)); // Львів
            cities[7].Connections.Add(new Connection(cities[2], 132)); // Львів

            return cities;
        }

        public static List<City> GenerateCitiesAndConnectionsForLoad(int cityCount, int maxConnections, int maxDistance)
        {
            var cities = new List<City>();

            for (int i = 0; i < cityCount; i++)
            {
                cities.Add(new City(i, $"City-{i}"));
            }

            for (int i = 0; i < cities.Count; i++)
            {
                for (int j = 0; j < _random.Next(1, maxConnections); j++)
                {
                    var cityIdToConnect = _random.Next(Math.Min(i + 1, cityCount - 1), Math.Min(cityCount, i + maxConnections));

                    if (cities[i].Id == cityIdToConnect ||
                        cities[i].Connections.Any(c => c.City.Id == cityIdToConnect))
                    {
                        continue;
                    }

                    cities[i].Connections.Add(
                        new Connection(cities.FirstOrDefault(c => c.Id == cityIdToConnect), _random.Next(1, maxDistance)));
                }
            }

            return cities;
        }
    }
}
