using Dijkstra.Zyrian.CustomGraph;
using Dijkstra.Zyrian.Dijkstra;
using Dijkstra.Zyrian.MatrixManipulations.CustomList;
using System;

namespace Dijkstra.Zyrian.Formatting
{
    public class GraphCreator
    {
        private ListContainer _container;
        public GraphCreator(ListContainer container)
        {
            _container = container;
        }

        /// <summary>
        /// Создаём граф
        /// </summary>
        /// <returns></returns>
        public Graph CreateGraph()
        {
            GraphBuilder graphBuilder = new GraphBuilder(_container);

            return graphBuilder.BuildGraph();
        }
    }
}