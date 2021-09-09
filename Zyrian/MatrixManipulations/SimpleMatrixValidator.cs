using Dijkstra.Zyrian.MatrixManipulations.CustomMatrix;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra.Zyrian.MatrixManipulations
{
    public class SimpleMatrixValidator
    {
        private int[,] _firstArray;
        private int[,] _secondArray;

        public SimpleMatrixValidator(int[,]firstArray, int[,]secondArray)
        {
            _firstArray = firstArray;
            _secondArray = secondArray;
        }

        public bool CheckIfSizeEqual() => _firstArray.Length == _secondArray.Length;

        public bool CheckIfRoutsEqual()
        {
            int correctMatches = 0;
            for (int i = 0; i < _firstArray.Length; i++)
            {
                for (int j = 0; j < _firstArray.Length; j++)
                {
                    if (HasSameRoutes(i, j))
                    {
                        correctMatches++;
                    }
                    else
                    {
                        Console.WriteLine("This matrix has errors! Try another matrix.");
                        return false;
                    }
                }
            }
            return true;
        }

        private bool HasSameRoutes( int firstIndex, int secondIndex)
        {
            return (_firstArray[firstIndex, secondIndex] == 0 && _secondArray[firstIndex, secondIndex] == 0) ||
                (_firstArray[firstIndex, secondIndex] != 0 && _secondArray[firstIndex, secondIndex] != 0);
        }

    }
}
