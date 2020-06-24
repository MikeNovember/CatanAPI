using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatanAPI.Logic
{
    public class Intersection : IntersectionInterface
    {
        private readonly int _number;

        public Intersection(int number)
        {
            _number = number;
        }

        int IntersectionInterface.Number { get => _number; }
    }
}
