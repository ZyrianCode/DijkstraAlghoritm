using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra.Zyrian.CustomGraph
{
    public class Vertex
    {
        public string Name { get; }

        public List<Edge> Edges { get; }

        public Vertex(string vertexName)
        {
            Name = vertexName;
            Edges = new List<Edge>();
        }

        public Edge AddEdge(Edge newEdge)
        {
            Edges.Add(newEdge);
            return newEdge;
        }

        public Edge AddEdge(Vertex vertex, int edgeCost) => AddEdge(new Edge(vertex, edgeCost));

        public void Print()
        {
            foreach (var edge in Edges)
            {
                Console.WriteLine(edge.LinkedVertex.Name + " Стоимость: " + edge.EdgeCost);
            }
        }
        public override string ToString() => Name;
    }
}
