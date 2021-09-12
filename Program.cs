using Dijkstra.Zyrian.CustomGraph;
using Dijkstra.Zyrian.Dijkstra;
//using Dijkstra.Zyrian.Formatting;
//using Dijkstra.Zyrian.MatrixManipulations;
//using Dijkstra.Zyrian.MatrixManipulations.CustomList;
using System;
using System.IO;

namespace Dijkstra
{
    class Program
    {
        static void Main(string[] args)
        {
            //var graph = new Graph();

            //graph.AddVertex("A");
            //graph.AddVertex("B");
            //graph.AddVertex("C");
            //graph.AddVertex("D");
            //graph.AddVertex("E");
            //graph.AddVertex("F");
            //graph.AddVertex("G");

            //graph.AddEdge("A", "B", 22);
            //graph.AddEdge("A", "C", 33);
            //graph.AddEdge("A", "D", 61);
            //graph.AddEdge("B", "C", 47);
            //graph.AddEdge("B", "E", 93);
            //graph.AddEdge("C", "D", 11);
            //graph.AddEdge("C", "E", 79);
            //graph.AddEdge("C", "F", 63);
            //graph.AddEdge("D", "F", 41);
            //graph.AddEdge("E", "F", 17);
            //graph.AddEdge("E", "G", 58);
            //graph.AddEdge("F", "G", 84);

            //var djkstra = new DijkstraAlghoritm(graph);
            //var path = djkstra.FindShortestPathByName("A", "B");
            //Console.WriteLine(path);
            //Console.ReadLine();

            //graph.Print();
            AlghoritmLauncher alghoritm = new AlghoritmLauncher();

            alghoritm.SetPath("E:/DijkstraAlghoritm/Zyrian/Utils/Matrix.txt");
            alghoritm.Start();

        }
    }
}
