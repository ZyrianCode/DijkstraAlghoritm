using Dijkstra.Zyrian.MatrixManipulations.CustomList;
using Dijkstra.Zyrian.MatrixManipulations.CustomMatrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra.Zyrian.MatrixManipulations
{
    public class MatrixToList
    {
        private static Matrix _matrix = new Matrix();

        private ListContainer _container = new ListContainer();

        SimpleMatrixValidator smv = new SimpleMatrixValidator(_matrix.adjacencyMatrix, _matrix.weightMatrix);

        public void ToList()
        {
            if (smv.CheckIfSizeEqual() && smv.CheckIfRoutsEqual())
            {
                for (int i = 0; i < _matrix.adjacencyMatrix.Length; i++)
                {   
                    for (int j = 0; j < _matrix.adjacencyMatrix.Length; j++)
                    {
                        if (_matrix.adjacencyMatrix[i, j] != 0 || _matrix.weightMatrix[i, j] != 0)
                        {
                            ToFromList(i.ToString());
                            ToWhereList(j.ToString());
                            ToVerticesList(_matrix.adjacencyMatrix[i, j].ToString());
                            ToCostList(_matrix.weightMatrix[i, j]);
                        }
                    }
                }
            }
        }

        private void ToFromList(string element) => _container.from.Add(element);
        private void ToWhereList(string element) => _container.where.Add(element);
        private void ToVerticesList(string element) => _container.vertices.Add(element);
        private void ToCostList(int element) => _container.cost.Add(element);
    }
}
