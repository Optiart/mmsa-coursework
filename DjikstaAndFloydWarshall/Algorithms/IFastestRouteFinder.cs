namespace DjikstaAndFloydWarshall
{
    public interface IFastestRouteFinder
    {
        Result Find(int[,] graph, int start, int target);
    }
}
