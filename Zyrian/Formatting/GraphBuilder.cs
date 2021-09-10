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
        private ListContainer _container;
        private Graph _graph = new Graph();

        public GraphBuilder(ListContainer container)
        {
            _container = container;
        }

       /// <summary>
       /// Строит граф из вершин и рёбер
       /// </summary>
       /// <returns></returns>
        public Graph BuildGraph()
        {
            BuildVertices();
            BuildEdges();
            return _graph;
        }

        /// <summary>
        /// Стороит вершины из списка вершин и добавляет в граф
        /// </summary>
        private void BuildVertices()
        {
            for (int i = 0; i < _container.from.Count; i++)
            {
                _graph.AddVertex(_container.vertices[i]);
            }
        }

        /// <summary>
        /// Стороит рёбра из списка вершин и добавляет в граф
        /// </summary>
        private void BuildEdges()
        {
            for (int i = 0; i < _container.from.Count; i++)
            {
                _graph.AddEdge(_container.from[i], _container.where[i], _container.cost[i]);
            }
        }
    }
}
