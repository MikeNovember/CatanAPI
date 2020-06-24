using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatanAPI.Logic
{
    public class Tile : TileInterface
    {
        private readonly int _number;
        private readonly ResourceType _resourceType;

        public Tile(int number, ResourceType resourceType)
        {
            _number = number;
            _resourceType = resourceType;
        }

        int TileInterface.Number { get => _number; }

        ResourceType TileInterface.Resource { get => _resourceType; }
    }
}
