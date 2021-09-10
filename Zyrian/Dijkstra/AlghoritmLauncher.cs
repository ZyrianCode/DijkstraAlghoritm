using Dijkstra.Zyrian.CustomGraph;
using Dijkstra.Zyrian.Formatting;
using Dijkstra.Zyrian.MatrixManipulations;
using Dijkstra.Zyrian.MatrixManipulations.CustomList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra.Zyrian.Dijkstra
{
    public class AlghoritmLauncher
    {
        private string _filePath;
        private Graph _graph;
        private ListContainer _list;
        private MatrixFiller _matrixFiller;
        private GraphCreator _graphCreator;
        private DijkstraAlghoritm _dijkstraAlghoritm;


        public void Start()
        {
            _matrixFiller = new MatrixFiller(_filePath);
            _matrixFiller.FillMatrix();
            _list = _matrixFiller.RouteToValidator();
            if (_list != null)
            {
                _graphCreator = new GraphCreator(_list);
                _graph = _graphCreator.CreateGraph();
                _graph.Print();
                _dijkstraAlghoritm = new DijkstraAlghoritm(_graph);
                var path = _dijkstraAlghoritm.FindShortestPathByName("A", "B");
                Console.WriteLine(path);
                Console.ReadLine();
            }
            else return;           
        }
        public void SetPath(string filePath) => _filePath = filePath;
    }
}
