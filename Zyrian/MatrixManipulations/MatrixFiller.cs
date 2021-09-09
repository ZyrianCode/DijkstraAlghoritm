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

        static string path = "D:/Users/RyzenPC/Program/VisualStudio IDE/СSharp/Console/Templates/Dijkstra/Zyrian/Utils/Matrix.txt";

        //public static StreamReader streamReader = new StreamReader(path);

        //string line;

        //int size;

        public void FillMatrix()
        {
            using (StreamReader sr = new StreamReader(path))
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
                        matrix.weightMatrix[i, j] = Int32.MaxValue;
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

        public void ParseFromFile()
        {
            //string[] words;
            //int v;
            //int w;
            //int c;

            //while ((line = sr.ReadLine()) != null)
            //{
            //    words = line.Split(new char[] { ' ' });
            //    v = Convert.ToInt32(words[0]);
            //    w = Convert.ToInt32(words[1]);
            //    c = Convert.ToInt32(words[2]);

            //    matrix.adjacencyMatrix[v--, w--] = 1;
            //    matrix.weightMatrix[v--, w--] = c;
            //}
        }
        public void Print(int[,] arrayToPrint)
        {
            int length = arrayToPrint.GetLength(0);
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.WriteLine(arrayToPrint[i, j]);
                }
                Console.WriteLine();
            }            
        }

    }
}
