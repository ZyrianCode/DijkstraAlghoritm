using Dijkstra.Zyrian.CustomGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra.Zyrian.Dijkstra
{
    public class VertexProperties
    {
        public Vertex Vertex { get; set; }

        public bool IsUnvisited { get; set; }

        public int EdgesCostSum { get; set; }

        public Vertex PreviousVertex { get; set; }

        public VertexProperties(Vertex vertex)
        {
            Vertex = vertex;
            IsUnvisited = true;
            EdgesCostSum = int.MaxValue;
            PreviousVertex = null;
        }
    }
}
