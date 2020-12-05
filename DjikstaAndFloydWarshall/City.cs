using System.Collections.Generic;

namespace DjikstaAndFloydWarshall
{
    public class City
    {
        public int Id { get; }

        public string Name { get; }

        public List<Connection> Connections { get; } = new List<Connection>();

        public City(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => $"{Name}";
    }
}
