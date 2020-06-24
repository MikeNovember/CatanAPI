using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatanAPI.Logic
{
    public interface EdgeInterface
    {
        public int Number { get; }

        protected static IList<TileInterface> GetAdjacentTiles(int number)
        {
            return new List<TileInterface>();
        }

        protected static IList<IntersectionInterface> GetAdjacentIntersections(int number)
        {
            return new List<IntersectionInterface>();
        }
    }
}
