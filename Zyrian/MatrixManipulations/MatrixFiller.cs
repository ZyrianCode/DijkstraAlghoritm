using Dijkstra.Zyrian.MatrixManipulations.CustomList;
using Dijkstra.Zyrian.MatrixManipulations.CustomMatrix;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dijkstra.Zyrian.MatrixManipulations
{
    public class MatrixFiller
    {
        Matrix matrix = new Matrix();
        private ListContainer listContainer = new ListContainer();

        private string _filePath;
        public MatrixFiller(string filePath)
        {
            _filePath = filePath;
        }

        public void FillMatrix()
        {
            using (StreamReader sr = new StreamReader(_filePath))
            {
                string line = sr.ReadLine();
                
                int size = Convert.ToInt32(line);

                matrix.adjacencyMatrix = new int[size, size];
                matrix.weightMatrix = new int[size, size];

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        matrix.adjacencyMatrix[i, j] = 0;
                        matrix.weightMatrix[i, j] = 0;
                    }
                }
                string[] words;
                int v;
                int w;
                int c;

                while ((line = sr.ReadLine()) != null)
                {
                    words = line.Split(new char[] { ' ' });
                    v = Convert.ToInt32(words[0]);
                    w = Convert.ToInt32(words[1]);
                    c = Convert.ToInt32(words[2]);

                    matrix.adjacencyMatrix[v-1, w-1] = 1;
                    matrix.weightMatrix[v-1, w-1] = c;
                    Console.WriteLine($"{v} {w} {c}");
                }
            }

            //ParseFromFile();

            Console.WriteLine("Матрица смежности: ");
            Print(matrix.adjacencyMatrix);
            Console.WriteLine("Матрица стоимости: ");
            Print(matrix.weightMatrix);
        }

        /// <summary>
        /// Печатает матрицу
        /// </summary>
        /// <param name="arrayToPrint"></param>
        public void Print(int[,] arrayToPrint)
        {
            int length = arrayToPrint.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(arrayToPrint[i, j] + " ");
                }
                Console.WriteLine();
            }            
        }

        /// <summary>
        /// Передаёт матрицу в валидатор на проверку
        /// </summary>
        /// <returns> контейнер списков или пустой контейнер, если матрица была невалидной </returns>
        public ListContainer RouteToValidator()
        {
            SimpleMatrixValidator smv = new SimpleMatrixValidator(matrix.adjacencyMatrix, matrix.weightMatrix);
            if (smv.CheckIfSizeEqual() && smv.CheckIfRoutsEqual())
	        {
                return RouteToMatrix();
	        }
            else return listContainer.GetEmptyList();
        }
        /// <summary>
        /// Передаёт матрицу конвертироваться в контейнер списков
        /// </summary>
        /// <returns> список </returns>
        private ListContainer RouteToMatrix()
        {
            MatrixToList matrixToList = new MatrixToList(matrix.adjacencyMatrix, matrix.weightMatrix);
            return matrixToList.ToList();
            
        }
    }
}
