namespace DjikstaAndFloydWarshall
{
    public class Connection
    {
        public City City { get; set; }

        public int DistanceKm { get; }

        public Connection(City city, int distanceKm)
        {
            City = city;
            DistanceKm = distanceKm;
        }

        public override string ToString() => $"{City.Name} - {DistanceKm} км";
    }
}
