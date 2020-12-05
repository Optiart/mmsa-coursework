using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjikstaAndFloydWarshall
{
    public interface IFastestRouteFinder
    {
        Result Find(int[,] graph, int start, int target);
    }
}
