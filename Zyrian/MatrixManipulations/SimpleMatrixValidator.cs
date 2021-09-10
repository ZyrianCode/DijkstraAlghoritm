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

        /// <summary>
        /// Проверяет является ли размер двух массивов идентичным
        /// </summary>
        /// <returns></returns>
        public bool CheckIfSizeEqual() => _firstArray.Length == _secondArray.Length;

        /// <summary>
        /// Проверяет противоречит маршрутизация в матрице смежности с матрицой стоимости
        /// (Когда маршрута нет, а стоимость для пути есть)
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Конкретизированная проверка правильности маршрутизации в матрицах по индексам
        /// </summary>
        /// <param name="firstIndex"> первый индекс </param>
        /// <param name="secondIndex"> второй индекс </param>
        /// <returns>Логическое true - если пути одинаково выстроены в матрицах, Логическое false - если пути выстроены неодинаково </returns>
        private bool HasSameRoutes( int firstIndex, int secondIndex)
        {
            return (_firstArray[firstIndex, secondIndex] == 0 && _secondArray[firstIndex, secondIndex] == 0) ||
                (_firstArray[firstIndex, secondIndex] != 0 && _secondArray[firstIndex, secondIndex] != 0);
        }

    }
}
