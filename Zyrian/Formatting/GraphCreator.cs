using Dijkstra.Zyrian.CustomGraph;
using Dijkstra.Zyrian.Dijkstra;
using Dijkstra.Zyrian.MatrixManipulations.CustomList;
using System;

namespace Dijkstra.Zyrian.Formatting
{
    public class GraphCreator
    {
        private Container _container;

        public GraphCreator(Container container)
        {
            _container = container;
        }

        /// <summary>
        /// Создаёт граф
        /// </summary>
        /// <returns></returns>
        public Graph CreateGraph()
        {
            GraphBuilder graphBuilder = new(_container);

            return graphBuilder.BuildGraph();
        }
    }
}