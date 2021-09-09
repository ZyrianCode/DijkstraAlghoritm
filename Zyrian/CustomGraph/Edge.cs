using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra.Zyrian.CustomGraph
{
    public class Edge
    {
        public Edge(Vertex linkedVertex, int cost)
        {
            LinkedVertex = linkedVertex;
            EdgeCost = cost;
        }
        public Vertex LinkedVertex { get; }

        public int EdgeCost { get; }
    }
}
