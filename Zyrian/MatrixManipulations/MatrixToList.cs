using Dijkstra.Zyrian.MatrixManipulations.CustomList;
using Dijkstra.Zyrian.MatrixManipulations.CustomMatrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dijkstra.Zyrian.Formatting;

namespace Dijkstra.Zyrian.MatrixManipulations
{
    public class MatrixToList
    {
        private int[,] _firstMatrix;
        private int[,] _secondMatrix;
        
        public MatrixToList (int[,] firstArray, int[,] secondArray)
        {
            _firstMatrix = firstArray;
            _secondMatrix = secondArray;
        }
        private ListContainer _container = new ListContainer();

        /// <summary>
        /// Конвертирует матрицу в контейнер списков
        /// </summary>
        /// <returns> контейнер списков </returns>
        public ListContainer ToList()
        {
            int lengthOfRow = (int)Math.Sqrt(_firstMatrix.Length);
            int countOfVerticies = 0;
            for (int i = 0; i < lengthOfRow; i++)
            {   
                for (int j = 0; j < lengthOfRow; j++)
                {
                    if (_firstMatrix[i, j] != 0 && _secondMatrix[i, j] != 0)
                    {
                        ToFromList(i.ToString());
                        ToWhereList(j.ToString());
                        ToCostList(_secondMatrix[i, j]);
                    }
                }
            }

            for (int vertex = 0; countOfVerticies != lengthOfRow; vertex++) {
                countOfVerticies++;
                ToVerticesList(vertex.ToString()); 
            }
            
            return _container;
        }

        private void ToFromList(string element) => _container.from.Add(element);
        private void ToWhereList(string element) => _container.where.Add(element);
        private void ToVerticesList(string element) => _container.vertices.Add(element);
        private void ToCostList(int element) => _container.cost.Add(element);
    }
}
