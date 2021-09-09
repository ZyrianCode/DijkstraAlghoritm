using Dijkstra.Zyrian.CustomGraph;
using Dijkstra.Zyrian.MatrixManipulations.CustomList;
using Dijkstra.Zyrian.MatrixManipulations.CustomMatrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra.Zyrian.Formatting
{
    public class GraphBuilder
    {
        private ListContainer _container = new ListContainer();
        private Graph _graph = new Graph();

        public Graph BuildGraph()
        {
            BuildVertices();
            BuildEdges();
            return _graph;
        }

        private void BuildVertices()
        {
            for (int i = 0; i < _container.from.Count; i++)
            {
                _graph.AddVertex(_container.vertices[i]);
            }
        }

        private void BuildEdges()
        {
            for (int i = 0; i < _container.from.Count; i++)
            {
                _graph.AddEdge(_container.from[i], _container.where[i], _container.cost[i]);
            }
        }
    }
}
