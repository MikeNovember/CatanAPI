using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatanAPI.Logic
{
    public class Edge : EdgeInterface
    {
        private readonly int _number;

        public Edge(int number)
        {
            _number = number;
        }

        int EdgeInterface.Number { get => _number; }
    }
}
