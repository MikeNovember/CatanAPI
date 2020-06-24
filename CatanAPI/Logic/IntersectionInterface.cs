using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatanAPI.Logic
{
    public interface IntersectionInterface
    {
        public int Number { get; }

        protected static IList<TileInterface> GetAdjacentTiles(int number)
        {
            return new List<TileInterface>();
        }

        protected static IList<EdgeInterface> GetAdjacentEdges(int number)
        {
            return new List<EdgeInterface>();
        }
    }
}
