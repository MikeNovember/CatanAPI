using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatanAPI.Logic
{
    public interface TileInterface
    {
        /*
        * Assume following tile numbering:
        *       /  1   2   3   \
        *      / 4   5    6   7 \
        *     | 8  9  10  11  12 |
        *      \ 13  14  15  16 /
        *       \  17  18  19  /
        */

        public enum TileEdgeDirection
        {
            NW,
            NE,
            E,
            SE,
            SW,
            W
        };

        public enum TileIntersectionDirection
        {
            N,
            NE,
            SE,
            S,
            SW,
            NW
        };

        public int Number { get; }
        public ResourceType Resource { get; }

        protected static EdgeInterface GetAdjacentEdge(int tileNumber, TileEdgeDirection direction)
        {
            return new Edge(1);
        }

        protected static IntersectionInterface GetAdjacentIntersection(int tileNumber, TileIntersectionDirection direction)
        {
            return new Intersection(1);
        }

        protected static IList<EdgeInterface> GetAdjacentEdges(int tileNumber)
        {
            return new List<EdgeInterface>();
        }

        protected static IList<IntersectionInterface> GetAdjacentIntersections(int tileNumber)
        {
            return new List<IntersectionInterface>();
        }
    }
}
